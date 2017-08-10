namespace FourFlags.Models.Factories
{
    using FourFlagsRPG.Models.Contracts.Enemies;
    using FourFlagsRPG.Models.Enums;
    using FourFlagsRPG.Models.Utilities;
    using System;
    using System.Linq;
    using System.Reflection;

    public static class EnemyFactory
    {
        public static IEnemy CreateEnemy(Enemies enemyType, int enemyId)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.DefinedTypes.FirstOrDefault(t => t.Name == enemyType.ToString());

            object[] typeParameters = new object[]
            {
                enemyId,
                EnemyConstants.EnemyHealth,
                EnemyConstants.EnemyDamage,
                EnemyConstants.EnemyDefence,
                EnemyConstants.EnemyGoldReward,
                EnemyConstants.EnemyExperianceReward
            };

            return (IEnemy)Activator.CreateInstance(type, typeParameters);
        }
    }
}