namespace FourFlagsRPG.Models.Models.Items
{
    using FourFlagsRPG.Models.Enums;

    public class HealthBonusPotion : Item
    {
        public HealthBonusPotion(int id, string name, string namePlural, HealthBonusPotionSize healthBonusPotionSize)
             : base(id, name, namePlural)
        {
            this.HealthBonusPotionSize = healthBonusPotionSize;
        }

        public int HealthBonus
        {
            get
            {
                return (int)this.HealthBonusPotionSize;
            }
        }

        public HealthBonusPotionSize HealthBonusPotionSize { get; set; }
    }
}
