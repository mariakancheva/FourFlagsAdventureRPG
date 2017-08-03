using FourFlags.Models.Models.Creatures;
using FourFlags.Models.Utilities;
using System;
using System.Linq;
using System.Reflection;

namespace FourFlags.Models.Factories
{
    public static class EnemyFactory
    {
        public static IEnemy CreateEnemy(string enemyType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.DefinedTypes.FirstOrDefault(t => t.Name == enemyType);

            object[] typeParameters = new object[]
            {
                Constants.EnemyHealth,
                Constants.EnemyAttack,
                Constants.EnemyDeffence,
                Constants.EnemyGoldReward,
                Constants.EnemyExperianceReward
            };

            return (IEnemy)Activator.CreateInstance(type, typeParameters);
        }
    }
}