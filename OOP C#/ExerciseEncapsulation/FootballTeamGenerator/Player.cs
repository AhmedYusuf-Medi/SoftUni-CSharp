using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private int MinStat = 0;
        private int MaxStat = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name,int endurance,int sprint,int dribble,int passing,
            int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }
        public string Name
        {
             get => this.name;
           private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        private int Endurance
        {
            get => this.endurance;
            set
            {
                if (value < MinStat || value > MaxStat)
                {
                    throw new ArgumentException($"{nameof(this.Endurance)} should be between {MinStat} and {MaxStat}.");
                }

                this.endurance = value;
            }
        }

        private int Sprint
        {
            get => this.sprint;
            set
            {
                if (value < MinStat || value > MaxStat)
                {
                    throw new ArgumentException($"{nameof(this.Sprint)} should be between {MinStat} and {MaxStat}.");
                }

                this.sprint = value;
            }
        }

        private int Dribble
        {
            get => this.dribble;
            set
            {
                if (value < MinStat || value > MaxStat)
                {
                    throw new ArgumentException($"{nameof(this.Dribble)} should be between {MinStat} and {MaxStat}.");
                }
                this.dribble = value;
            }
        }

        private int Passing
        {
            get => this.passing;

            set
            {
                if (value < MinStat || value > MaxStat)
                {
                    throw new ArgumentException($"{nameof(this.Passing)} should be between {MinStat} and {MaxStat}.");
                }
                this.passing = value;
            }
        }

        private int Shooting
        {
            get => this.shooting;
            set
            {
                if (value < MinStat || value > MaxStat)
                {
                    throw new ArgumentException($"{nameof(this.Shooting)} should be between {MinStat} and {MaxStat}.");
                }
                this.shooting = value;
            }
        }
        public double Rating
        {
           get =>  Math.Round((this.Endurance +
                this.Sprint + this.Dribble + this.Passing
                + this.Shooting) / 5.0);
        }
    }
}
