using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        public Mission(string codeName,MisionState missionState)
        {
            this.CodeName = codeName;
            this.MisionState = missionState;
        }
        public string CodeName { get; private set; }

        public MisionState MisionState { get; private set; }

        public void CompleteMision()
        {
            this.MisionState = MisionState.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.MisionState}";
        }
    }
}
