namespace FourFlags.Models.Models.Creatures
{
    public abstract class Enemy : IEnemy
    {
        private int health;
        private int attack;
        private int deffence;
        private int goldReward;
        private int experianceReward;

        protected Enemy(int health, int attack, int deffence, int goldReward, int experianceReward)
        {
            this.Health = health;
            this.Attack = attack;
            this.Deffence = deffence;
            this.GoldReward = goldReward;
            this.ExperianceReward = experianceReward;
        }

        public int Health
        {
            get { return this.health; }
            private set { this.health = value; }
        }

        public int Attack
        {
            get { return this.attack; }
            private set { this.attack = value; }
        }

        public int Deffence
        {
            get { return this.deffence; }
            private set { this.deffence = value; }
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
    }
}