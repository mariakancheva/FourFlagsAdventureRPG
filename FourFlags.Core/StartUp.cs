using FourFlags.Models.Factories;
using FourFlags.Models.Models.Creatures;
using FourFlags.Models.Utilities;

namespace FourFlags.Core
{
    public class StartUp
    {
        public static void Main()
        {
            IEnemy enemy = EnemyFactory.CreateEnemy(Constants.Orc);
            System.Console.WriteLine(enemy);
        }
    }
}