using FourFlagsRPG.Models.Contracts.Items;
using System.Collections.Generic;

namespace FourFlagsRPG.Models.Contracts.Quests
{
    public interface IQuest
    {
        int ID { get; }

        string Name { get; }

        string Description { get; }

        int ExperienceReward { get; }

        IReadOnlyList<IItem> ItemRewards { get; }

        bool Completed();
    }
}