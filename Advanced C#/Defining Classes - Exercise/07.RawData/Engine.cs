using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public string EngineModel { get; set; }
        public double EngineSpeed { get; set; }

        public double EnginePower { get; set; }

        public Engine(string engineModel, double engineSpeed, double enginePower)
        {
            this.EngineModel = engineModel;
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
    }
}
