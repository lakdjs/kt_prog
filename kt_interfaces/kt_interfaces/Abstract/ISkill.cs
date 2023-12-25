using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces.Abstract
{
    public interface ISkill
    {
        Logger Logger { get; }
        public void ActivateSkill(Hero hero, Hero enemyHero);
    }
}
