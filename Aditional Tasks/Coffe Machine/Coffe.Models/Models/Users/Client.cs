using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Models.Users
{
    public class Client : User
    {
        public Client(int id, string username, decimal cash) 
            : base(id, username, cash)
        {
        }
    }
}
