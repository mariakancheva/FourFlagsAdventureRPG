using System;

namespace FourFlagsRPG.Models.Exceptions.Quest_Exceptions
{
    public class InvalidItemException : Exception
    {
        private const string defaultMessage = "The Item does not exist in the current Quest.";

        public InvalidItemException()
            : this(defaultMessage)
        {
        }

        public InvalidItemException(string message)
            : base(message)
        {
        }
    }
}