namespace FourFlagsRPG.Models.Models.Enemies
{
    using FourFlagsRPG.Models.Contracts.Enemies;

    public class Orc : Enemy, IEnemy
    {
        public Orc(int id, int health, int damage, int defence, int goldReward, int experianceReward)
            : base(id, health, damage, defence, goldReward, experianceReward)
        {
            //this.ModifyStats();
        }
    }
}