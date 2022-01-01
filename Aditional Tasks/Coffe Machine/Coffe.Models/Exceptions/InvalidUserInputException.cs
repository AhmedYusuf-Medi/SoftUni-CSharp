using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Exceptions
{
    public class InvalidUserInputException : ApplicationException
    {
        public InvalidUserInputException(string message)
            : base(message)
        {
        }
    }
}
