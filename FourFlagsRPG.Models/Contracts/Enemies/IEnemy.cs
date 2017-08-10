namespace FourFlagsRPG.Models.Contracts.Enemies
{
    using FourFlagsRPG.Models.Contracts.Beings;

    public interface IEnemy : IBeing, IAttackable, IRewardable
    {
        int Id { get; }
    }
}