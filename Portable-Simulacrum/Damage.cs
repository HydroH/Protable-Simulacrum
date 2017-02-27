using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable_Simulacrum
{
    public class Damage
    {
        public double[] dmgArray { get; private set; }
        public double totalDmg { get; private set; }
        public Data.DamageType statType { get; private set; }
        public Damage(double[] _dmgArray, Data.DamageType _statType = Data.DamageType.Cap)
        {
            dmgArray = _dmgArray;
            totalDmg = 0;
            for (int i = 0; i < dmgArray.Count(); i++)
            {
                totalDmg += dmgArray[i];
            }
            statType = _statType;
        }
        public Damage(double dmg, Data.DamageType dmgType, bool _triggerStat = false)
        {
            dmgArray = new double[(int)Data.DamageType.Cap];
            dmgArray[(int)dmgType] = dmg;
            totalDmg = 0;
            for (int i = 0; i < dmgArray.Count(); i++)
            {
                totalDmg += dmgArray[i];
            }
            statType = _triggerStat ? dmgType : Data.DamageType.Cap;
        }

        public Damage Scale(double scaleMult)
        {
            double[] newDmgArray = (double[])dmgArray.Clone();
            for (int i = 0; i < newDmgArray.Count(); i++)
            {
                newDmgArray[i] *= scaleMult;
            }
            return new Damage(newDmgArray);
        }

        public void Modify(Mod mod)
        {
            for (int i = 0; i < dmgArray.Count(); i++)
            {
                dmgArray[i] *= (1 + mod.multiplier[(int)Data.ModProp.Base]);
            }
            dmgArray[(int)Data.DamageType.Impact] *= (1 + mod.multiplier[(int)Data.ModProp.Impact]);
            dmgArray[(int)Data.DamageType.Puncture] *= (1 + mod.multiplier[(int)Data.ModProp.Puncture]);
            dmgArray[(int)Data.DamageType.Slash] *= (1 + mod.multiplier[(int)Data.ModProp.Slash]);
            totalDmg = 0;
            for (int i = 0; i < dmgArray.Count(); i++)
            {
                totalDmg += dmgArray[i];
            }
            Data.DamageType elemA = Data.DamageType.Cap, elemB;
            while (mod.elemQueue.Count() > 0)
            {
                elemB = mod.elemQueue.Dequeue();
                if (elemA == Data.DamageType.Cap)
                {
                    elemA = elemB;
                }
                else
                {
                    dmgArray[(int)Data.damageCombine[(int)elemA, (int)elemB]] += totalDmg * (mod.multiplier[(int)elemA + Data.elemDiff] + mod.multiplier[(int)elemB + Data.elemDiff]);
                    elemA = Data.DamageType.Cap;
                }
            }
            if (elemA != Data.DamageType.Cap)
            {
                dmgArray[(int)elemA] += totalDmg * (mod.multiplier[(int)elemA + Data.elemDiff]);
            }

            totalDmg = 0;
            for (int i = 0; i < dmgArray.Count(); i++)
            {
                totalDmg += dmgArray[i];
            }
        }

        public Damage StatDamage()
        {
            double[] newDmgArray = (double[])dmgArray.Clone();
            for (int i = 0; i < 3; i++)
            {
                newDmgArray[i] *= 4;
            }
            return new Damage(newDmgArray);
        }

        public Damage StatTrigger(Data.DamageType statType)
        {
            double[] newDmgArray = (double[])dmgArray.Clone();
            return new Damage(newDmgArray, statType);
        }

        public double BaseDamage(Mod mod)
        {
            return totalDmg * (1 + mod.multiplier[(int)Data.ModProp.Base]);
        }
        public double ToxinDamage(Mod mod)
        {
            return dmgArray[(int)Data.DamageType.Toxin] + totalDmg * mod.multiplier[(int)Data.ModProp.Toxin];
        }
        public double PhysDamage()
        {
            return dmgArray[(int)Data.DamageType.Impact] + dmgArray[(int)Data.DamageType.Puncture] + dmgArray[(int)Data.DamageType.Slash];
        }

        public Damage Clone()
        {
            return new Damage((double[])dmgArray.Clone(), statType);
        }
    }
}
