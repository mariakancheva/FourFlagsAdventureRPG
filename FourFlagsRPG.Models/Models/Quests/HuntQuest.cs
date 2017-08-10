using FourFlagsRPG.Models.Contracts.Enemies;
using FourFlagsRPG.Models.Contracts.Items;
using FourFlagsRPG.Models.Contracts.Quests;
using FourFlagsRPG.Models.Exceptions.Quest_Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace FourFlagsRPG.Models.Models.Quests
{
    public class HuntQuest : Quest, IHuntQuest
    {
        private Dictionary<IEnemy, bool> enemies;

        public HuntQuest(int id, string name, string description, int experienceReward, ICollection<IEnemy> enemies, ICollection<IItem> itemRewards)
            : base(id, name, description, experienceReward, itemRewards)
        {
            this.enemies = enemies.ToDictionary(k => k, v => false);
        }

        public IReadOnlyList<IEnemy> Enemies
        {
            get { return this.enemies.Keys.ToList().AsReadOnly(); }
        }

        public void KilledEnemy(IEnemy enemy)
        {
            if (this.Enemies.All(e => e != enemy))
            {
                throw new InvalidEnemyException();
            }
            this.enemies[enemy] = true;
        }

        public override bool Completed()
        {
            return this.enemies.Values.All(v => v == true);
        }
    }
}