namespace FourFlagsRPG.Models.Models.Enemies
{
    using System;
    using System.Collections.Generic;

    using FourFlagsRPG.Models.Contracts.Enemies;
    using FourFlagsRPG.Models.Models.Items;

    public abstract class Enemy : IEnemy
    {
        private int id;
        private int health;
        private int damage;
        private int defence;
        private int goldReward;
        private int experianceReward;
      //  private List<LootItem> LootTable { get; set; }

        protected Enemy(int id, int health, int damage, int defence, int goldReward, int experianceReward)
        {
            this.Id = id;
            this.Health = health;
            this.Damage = damage;
            this.Defence = defence;
            this.GoldReward = goldReward;
            this.ExperianceReward = experianceReward;
        //    this.LootTable = new List<LootItem>();
        }

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public int Health
        {
            get { return this.health; }
            private set { this.health = value; }
        }

        public int Damage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }

        public int Defence
        {
            get { return this.defence; }
            private set { this.defence = value; }
        }

        public int GoldReward
        {
            get { return this.goldReward; }
            private set { this.goldReward = value; }
        }

        public int ExperianceReward
        {
            get { return this.experianceReward; }
            private set { this.experianceReward = value; }
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public int GetAttackDamage()
        {
            throw new NotImplementedException();
        }

        public void ModifyStats()
        {
            //TODO: Modify stats according to the enemy item!
            throw new NotImplementedException();
        }
    }
}