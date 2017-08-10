namespace FourFlagsRPG.Models.Models.Heroes
{
    using System;
    using System.Collections.Generic;
    using Contracts.Heroes;
    using Utilities;

    public abstract class Hero : IHero
    {
        private string name;
        private string description;
        private int health;
        private int gold;
        private int experience;
        private int level;
        private int damage;
        private int strength;
        private int defence;
        private int dexterity;

        //TODO: Change type to item class !
        private List<string> inventory;

        protected Hero(string name)
        {
            this.Name = name;
            this.Health = HeroConstants.DefaultHealth;
            this.Damage = HeroConstants.DefaultDamage;
            this.Strength = HeroConstants.DefaultStrength;
            this.Defence = HeroConstants.DefaultDefence;
            this.Dexterity = HeroConstants.DefaultDexterity;
            this.inventory = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.ValidateHeroName(value);

                this.name = value;
            }
        }

        public string Description
        {
            get { return this.description; }
            protected set
            {
                this.description = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            protected set
            {
                Validator.ValidateStats(value, "health", "Hero");

                this.health = value;
            }
        }

        public int Gold
        {
            get { return this.gold; }
        }

        public int Experience
        {
            get { return this.experience; }
        }

        public int Level
        {
            get { return this.level; }
        }

        public int Damage
        {
            get { return this.damage; }
            protected set
            {
                Validator.ValidateStats(value, "damage", "Hero");

                this.damage = value;
            }
        }

        public int Strength
        {
            get { return this.strength; }
            protected set
            {
                Validator.ValidateStats(value, "strength", "Hero");

                this.strength = value;
            }
        }

        public int Defence
        {
            get { return this.defence; }
            protected set
            {
                Validator.ValidateStats(value, "defence", "Hero");

                this.defence = value;
            }
        }

        public int Dexterity
        {
            get { return this.dexterity; }
            protected set
            {
                Validator.ValidateStats(value, "dexterity", "Hero");

                this.dexterity = value;
            }
        }

        public int GetAttackDamage()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
