using FourFlagsRPG.Models.Utilities;

namespace FourFlagsRPG.Models.Models.Heroes
{
    public class Paladin : Hero
    {
        public Paladin(string name) 
            : base(name)
        {
            this.Health += this.Health / 2;
            this.Strength *=2;
            this.Damage += 2;
            this.Dexterity += 4;
            this.Defence += 2;
            this.Description = string.Format(HeroConstants.PaladinDescription,this.Name);
        }
    }
}
