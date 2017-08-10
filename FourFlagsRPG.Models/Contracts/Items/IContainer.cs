namespace FourFlagsRPG.Models.Contracts.Items
{
    using System.Collections.Generic;

    public interface IContainer
    {
        IEnumerable<ISlot> SlotList { get; }

        void LootItem(IGameItem itemTOBeLooted);

        void RemoveItem(ISlot slot);

        void ListItems();
    }
}
