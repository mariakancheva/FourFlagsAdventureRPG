using FourFlagsRPG.Models.Contracts.Items;
using FourFlagsRPG.Models.Contracts.Quests;
using FourFlagsRPG.Models.Exceptions.Quest_Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace FourFlagsRPG.Models.Models.Quests
{
    public class GatherQuest : Quest, IGatherQuest
    {
        private Dictionary<IItem, bool> itemsToFind;

        public GatherQuest(int id, string name, string description, int experienceReward, ICollection<IItem> itemsToFind, ICollection<IItem> itemRewards)
            : base(id, name, description, experienceReward, itemRewards)
        {
            this.itemsToFind = itemsToFind.ToDictionary(k => k, v => false);
        }

        public IReadOnlyList<IItem> ItemsToFind
        {
            get { return this.itemsToFind.Keys.ToList().AsReadOnly(); }
        }

        public void FoundItem(IItem item)
        {
            if (!this.itemsToFind.ContainsKey(item))
            {
                throw new InvalidItemException();
            }
            this.itemsToFind[item] = true;
        }

        public override bool Completed()
        {
            return this.itemsToFind.Values.All(v => v == true);
        }
    }
}