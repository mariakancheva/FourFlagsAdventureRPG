namespace FourFlags.Models.Models.Heroes
{
    using StaticData;

    public class Barbarian : Hero
    {
        public Barbarian(string name) 
            : base(name)
        {
            this.Description = string.Format(GameDescriptions.BarbarianDescription, this.Name);
        }

        public override int Attack()
        {
            return 0;
        }
    }
}
