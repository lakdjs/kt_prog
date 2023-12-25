using kt_interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    internal class UseFreezing: IHavingDamage, IHavingName, ISkill
    {
        private IceColour _iceColour;
        private int _reloadingTime;
        public UseFreezing(int damage, int damageRange, Logger logger, string name, IceColour iceColour, int reloadingTime)
        {
            Damage = damage;
            DamageRange = damageRange;
            Logger = logger;
            Name = name;
            _iceColour = iceColour;
            _reloadingTime = reloadingTime;
        }
        public int Damage { get; }

        public int DamageRange { get; }

        public Logger Logger { get; }

        public string Name { get; }

        public void ActivateSkill(Hero hero, Hero enemyHero)
        {
            Logger.PrintLog($"Using Freeze. Damage{Damage}," +
               $" Radius:{DamageRange}," +
               $" ReloadTime:{_reloadingTime}," +
               $" IceColour:{_iceColour},");
            enemyHero.RecieveDamage(Damage, hero);
        }
    }
}
