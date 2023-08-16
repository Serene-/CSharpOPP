using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeam
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public string Name
        {
            get { return name; }
            private set {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("A name should not be empty.");
                name = value;
            }
        }

        public int Endurance
        {
            get { return endurance; }
            private set {
                if (endurance > 100 || endurance < 0)
                    throw new ArgumentNullException("Endurance should be between 0 and 100.");
                 endurance = value;
            }
        }
        public int Sprint
        {
            get { return sprint; }
            private set {
                if (sprint > 100 || sprint < 0)
                    throw new ArgumentNullException("Sprint should be between 0 and 100.");
                sprint = value; }
        }
        public int Dribble
        {
            get { return dribble; }
            private set {
                if (dribble > 100 || dribble < 0)
                    throw new ArgumentNullException("Dribble should be between 0 and 100.");
                dribble = value; }
        }
        public int Passing
        {
            get { return passing; }
            private set {
                if (passing > 100 || passing < 0)
                    throw new ArgumentNullException("Passing should be between 0 and 100.");
                passing = value; }
        }
        public int Shooting
        {
            get { return shooting; }
            private set {
                if (shooting > 100 || shooting < 0)
                    throw new ArgumentNullException("Shooting should be between 0 and 100.");
                shooting = value; }
        }
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public double SkillLevel()
        {
            return endurance + sprint + dribble + passing + shooting / 5.0;
        }
    }
}
