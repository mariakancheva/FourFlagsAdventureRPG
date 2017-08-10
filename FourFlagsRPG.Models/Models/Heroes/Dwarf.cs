namespace FourFlagsRPG.Models.Models.Heroes
{
    using Utilities;

    public class Dwarf : Hero
    {
        public Dwarf(string name) 
            : base(name)
        {
            this.Health *= 2;
            this.Dexterity *= 3;
            this.Damage += 3;
            this.Defence += 3;
            this.Description = string.Format(HeroConstants.DwarfDescription,this.Name);
        }
    }
}
