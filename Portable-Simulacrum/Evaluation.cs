using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    class Evaluation
    {
        public static Basics.Simdata SimKill(Basics.Enemy enemy, Basics.Weapon weapon)
        {
            double dt = 0.01f, t = 0.0f, lastT = 0.0f;
            double fireDelta = 1 / weapon.fireRate;
            int shots = 0, clip = weapon.clip, reloadCount = 0;
            bool inViral = false, inReload = false;
            double heatDmg, heatStart = -10, viralStart = -10;
            double lostHealth = 0, lostShield = 0;
            Random rnd = new Random();
            SortedList<double, double[]> dmgQueue = new SortedList<double, double[]>(new DuplicateKeyComparer<double>());

            while (enemy.health > 0 && t <= 180)
            {
                if (inReload)
                {
                    reloadCount++;
                    t += weapon.reload;
                    inReload = false;
                }
                else
                {
                    t += dt;
                }
                while (shots * fireDelta + reloadCount * weapon.reload <= t && !inReload)
                {
                    shots++;
                    int multInt = (int)weapon.multi;
                    double multDec = weapon.multi - (double)multInt;
                    if (rnd.NextDouble() <= multDec) multInt++;
                    for (int i = 0; i < multInt; i++)
                    {
                        double crit = weapon.critMult;
                        int critInt = (int)weapon.critChan / 100;
                        double critDec = weapon.critChan / 100 - (double)critInt;
                        if (rnd.NextDouble() <= critDec) critInt++;
                        crit = critInt * (weapon.critMult - 1) + 1;
                        dmgQueue.Add(t, Basics.Crit((double[])weapon.dmg.Clone(), crit));

                        if (rnd.NextDouble() > weapon.statChan) continue;
                        double statSum = 0;
                        double[] statDmg = (double[])weapon.dmg.Clone();
                        for (int j = 0; j <= 2; j++)
                        {
                            statDmg[j] *= 4;
                        }
                        for (int j = 0; j < (int)Basics.Damage.Total; j++)
                        {
                            statSum += statDmg[j];
                        }
                        double statRnd = rnd.NextDouble();
                        int statType = 0;
                        while (statRnd > 0)
                        {
                            statRnd -= statDmg[statType] / statSum;
                            statType++;
                        }
                        statType--;
                        double baseDmg = weapon.dmg[(int)Basics.Damage.Total] / weapon.elemBonus;
                        double toxinDmg = weapon.dmg[(int)Basics.Damage.Toxin] + weapon.dmg[(int)Basics.Damage.Gas] * weapon.toxinRatio;
                        double physDmg = weapon.dmg[(int)Basics.Damage.Impact] + weapon.dmg[(int)Basics.Damage.Puncture] + weapon.dmg[(int)Basics.Damage.Slash];
                        switch ((Basics.Damage)statType)
                        {
                            case Basics.Damage.Impact:
                            case Basics.Damage.Puncture:
                            case Basics.Damage.Cold:
                            case Basics.Damage.Blast:
                            case Basics.Damage.Radiation:
                                break;
                            case Basics.Damage.Electricity:
                                dmgQueue.Add(t, Basics.PureDmg(baseDmg * 0.50f, Basics.Damage.Electricity));
                                break;
                            case Basics.Damage.Heat:
                            case Basics.Damage.Viral:
                                dmgQueue.Add(t + 0.02 * dt, Basics.Status((double[])weapon.dmg.Clone(), ((Basics.Damage)statType)));
                                break;
                            case Basics.Damage.Corrosive:
                                dmgQueue.Add(t - 0.02 * dt, Basics.Status((double[])weapon.dmg.Clone(), ((Basics.Damage)statType)));
                                break;
                            case Basics.Damage.Slash:
                                for (int k = 0; k <= 6; k++)
                                {
                                    dmgQueue.Add(t + (double)k, Basics.PureDmg(baseDmg * 0.35f, Basics.Damage.Finishing));
                                }
                                break;
                            case Basics.Damage.Toxin:
                                for (int k = 0; k <= 8; k++)
                                {
                                    dmgQueue.Add(t + (double)k, Basics.PureDmg(toxinDmg * 0.50f, Basics.Damage.Toxin));
                                }
                                break;
                            case Basics.Damage.Gas:
                                dmgQueue.Add(t, Basics.PureDmg((physDmg + toxinDmg) / 2, Basics.Damage.Toxin));
                                for (int k = 0; k <= 8; k++)
                                {
                                    dmgQueue.Add(t + (double)k, Basics.PureDmg(toxinDmg * 1.25f, Basics.Damage.Toxin));
                                }
                                break;
                        }
                    }
                    clip--;
                    if (clip == 0)
                    {
                        clip = weapon.clip;
                        inReload = true;
                    }
                }

                heatDmg = weapon.dmg[(int)Basics.Damage.Total] / weapon.elemBonus * 0.50f;
                int indx = 0;
                while (indx < dmgQueue.Count() && dmgQueue.Keys[indx] <= t)
                {
                    double currT = dmgQueue.First().Key;
                    double[] currDmg = dmgQueue.First().Value;
                    if ((int)(currT - heatStart) != (int)(lastT - heatStart) && (lastT - heatStart <= 6.0f))
                    {
                        dmgQueue.Add(currT, Basics.PureDmg(heatDmg, Basics.Damage.Heat));
                    }
                    if ((Basics.Damage)(int)currDmg[(int)Basics.Damage.Cap] == Basics.Damage.Heat)
                    {
                        heatStart = currT;
                        dmgQueue.Add(currT, Basics.PureDmg(heatDmg, Basics.Damage.Heat));
                    }
                    lastT = currT;
                    indx++;
                }

                while (dmgQueue.Count() > 0 && dmgQueue.First().Key <= t)
                {
                    double currT = dmgQueue.First().Key;
                    double[] currDmg = dmgQueue.First().Value;
                    if ((currT - viralStart > 6.0f) && inViral)
                    {
                        inViral = false;
                        enemy.health += lostHealth;
                        enemy.shield += lostShield;
                    }
                    switch ((Basics.Damage)(int)currDmg[(int)Basics.Damage.Cap])
                    {
                        case Basics.Damage.Heat:
                            break;
                        case Basics.Damage.Corrosive:
                            enemy.armor *= 0.75f;
                            if (enemy.armor < 1)
                            {
                                enemy.armor = 0;
                                enemy.armorType = Basics.Hitpoint.None;
                            }
                            break;
                        case Basics.Damage.Viral:
                            if (!inViral)
                            {
                                enemy.health *= 0.5f;
                                enemy.shield *= 0.5f;
                                lostHealth = enemy.health;
                                lostShield = enemy.shield;
                            }
                            inViral = true;
                            viralStart = currT;
                            break;
                        default:
                            enemy = Basics.dmgApply(enemy, currDmg);
                            break;
                    }
                    dmgQueue.RemoveAt(0);
                    lastT = currT;
                }
            }
            return new Basics.Simdata(t, shots);
        }
    }
}
