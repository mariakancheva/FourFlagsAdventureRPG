namespace FourFlags.Models.Models.Creatures
{
    public class BloodElf : Enemy, IEnemy
    {
        public BloodElf(int health, int attack, int deffence, int goldReward, int experianceReward)
            : base(health, attack, deffence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}