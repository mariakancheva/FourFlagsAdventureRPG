using System.Collections.Generic;
using FourFlagsRPG.Models.Contracts.Items;

namespace FourFlagsRPG.Models.Contracts.Quests
{
    public interface IGatherQuest : IQuest
    {
        IReadOnlyList<IItem> ItemsToFind { get; }

        void FoundItem(IItem item);
    }
}