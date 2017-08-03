namespace FourFlags.Models.Models.Creatures
{
    public class Goblin : Enemy, IEnemy
    {
        public Goblin(int health, int attack, int deffence, int goldReward, int experianceReward)
            : base(health, attack, deffence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}