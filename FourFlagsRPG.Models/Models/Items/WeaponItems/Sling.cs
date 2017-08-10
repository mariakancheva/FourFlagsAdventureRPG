namespace FourFlagsRPG.Models.Models.Items.WeaponItems
{
    public class Sling : Weapon
    {
        public const int demageBonus = 13;

        public Sling(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int demageBonus)
            : base(id, name, namePlural, minimumDamage, maximumDamage, demageBonus)
        {
            demageBonus = Sling.demageBonus;
        }
    }
}
