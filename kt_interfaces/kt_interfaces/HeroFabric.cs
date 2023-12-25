using kt_interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_interfaces
{
    public static class HeroFabric
    {
        public static Hero CreateSwordHero(string name, ConsoleColor logTextColor)
        {
            Logger logger = new Logger(logTextColor);
            List<ISkill> abilities = new List<ISkill>()
        {
            new UseSword(10,1, logger, "Sword", 2)
        };

            return new Hero(name, abilities, logger);
        }

        public static Hero CreateFireSworHero(string name, ConsoleColor logTextColor)
        {
            Logger logger = new Logger(logTextColor);
            List<ISkill> abilities = new List<ISkill>()
        {
            new UseSword(10,1, logger, "Sword", 3),
            new UseFire(30,4,logger,"Fire",5)
        };

            return new Hero(name, abilities, logger);
        }

        public static Hero CreateFreezeSwordHero(string name, ConsoleColor logTextColor)
        {
            Logger logger = new Logger(logTextColor);
            List<ISkill> abilities = new List<ISkill>()
        {
           new UseSword(10,1, logger, "Sword", 4),
            new UseFreezing(20,2,logger,"Freeze",IceColour.blue, 2)
        };

            return new Hero(name, abilities, logger);
        }


    }
}
