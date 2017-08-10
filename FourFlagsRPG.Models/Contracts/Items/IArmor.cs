namespace FourFlagsRPG.Models.Contracts.Items
{
    using FourFlagsRPG.Models.Enums;

    public interface IArmor
    {
        int DefenceBonus { get; }
        ArmorType ArmorType { get; }
    }
}
