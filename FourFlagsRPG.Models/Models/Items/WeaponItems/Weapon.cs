namespace FourFlagsRPG.Models.Models.Items
{
    using FourFlagsRPG.Models.Contracts.Items;
    public class Weapon : Item,IWeapon
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
      
        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int demageBonus) : base(id, name, namePlural)
        {
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;
            this.DemageBonus = demageBonus;
        }

        public int DemageBonus { get; }
    }
}
