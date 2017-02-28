using System;
using System.Collections.Generic;
using System.Linq;

namespace Portable_Simulacrum
{
    public class Weapon
    {
        public Damage damage { get; private set; }
        public double multiShot { get; private set; }
        public double fireRate { get; private set; }
        public double critChan { get; private set; }
        public double critMult { get; private set; }
        public double totalStatChan { get; private set; }
        public double pelletStatChan { get; private set; }
        public double reload { get; private set; }
        public int clip { get; private set; }
        public Data.WeaponType type { get; private set; }
        public Weapon(Damage _damage, double _multiShot, double _fireRate, double _critChan, double _critMult, double _totalStatChan, double _reload, int _clip, Data.WeaponType _type, bool raw = false)
        {
            damage = raw ? _damage.Scale(1 / _multiShot) : _damage;
            multiShot = _multiShot;
            fireRate = _fireRate;
            critChan = _critChan;
            critMult = _critMult;
            totalStatChan = _totalStatChan;
            pelletStatChan = (totalStatChan >= 1) ? 1 : 1 - Math.Pow((1 - totalStatChan), 1 / multiShot);
            reload = _reload;
            clip = _clip;
            type = _type;
        }
        public Weapon(double[] _dmgArray, double _multiShot, double _fireRate, double _critChan, double _critMult, double _totalStatChan, double _reload, int _clip, Data.WeaponType _type, bool raw = false)
        {
            damage = new Damage(_dmgArray);
            if (raw) damage = damage.Scale(1 / _multiShot);
            multiShot = _multiShot;
            fireRate = _fireRate;
            critChan = _critChan;
            critMult = _critMult;
            totalStatChan = _totalStatChan;
            pelletStatChan = (totalStatChan >= 1) ? 1 : 1 - Math.Pow((1 - totalStatChan), 1 / multiShot);
            reload = _reload;
            clip = _clip;
            type = _type;
        }

        public Weapon Modify(Mod mod)
        {
            Weapon modWeapon = Clone();
            modWeapon.critChan*= (1 + mod.multiplier[(int)Data.ModProp.CritChan]);
            modWeapon.critMult *= (1 + mod.multiplier[(int)Data.ModProp.CritMult]);
            modWeapon.totalStatChan *= (1 + mod.multiplier[(int)Data.ModProp.StatChan]);
            modWeapon.pelletStatChan = (modWeapon.totalStatChan >= 1) ? 1 : 1 - Math.Pow((1 - modWeapon.totalStatChan), 1 / modWeapon.multiShot);
            modWeapon.multiShot *= (1 + mod.multiplier[(int)Data.ModProp.Multi]);
            modWeapon.totalStatChan = 1 - Math.Pow(1 - modWeapon.pelletStatChan, modWeapon.multiShot);
            modWeapon.fireRate *= (1 + mod.multiplier[(int)Data.ModProp.FireRate] * (type == Data.WeaponType.Bow ? 2 : 1));
            modWeapon.clip *= (int)Math.Round(1 + mod.multiplier[(int)Data.ModProp.Clip]);
            modWeapon.reload /= (1 + mod.multiplier[(int)Data.ModProp.Reload]);
            mod.Combine(this);
            modWeapon.damage.Modify(mod);
            return modWeapon;
        }

