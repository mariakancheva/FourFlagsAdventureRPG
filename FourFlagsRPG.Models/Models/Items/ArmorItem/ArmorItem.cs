namespace FourFlagsRPG.Models.Models.Items
{
    using FourFlagsRPG.Models.Contracts.Items;
    using FourFlagsRPG.Models.Enums;

    public class ArmorItem:Item,IArmor
    {
        private int defenceBonus;
        private ArmorType armorType;

        public ArmorItem(int id, string name, string namePlural, int defenceBonus, ArmorType armorType)
            : base(id, name, namePlural)
        {
            this.defenceBonus = defenceBonus;
            this.armorType = armorType;
        }

        public int DefenceBonus
        {
            get
            {
                return this.defenceBonus;
            }
            protected set
            {
                this.defenceBonus = value;
            }
        }

        public ArmorType ArmorType
        {
            get { return this.armorType; }
            protected set
            {
                this.armorType = value;
            }
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} defence bonus: {1}", this.GetType().Name, this.DefenceBonus);
        //}
    }
}
