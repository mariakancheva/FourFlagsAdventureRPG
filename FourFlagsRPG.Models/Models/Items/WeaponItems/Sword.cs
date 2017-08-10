namespace FourFlagsRPG.Models.Models.Items.WeaponItems
{
   public class Sword:Weapon
    {
        private const int demageBonus = 10;

        public Sword(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int demageBonus)
            : base(id, name, namePlural, minimumDamage, maximumDamage, demageBonus)
        {
            demageBonus = Sword.demageBonus;
        }
    }
}
