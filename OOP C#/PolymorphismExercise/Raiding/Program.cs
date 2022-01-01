using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, BaseHero> heroes = new Dictionary<string, BaseHero>();

            ReadAndAddHero(n, heroes);

            OutputHeroes(heroes);

            DoesHeroesWinOrLose(heroes);

        }

        private static void DoesHeroesWinOrLose(Dictionary<string, BaseHero> heroes)
        {
            int heroesDamage = heroes.Sum(h => h.Value.Power);

            int bossHealthBar = int.Parse(Console.ReadLine());

            if (heroesDamage >= bossHealthBar)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static void OutputHeroes(Dictionary<string, BaseHero> heroes)
        {
            foreach (var hero in heroes.Values)
            {
                string heroName = hero.GetType().Name;
                if (heroName == nameof(Paladin) || heroName == nameof(Druid))
                {
                    Console.WriteLine(hero.CastAbilityForHealer());
                }
                else
                {
                    Console.WriteLine(hero.CastAbilityForFighters());
                }
            }
        }

        private static void ReadAndAddHero(int n, Dictionary<string, BaseHero> heroes)
        {
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                switch (type)
                {
                    case nameof(Druid):
                        BaseHero druid = new Druid(name);
                        heroes[name] = druid;
                        break;
                    case nameof(Paladin):
                        BaseHero paladin = new Paladin(name);
                        heroes[name] = paladin;
                        break;
                    case nameof(Warrior):
                        BaseHero warrior = new Warrior(name);
                        heroes[name] = warrior;
                        break;
                    case nameof(Rogue):
                        BaseHero rogue = new Rogue(name);
                        heroes[name] = rogue;
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }
            }
        }
    }
}
