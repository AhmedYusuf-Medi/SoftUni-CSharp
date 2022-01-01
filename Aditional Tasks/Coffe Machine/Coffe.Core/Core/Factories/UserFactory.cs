using Coffee.Core.Core.Contracts;
using Coffee.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Core.Core.Factories
{
    class UserFactory : IUserFactory
    {
        public IUser CreateClient(string username, decimal cash)
        {
            throw new NotImplementedException();
        }

        public IUser CreateOwner(string username, decimal cash)
        {
            throw new NotImplementedException();
        }
    }
}
