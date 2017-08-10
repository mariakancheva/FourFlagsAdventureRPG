namespace FourFlagsRPG.Models.Models.Items
{
    using FourFlagsRPG.Models.Contracts.Items;
    using FourFlagsRPG.Models.Enums;

    public class Item:IItem
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string NamePlural { get; set; }

        private ItemState ItemState { get; set; }

        public Item(int id, string name, string namePlural)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
            this.ItemState = ItemState.Available;
        }
    }
}
