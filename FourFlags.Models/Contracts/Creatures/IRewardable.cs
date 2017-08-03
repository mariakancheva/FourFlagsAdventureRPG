namespace FourFlags.Models.Contracts.Creatures
{
    public interface IRewardable
    {
        int GoldReward { get; }

        int ExperianceReward { get; }
    }
}