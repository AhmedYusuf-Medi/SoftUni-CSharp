using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Contracts
{
    public interface IUser : IHasId
    {
        string Username { get; }

        decimal Cash { get; }
    }
}
