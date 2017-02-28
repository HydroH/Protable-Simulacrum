using System;

namespace Portable_Simulacrum
{
    public class Enemy
    {
        public double health { get; private set; }
        public Data.Hitpoint healthType { get; private set; }
        public double shield { get; private set; }
        public Data.Hitpoint shieldType { get; private set; }
        public double armor { get; private set; }
        public Data.Hitpoint armorType { get; private set; }
        public int level { get; private set; }
        public bool inViral { get; private set; } = false;
        public double viralStart { get; private set; } = -0xFF;
        public double heatStart { get; private set; } = -0xFF;
        private double lostHealth = 0, lostShield = 0;
        public Enemy(double _health, Data.Hitpoint _healthType, double _shield, Data.Hitpoint _shieldType, double _armor, Data.Hitpoint _armorType, int _level)
        {
            health = _health;
            healthType = _healthType;
            shield = _shield;
            shieldType = _shieldType;
            armor = _armor;
            armorType = _armorType;
            level = _level;
        }

        public Enemy Scale(int newLevel)
        {
            Enemy newEnemy = Clone();
            const double
                healthExp = 2.0f,
                healthCo = 0.015f,
                shieldExp = 2.0f,
                shieldCo = 0.0075f,
                armorExp = 1.75f,
                armorCo = 0.005f;

            int effLevel = newLevel - level;
            if (effLevel <= 0) return newEnemy;

            newEnemy.health *= (1 + healthCo * Math.Pow(effLevel, healthExp));
            newEnemy.shield *= (1 + shieldCo * Math.Pow(effLevel, shieldExp));
            newEnemy.armor *= (1 + armorCo * Math.Pow(effLevel, armorExp));
            return newEnemy;
        }

        public void ProcHeat(double time)
        {
            heatStart = time;
        }

        public void ProcViral(double time)
        {
            if (!inViral)
            {
                health *= 0.5f;
                shield *= 0.5f;
                lostHealth = health;
                lostShield = shield;
            }
            inViral = true;
            viralStart = time;
        }
        public void UnProcViral()
        {
            inViral = false;
            health += lostHealth;
            shield += lostShield;
        }

        public void ProcCorro()
        {
            armor *= 0.75f;
            if (armor < 1)
            {
                armor = 0;
                armorType = Data.Hitpoint.None;
            }
        }

        public void ApplyDamage(Damage damage)
        {

            double trueDamage = 0;
            double remains = 1;
            if (shield > 0)
            {
                for (int i = 0; i < (int)Data.DamageType.Cap; i++)
                {
                    if (i != (int)Data.DamageType.Toxin && i != (int)Data.DamageType.Finishing)
                    {
                        trueDamage += damage.dmgArray[i] * (1 + Data.damageMult[i, (int)shieldType]);
                    }
                }
                if (trueDamage > shield)
                {
                    shield = 0;
                    remains = 1 - shield / trueDamage;
                }
                else
                {
                    shield -= trueDamage;
                    remains = 0;
                }
            }

            trueDamage = 0;
            for (int i = 0; i < (int)Data.DamageType.Cap; i++)
            {
                if (i != (int)Data.DamageType.Toxin && i != (int)Data.DamageType.Finishing)
                {
                    trueDamage += damage.dmgArray[i] * (1 + Data.damageMult[i, (int)armorType]) * (1 + Data.damageMult[i, (int)healthType]) / (1 + (armor * (1 - Data.damageMult[i, (int)armorType]) / 300));
                }
            }
            trueDamage *= remains;
            trueDamage += damage.dmgArray[(int)Data.DamageType.Toxin] * (1 + Data.damageMult[(int)Data.DamageType.Toxin, (int)armorType]) * (1 + Data.damageMult[(int)Data.DamageType.Toxin, (int)healthType]) / (1 + (armor * (1 - Data.damageMult[(int)Data.DamageType.Toxin, (int)armorType]) / 300));
            trueDamage += damage.dmgArray[(int)Data.DamageType.Finishing] * (1 + Data.damageMult[(int)Data.DamageType.Finishing, (int)healthType]);
            health -= trueDamage;
        }

        public Enemy Clone()
        {
            return new Enemy(health, healthType, shield, shieldType, armor, armorType, level);
        }
    }
}
