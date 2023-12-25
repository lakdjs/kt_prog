using kt_interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    internal class UseFire : IHavingDamage, IHavingName, ISkill
    {
        private int _fireTime;
        public UseFire(int damage, int damageRange, Logger logger, string name, int fireTime)
        {
            Damage = damage;
            DamageRange = damageRange;
            Logger = logger;
            Name = name;
            _fireTime = fireTime;
        }
        public int Damage { get; }

        public int DamageRange { get; }

        public Logger Logger { get; }

        public string Name { get; }

        public void ActivateSkill(Hero hero, Hero enemyHero)
        {
            Logger.PrintLog($"Using Fire. Damage{Damage}," +
                $" Radius:{DamageRange}," +
                $" Fire Time:{_fireTime}");
        
                enemyHero.RecieveDamage(Damage, hero);
        }
    }
}
