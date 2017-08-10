namespace FourFlagsRPG.Models.Utilities
{
    using System;

    public static class Validator
    {
        public static void ValidateHeroName(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Your hero name must be non empty!");
            }

            if (name.Length > 20)
            {
                throw new ArgumentException("Your hero name length must be between 1 and 20 symbols!");
            }
        }

        public static void ValidateStats(int statValue, string statName, string unitType)
        {
            if (statValue < 0)
            {
                throw new ArgumentException($"{unitType} {statName} cannot be negative!");
            }
        }

        public static bool ValidateStringNotNullOrEmpty(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return false;
            }
            return true;
        }
    }
}