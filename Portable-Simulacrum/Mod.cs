﻿using System.Collections.Generic;
using System.Linq;

namespace Portable_Simulacrum
{
    public class Mod
    {
        public double[] multiplier { get; private set; }
        public Queue<Data.DamageType> elemQueue { get; private set; } = new Queue<Data.DamageType>();
        public int maxLevel { get; private set; } = 0;
        public Mod()
        {
            multiplier = new double[(int)Data.ModProp.Cap];
        }
        public Mod(double[] _multiplier, int _maxLevel = 0)
        {
            multiplier = _multiplier;
            for (int i = (int)Data.ModProp.Cold; i <= (int)Data.ModProp.Toxin; i++)
            {
                if (multiplier[i] > 0)
                {
                    elemQueue.Enqueue((Data.DamageType)(i - Data.elemDiff));
                }
            }
            maxLevel = _maxLevel;
        }
        public Mod(double[] _multiplier, Queue<Data.DamageType> _elemQueue, int _maxLevel = 0)
        {
            multiplier = _multiplier;
            elemQueue = _elemQueue;
            maxLevel = _maxLevel;
        }

        public Mod Scale(int level)
        {
            Mod newMod = Clone();
            for (int i = 0; i < multiplier.Count(); i++)
            {
                newMod.multiplier[i] *= (level + 1);
            }
            return newMod;
        }

        public void Combine(Mod mod)
        {
            for (int i = 0; i < multiplier.Count(); i++)
            {
                multiplier[i] += mod.multiplier[i];
            }
            while (mod.elemQueue.Count() > 0)
            {
                Data.DamageType temp = mod.elemQueue.Dequeue();
                if (!elemQueue.Contains(temp)) elemQueue.Enqueue(temp);
            }
        }
        public void Combine(Weapon weapon)
        {
            for (int i = (int)Data.DamageType.Cold; i <= (int)Data.DamageType.Toxin; i++)
            {
                if (weapon.damage.dmgArray[i] > 0) elemQueue.Enqueue((Data.DamageType)i);
            }
        }

        public Mod Clone()
        {
            return new Mod((double[])multiplier.Clone(), new Queue<Data.DamageType>(elemQueue), maxLevel);
        }
    }
}
