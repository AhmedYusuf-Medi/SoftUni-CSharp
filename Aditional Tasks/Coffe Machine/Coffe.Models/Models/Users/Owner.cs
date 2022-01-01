using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Models.Users
{
    public class Owner : User
    {
        public Owner(int id, string username, decimal cash) 
            : base(id, username, cash)
        {
        }
    }
}
