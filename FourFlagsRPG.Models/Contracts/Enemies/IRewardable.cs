namespace FourFlagsRPG.Models.Contracts.Enemies
{
    public interface IRewardable
    {
        int GoldReward { get; }

        int ExperianceReward { get; }
    }
}