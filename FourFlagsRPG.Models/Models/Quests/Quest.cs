using System;
using FourFlagsRPG.Models.Contracts.Items;
using FourFlagsRPG.Models.Contracts.Quests;
using FourFlagsRPG.Models.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace FourFlagsRPG.Models.Models.Quests
{
    public abstract class Quest : IQuest
    {
        private int id;
        private string name;
        private string description;
        private int experienceReward;
        private readonly List<IItem> itemRewards;

        public Quest(int id, string name, string description, int experienceReward, ICollection<IItem> itemRewards)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ExperienceReward = experienceReward;
            this.itemRewards = itemRewards.ToList();
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (!Validator.ValidateStringNotNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be Null or Empty");
                }
                this.name = value;
            }
        }

        public string Description
        {
            get { return this.description; }
            private set
            {
                if (!Validator.ValidateStringNotNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be Null or Empty");
                }
                this.description = value;
            }
        }

        public int ExperienceReward
        {
            get { return this.experienceReward; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be Zero or Negative");
                }
                this.experienceReward = value;
            }
        }

        public IReadOnlyList<IItem> ItemRewards
        {
            get { return this.itemRewards.AsReadOnly(); }
        }

        public abstract bool Completed();
    }
}