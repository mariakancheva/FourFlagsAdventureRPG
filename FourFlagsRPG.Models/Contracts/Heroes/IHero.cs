namespace FourFlagsRPG.Models.Contracts.Heroes
{
    using Beings;

    public interface IHero : IBeing, IAttackable
    {
        string Name { get; }

        string Description { get; }

        int Gold { get; }

        int Experience { get; }

        int Level { get; }

        int Strength { get; }

        int Dexterity { get; }
    }
}
