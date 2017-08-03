namespace FourFlags.Models.Models.Creatures
{
    public class Orc : Enemy, IEnemy
    {
        public Orc(int health, int attack, int deffence, int goldReward, int experianceReward)
            : base(health, attack, deffence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}