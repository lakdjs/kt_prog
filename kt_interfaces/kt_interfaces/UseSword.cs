using kt_interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    internal class UseSword : IHavingDamage, IHavingName, ISkill
    {
        private int _damageMultiplier; 
        public UseSword(int damage, int damageRange, Logger logger, string name, int damageMultiplier)
        {
            Damage = damage;
            DamageRange = damageRange;
            Logger = logger;
            Name = name;
            _damageMultiplier = damageMultiplier;
        }

        public int Damage { get; }

        public int DamageRange { get; }

        public Logger Logger { get; }

        public string Name { get; }

        public void ActivateSkill(Hero hero, Hero enemyHero)
        {
            int multipliedDamage = Damage * _damageMultiplier;
            Logger.PrintLog($"Using Sword. Base damage{Damage}," +
                $" OverallDamage{multipliedDamage}," +
                $" Radius:{DamageRange}," +
                $" Damage Multiplier:{_damageMultiplier}");
            enemyHero.RecieveDamage(multipliedDamage, hero);
        }
    }
}
