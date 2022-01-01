using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Exceptions
{
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(string message)
            :base(message)
        {
        }
    }
}
