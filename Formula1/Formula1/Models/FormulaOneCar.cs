using Formula1.Core;
using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public abstract class FormulaOneCar : IFormulaOneCar
    {
        private string model;
        private int horsePower;
        private double engineDisp;
        public FormulaOneCar(string model, int horsePower, double engineDisplacement)
        {
            Model = model;
            Horsepower = horsePower;
            EngineDisplacement = engineDisplacement;
        }
        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length<3)
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1CarModel,value));
                model = value;
            }
        }

        public int Horsepower
        {
            get
            {
                return horsePower;
            }
           private set
            {
                if (value>1050 || value<900)
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1HorsePower, value));
                horsePower = value;
            }
        }

        public double EngineDisplacement
        {
            get
            {
                return engineDisp;
            }
            private set
            {
                if (value > 2 || value < 1.6)
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidF1EngineDisplacement, value));
                engineDisp = value;
            }
        }

        public double RaceScoreCalculator(int laps)
        {
            return EngineDisplacement / Horsepower * laps;
        }
    }
}
