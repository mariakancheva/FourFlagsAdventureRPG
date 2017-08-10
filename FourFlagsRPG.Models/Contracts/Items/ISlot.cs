namespace FourFlagsRPG.Models.Contracts.Items
{
    public interface ISlot
    {
        IGameItem GameItem { get; set; }

        bool IsEmpty { get; set; }

        void ClearSlot();
    }
}
