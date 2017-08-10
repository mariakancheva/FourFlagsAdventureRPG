namespace FourFlagsRPG.Models.Models.Player
{
    using System;
    using System.Linq;
    using FourFlagsRPG.Models.Contracts.Items;
    using FourFlagsRPG.Models.Models.Items;

   public class Player
    {
        private int health;
        private int damage;
        private string name;
        private int defensiveBonus;
        private IInventory inventory;


        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whitespace.");
                }

                this.name = value;
            }
        }

        public int DefensiveBonus
        {
            get { return this.defensiveBonus; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player defensive bonus.", "Defensive bonus value cannot be negative.");
                }
                this.defensiveBonus = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Character damage", "Damage value cannot be negative.");
                }
                this.damage = value;
            }
        }

        public IInventory Inventory
        {
            get
            {
                return this.inventory;
            }

            private set
            {
                this.inventory = value;
            }
        }

        public void SelfHeal()
        {
            ISlot healthPotionSlot = this.Inventory
                .BackPack
                .SlotList
                .FirstOrDefault(x => x.GameItem is HealthPotion);

            if (healthPotionSlot == null)
            {
                throw new ArgumentException("There are no health potions left in the backpack.");
            }

            int maximumHealthRestore = this.Health;
            this.Health += (healthPotionSlot.GameItem as HealthPotion).HealthRestore;
            Console.WriteLine("You restored {0} health points using Health Potion!",
                (healthPotionSlot.GameItem as HealthPotion).HealthRestore);
            if (this.Health > maximumHealthRestore) //Healing potions only restore health to the player's current Health value.
            {
                this.Health = maximumHealthRestore;
            }
            this.Inventory.BackPack.RemoveItem(healthPotionSlot);
        }

        public void DrinkHealthBonusPotion()
        {
            ISlot healthBonusPotionSlot = this.Inventory
                .BackPack
                .SlotList
                .FirstOrDefault(x => x.GameItem is HealthBonusPotion);

            if (healthBonusPotionSlot == null)
            {
                throw new ArgumentException("There are no health bonus potions left in the backpack.");
            }
            this.Health += (healthBonusPotionSlot.GameItem as HealthBonusPotion).HealthBonus;
            Console.WriteLine("You boosted your health with {0} points using Health Bonus Potion!",
                (healthBonusPotionSlot.GameItem as HealthBonusPotion).HealthBonus);
            this.Health += (healthBonusPotionSlot.GameItem as HealthBonusPotion).HealthBonus;
            this.Inventory.BackPack.RemoveItem(healthBonusPotionSlot);
        }
        public void Attack(ICharacter enemy)
        {
            enemy.Health -= this.Damage;
            if (enemy is IPlayer)
            {
                enemy.Health += (enemy as IPlayer).DefensiveBonus;
            }
        }
    }
}
