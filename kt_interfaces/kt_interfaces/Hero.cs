using kt_interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    public class Hero : IHavingName
    {
        private List<ISkill> _skills;
        private Logger _logger;
        private string _name;
        public Hero(string name, List<ISkill> skills, Logger logger)
        {
            _name = name;
            _skills = skills;
            _logger = logger;
        }

        public string Name => _name;

        public void Attack(Hero enemyHero)
        {
            _logger.PrintLog($"{Name} attacks {enemyHero.Name}");
            foreach (var skill in _skills)
            {
                skill.ActivateSkill(this,enemyHero);
            }
        }
        public void RecieveDamage(int damage, Hero enemyHero)
        {
            _logger.PrintLog($"{Name} recieved {damage} damage from {enemyHero.Name}");
        }
    }
}
