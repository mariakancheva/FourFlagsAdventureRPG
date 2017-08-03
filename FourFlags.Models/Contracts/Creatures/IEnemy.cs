using FourFlags.Models.Contracts.Creatures;

namespace FourFlags.Models.Models.Creatures
{
    public interface IEnemy : IAttackable, IDefensible, IRewardable
    {
        int Health { get; }
    }
}