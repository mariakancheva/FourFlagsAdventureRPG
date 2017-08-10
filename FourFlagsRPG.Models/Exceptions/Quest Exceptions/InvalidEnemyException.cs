using System;

namespace FourFlagsRPG.Models.Exceptions.Quest_Exceptions
{
    public class InvalidEnemyException : Exception
    {
        private const string defaultMessage = "The Enemy does not exist in the current Quest.";

        public InvalidEnemyException()
            : this(defaultMessage)
        {
        }

        public InvalidEnemyException(string message)
            : base(message)
        {
        }
    }
}