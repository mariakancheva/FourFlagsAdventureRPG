namespace FourFlagsRPG.Models.Models.Enemies
{
    using FourFlagsRPG.Models.Contracts.Enemies;

    public class BloodElf : Enemy, IEnemy
    {
        public BloodElf(int id, int health, int damage, int defence, int goldReward, int experianceReward)
            : base(id, health, damage, defence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}