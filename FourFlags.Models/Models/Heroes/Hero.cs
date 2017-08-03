namespace FourFlags.Models.Models.Heroes
{
    using Contracts.Heroes;
    using System;
    using System.Collections.Generic;

    public abstract class Hero : IAtackable
    {
        private const int DefaultHealth = 100;

        private const int DefaultGold = 50;

        private const int DefaultMinDamage = 5;

        private const int DefaultMaxDamage = 10;

        private const int DefaultStrength = 5;

        private const int DefaultDefence = 5;

        private const int DefaultDexterity = 5;

        private string name;

        private string description;

        private int health;

        private int gold;

        private int experience;

        private int minDamage;

        private int maxDamage;

        private int strength;

        private int defence;

        private int dexterity;

        //TODO: Change type to item class !
        private List<string> inventory;

        //TODO: Hero default stats can be in enumeration!
        protected Hero(string name)
        {
            this.Name = name;
            this.health = DefaultHealth;
            this.minDamage = DefaultMinDamage;
            this.maxDamage = DefaultMaxDamage;
            this.strength = DefaultStrength;
            this.defence = DefaultDefence;
            this.dexterity = DefaultDexterity;
            this.inventory = new List<string>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Your hero name must be non empty!");
                }

                if (value.Length > 20)
                {
                    throw new ArgumentException("Your hero name length must be between 1 and 20 symbols!");
                }

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
        }

        public int Gold
        {
            get { return this.gold; }
        }

        public int Experience
        {
            get { return this.experience; }
        }

        public int MinDamage
        {
            get { return this.minDamage; }
            protected set
            {
                this.minDamage = value;
            }
        }

        public int MaxDamage
        {
            get { return this.maxDamage; }
            protected set
            {
                this.maxDamage = value;
            }
        }

        public int Strength
        {
            get { return this.strength; }
            protected set
            {
                this.strength = value;
            }
        }

        public int Defence
        {
            get { return this.defence; }
            protected set
            {
                this.defence = value;
            }
        }

        public int Dexterity
        {
            get { return this.dexterity; }
            protected set
            {
                this.dexterity = value;
            }
        }

        public abstract int Attack();
    }
}
