using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, 
            decimal salary,Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;   
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");

            return sb.ToString().TrimEnd();
        }
    }
}