        public Data.Simdata SimKill(Enemy enemy, Mod mod, bool headshot = false)
        {
            Weapon modWeapon = Modify(mod);

            double dt = 0.01f, t = 0.0f, lastT = 0.0f;
            double fireDelta = 1 / modWeapon.fireRate;
            int shots = 0, clip = modWeapon.clip, reloadCount = 0;
            bool inReload = false;
            Random rnd = new Random();
            SortedList<double, Damage> dmgQueue = new SortedList<double, Damage>(new DuplicateKeyComparer<double>());

            double baseDmg = damage.BaseDamage(mod);
            double toxinDmg = damage.ToxinDamage(mod);
            double physDmg = damage.PhysDamage();

            while (enemy.health > 0 && t <= Data.timeLimit)
            {
                if (inReload)
                {
                    reloadCount++;
                    t += modWeapon.reload;
                    inReload = false;
                }
                else
                {
                    t += dt;
                }
                while (shots * fireDelta + reloadCount * modWeapon.reload <= t && !inReload)
                {
                    shots++;
                    int multInt = (int)modWeapon.multiShot;
                    double multDec = modWeapon.multiShot - (double)multInt;
                    if (rnd.NextDouble() <= multDec) multInt++;
                    for (int i = 0; i < multInt; i++)
                    {
                        double crit = modWeapon.critMult;
                        int critInt = (int)modWeapon.critChan;
                        double critDec = modWeapon.critChan - (double)critInt;
                        if (rnd.NextDouble() <= critDec) critInt++;
                        crit = critInt * (modWeapon.critMult - 1) + 1;
                        if (headshot)
                        {
                            crit *= (crit > 1) ? 4 : 2;
                        }
                        dmgQueue.Add(t, modWeapon.damage.Scale(crit));

                        if (rnd.NextDouble() > modWeapon.pelletStatChan) continue;
                        Damage statDmg = modWeapon.damage.StatDamage();
                        double statRnd = rnd.NextDouble();
                        int statType = 0;
                        while (statRnd > 0)
                        {
                            statRnd -= statDmg.dmgArray[statType] / statDmg.totalDmg;
                            statType++;
                        }
                        statType--;

                        switch ((Data.DamageType)statType)
                        {
                            case Data.DamageType.Impact:
                            case Data.DamageType.Puncture:
                            case Data.DamageType.Cold:
                            case Data.DamageType.Blast:
                            case Data.DamageType.Radiation:
                                break;
                            case Data.DamageType.Electricity:
                                dmgQueue.Add(t, new Damage(baseDmg * 0.50f, Data.DamageType.Electricity));
                                break;
                            case Data.DamageType.Heat:
                            case Data.DamageType.Viral:
                                dmgQueue.Add(t + 0.02 * dt, modWeapon.damage.StatTrigger((Data.DamageType)statType));
                                break;
                            case Data.DamageType.Corrosive:
                                dmgQueue.Add(t - 0.02 * dt, modWeapon.damage.StatTrigger((Data.DamageType)statType));
                                break;
                            case Data.DamageType.Slash:
                                for (int k = 0; k <= 6; k++)
                                {
                                    dmgQueue.Add(t + (double)k, new Damage(baseDmg * 0.35f, Data.DamageType.Finishing));
                                }
                                break;
                            case Data.DamageType.Toxin:
                                for (int k = 0; k <= 8; k++)
                                {
                                    dmgQueue.Add(t + (double)k, new Damage(toxinDmg * 0.50f, Data.DamageType.Toxin));
                                }
                                break;
                            case Data.DamageType.Gas:
                                dmgQueue.Add(t, new Damage((physDmg + toxinDmg) / 2, Data.DamageType.Toxin));
                                for (int k = 0; k <= 8; k++)
                                {
                                    dmgQueue.Add(t + (double)k, new Damage(toxinDmg * 1.25f, Data.DamageType.Toxin));
                                }
                                break;
                        }
                    }
                    clip--;
                    if (clip == 0)
                    {
                        clip = modWeapon.clip;
                        inReload = true;
                    }
                }

                int indx = 0;
                while (indx < dmgQueue.Count() && dmgQueue.Keys[indx] <= t)
                {
                    double currT = dmgQueue.First().Key;
                    Damage currDmg = dmgQueue.First().Value;
                    if ((int)(currT - enemy.heatStart) != (int)(lastT - enemy.heatStart) && (lastT - enemy.heatStart <= 6.0f))
                    {
                        dmgQueue.Add(currT, new Damage(baseDmg / 2, Data.DamageType.Heat));
                    }
                    if (currDmg.statType == Data.DamageType.Heat)
                    {
                        enemy.ProcHeat(currT);
                        dmgQueue.Add(currT, new Damage(baseDmg / 2, Data.DamageType.Heat));
                    }
                    lastT = currT;
                    indx++;
                }

                while (dmgQueue.Count() > 0 && dmgQueue.First().Key <= t)
                {
                    double currT = dmgQueue.First().Key;
                    Damage currDmg = dmgQueue.First().Value;
                    if ((currT - enemy.viralStart > 6.0f) && enemy.inViral)
                    {
                        enemy.UnProcViral();
                    }
                    switch (currDmg.statType)
                    {
                        case Data.DamageType.Heat:
                            break;
                        case Data.DamageType.Corrosive:
                            enemy.ProcCorro();
                            break;
                        case Data.DamageType.Viral:
                            enemy.ProcViral(currT);
                            break;
                        default:
                            enemy.ApplyDamage(currDmg);
                            break;
                    }
                    dmgQueue.RemoveAt(0);
                    lastT = currT;
                }
            }
            return new Data.Simdata(t, shots);
        }

        public Weapon Clone()
        {
            return new Weapon(damage.Clone(), multiShot, fireRate, critChan, critMult, totalStatChan, reload, clip, type);
        }
    }
}
