namespace FourFlagsRPG.Models.Contracts.Beings
{
    public interface IBeing
    {
        int Damage { get; }

        int Defence { get; }

        int Health { get; }
    }
}