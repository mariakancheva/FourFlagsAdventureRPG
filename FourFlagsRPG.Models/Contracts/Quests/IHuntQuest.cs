using FourFlagsRPG.Models.Contracts.Enemies;
using System.Collections.Generic;

namespace FourFlagsRPG.Models.Contracts.Quests
{
    public interface IHuntQuest : IQuest
    {
        IReadOnlyList<IEnemy> Enemies { get; }

        void KilledEnemy(IEnemy enemy);
    }
}