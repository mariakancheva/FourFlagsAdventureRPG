namespace FourFlagsRPG.Models.Models.Items.WeaponItems
{
   public class Axe:Weapon
    {
        public const int demageBonus = 15;

        public Axe(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int demageBonus)
            : base(id, name, namePlural, minimumDamage, maximumDamage, demageBonus)
        {
            demageBonus = Axe.demageBonus;
        }
    }
}
