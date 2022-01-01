using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Messages
{
    public static class ExceptionMessages
    { 
        //Properties
        public const string InvalidStringPropertyMessage = "----> Invalid {0}, it cannot be null, empty or white space!";
        public const string IntegerCannotBeZeroOrNegativeMessage = "----> {0} cannot be zero or negative.";
        public const string NameProperty = "Name";
        public const string PriceProperty = "Price";
        public const string QuantityProperty = "Quantity";
        public const string UsernameProperty = "Username";
        public const string CashProperty = "Cash";
    }
}
