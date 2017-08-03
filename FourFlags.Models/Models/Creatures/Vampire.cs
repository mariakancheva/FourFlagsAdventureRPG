namespace FourFlags.Models.Models.Creatures
{
    public class Vampire : Enemy, IEnemy
    {
        public Vampire(int health, int attack, int deffence, int goldReward, int experianceReward)
            : base(health, attack, deffence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}