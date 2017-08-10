namespace FourFlagsRPG.Models.Contracts.Items
{
    public interface IPlayer
    {
        string Name { get; }

       // IRace Race { get; }

        int DefensiveBonus { get; }

        IGameEngine Engine { get; set; }

        void SelfHeal();

        void DrinkHealthBonusPotion();
    }
}
