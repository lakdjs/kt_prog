using kt_interfaces;

internal class Program
{
    static void Main(string[] args)
    {
        Hero swordsMan = HeroFabric.CreateSwordHero("SwordsHero", ConsoleColor.White);
        Hero fireSwordsMan = HeroFabric.CreateFireSworHero("SwordsFireHero", ConsoleColor.Blue);
        Hero freezeSwordsMan = HeroFabric.CreateFreezeSwordHero("SwordsFreezeHero", ConsoleColor.Red);

        swordsMan.Attack(fireSwordsMan);
        fireSwordsMan.Attack(freezeSwordsMan);
        freezeSwordsMan.Attack(swordsMan);
    }
}
