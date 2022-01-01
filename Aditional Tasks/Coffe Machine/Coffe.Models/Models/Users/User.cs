using Coffee.Models.Constants.Messages;
using Coffee.Models.Contracts;
using Coffee.Models.Errors;
using Coffee.Models.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee.Models.Models.Users
{
    public abstract class User : IUser
    {
        private string username;
        private decimal cash;
        public User(int id, string username, decimal cash)
        {
            this.Id = id;
            this.Username = username;
            this.Cash = cash;
        }

        public string Username
        {
            get => this.username;
            set
            {
                Validator.CheckValueString(value, ExceptionMessages.UsernameProperty);

                this.username = value;
            }
        }

        public decimal Cash
        {
            get => this.cash;
            set
            {
                Validator.CheckIsNegativeOrZero(value, ExceptionMessages.CashProperty);
                this.cash = value;
            }
        }
        public int Id { get; private set; }

        public override string ToString()
        {
            return String.Format(MethodAndCommandMessages.UserToString,this.GetType().Name,this.Username,this.Cash);
        }
    }
}
