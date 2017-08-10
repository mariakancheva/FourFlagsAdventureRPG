using FourFlags.BusinessLogic.Controllers.Quest;
using FourFlags.Models.Factories;
using FourFlagsRPG.Models.Contracts.Enemies;
using FourFlagsRPG.Models.Contracts.Items;
using FourFlagsRPG.Models.Enums;
using FourFlagsRPG.Models.Models.Items;
using System;
using System.Collections.Generic;

namespace FourFlagsRPG.Core
{
    public class StartUp
    {
        public static void Main()
        {
            QuestController questController = new QuestController(new List<IItem>() { new Item(1, "test", "testPlural") }, new List<IEnemy>() { EnemyFactory.CreateEnemy(Enemies.Vampire, 1) });

            IEnemy enemy = EnemyFactory.CreateEnemy(Enemies.BloodElf, 1);
            Console.WriteLine(enemy);

            //var barbarian = new Barbarian("Stamat");
            //var dwarf = new Dwarf("Kiro Jarta");
            //var paladin = new Paladin("Kolio Mamata");

            //Console.WriteLine();

            //var hero = HeroFactory.CreateHero(0, "Kiro");

            //Console.WriteLine();
        }
    }
}