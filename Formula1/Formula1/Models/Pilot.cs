using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private bool canRace=false;
        private IFormulaOneCar car;
        private int numberOfWins=0;
        public Pilot(string fullName)
        {
            FullName = fullName;
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidPilot, value));
                fullName = value;
            }
        }

        public IFormulaOneCar Car
        {
            get
            {
                return car;
            }
            private set
            {
                if (value==null)
                    throw new NullReferenceException(String.Format(ExceptionMessages.InvalidCarForPilot, value));
                car = value;
            }
        }

        public int NumberOfWins { get { return numberOfWins; } private set { numberOfWins++; } }

        public bool CanRace
        {
            get { return canRace; }
            private set
            {
                canRace = value;
            }
        }

        public void AddCar(IFormulaOneCar car)
        {
            Car = car;
            CanRace = true;
        }

        public void WinRace()
        {
            NumberOfWins++;
        }
        public override string ToString()
        {
            return String.Format($"Pilot {FullName} has {NumberOfWins} wins.");
        }
      
    }
}
