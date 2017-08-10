namespace FourFlagsRPG.Models.Models.Heroes
{
    using FourFlagsRPG.Models.Utilities;

    public class Barbarian : Hero
    {
        public Barbarian(string name)
            : base(name)
        {
            this.Health *= 2;
            this.Damage *= 2;
            this.Strength *= 2;
            this.Defence *= 2;
            this.Description = string.Format(HeroConstants.BarbarianDescription, this.Name);
        }
    }
}
