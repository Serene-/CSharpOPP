using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Contracts;
using Formula1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private readonly FormulaOneCarRepository carRepository;
        private readonly RaceRepository raceRepository;
        private  PilotRepository pilotRepository;

        public Controller()
        {
            carRepository = new FormulaOneCarRepository();
            raceRepository = new RaceRepository();
            pilotRepository = new PilotRepository();
        }

        public string AddCarToPilot(string pilotName, string carModel)
        {
            IPilot pilot= pilotRepository.FindByName(pilotName);
            IFormulaOneCar car = carRepository.FindByName(carModel);
            if (pilot!=null && pilot.Car==null)
            {
                if(car!=null)
                {
                    
                    pilot.AddCar(car);
                    carRepository.Remove(car);
                }
                else
                {
                    throw new NullReferenceException(String.Format($"Car {carModel} does not exist."));
                }
            }
            else
            {
                throw new InvalidOperationException(String.Format($"Pilot {pilotName} does not exist or has a car."));
            }
            return String.Format($"Pilot {pilotName} will drive a {car.GetType().Name} {carModel} car.");
        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            IPilot pilot = pilotRepository.FindByName(pilotFullName);
            IRace race = raceRepository.FindByName(raceName);
            if(race==null)
            {
                throw new NullReferenceException(String.Format($"Race {raceName} does not exist."));
            }
            if(pilot==null || !pilot.CanRace || race.Pilots.Contains(pilot))

            {
                throw new InvalidOperationException(String.Format($"Can not add pilot {pilotFullName} to the race."));
            }
            race.AddPilot(pilot);
            return String.Format($"Pilot {pilotFullName} is added to the {raceName} race.");
        }

        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            IFormulaOneCar car;
            if (carRepository.FindByName(model)!=null) throw new InvalidOperationException(String.Format($"Formula one car {model} is already created."));
            if (type == "Ferrari") car = new Ferrari(model, horsepower, engineDisplacement);
            else if (type == "Williams") car = new Williams(model, horsepower, engineDisplacement);
            else throw new InvalidOperationException(String.Format($"Formula one car type {type} is not valid."));
            carRepository.Add(car);
            return String.Format($"Car {type}, model {model} is created.");
        }

        public string CreatePilot(string fullName)
        {
            IPilot pilot;
            if (pilotRepository.FindByName(fullName) != null) throw new InvalidOperationException(String.Format($"Pilot {fullName} is already created."));
            pilot = new Pilot(fullName);
            pilotRepository.Add(pilot);
            return String.Format($"Pilot {fullName} is created.");
        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            IRace race;
            if (raceRepository.FindByName(raceName) != null) throw new InvalidOperationException(String.Format($"Race {raceName} is already created."));
            race = new Race(raceName, numberOfLaps);
            raceRepository.Add(race);
            return String.Format($"Race {raceName} is created.");
        }

        public string PilotReport()
        {
            List<IPilot> pilotRep = pilotRepository.Models.OrderByDescending(x => x.NumberOfWins).ToList();
            StringBuilder sb = new StringBuilder();
            foreach(var pilot in pilotRep)
            {
                sb.AppendLine(String.Format($"Pilot {pilot.FullName} has {pilot.NumberOfWins} wins."));
            }
            return sb.ToString();
        }

        public string RaceReport()
        {
            List<IRace> races = raceRepository.Models.Where(x => x.TookPlace == true).ToList();
            StringBuilder sb = new StringBuilder();
            foreach(IRace race in races)
            {
                sb.AppendLine(race.RaceInfo());
            }
            return sb.ToString();
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.FindByName(raceName);
            if (race == null) throw new NullReferenceException(String.Format($"Race {raceName} does not exist."));
            if (race.Pilots.Count < 3) throw new InvalidOperationException(String.Format($"Race {raceName} cannot start with less than three participants."));
            if (race.TookPlace) throw new InvalidOperationException(String.Format($"Can not execute race {raceName}."));
            foreach(IPilot pilot in race.Pilots)
            {
                pilot.Car.RaceScoreCalculator(race.NumberOfLaps);
            }
            List<IPilot> pilots = race.Pilots.OrderByDescending(x => x.Car.EngineDisplacement).ToList();
            pilots[0].WinRace();
            race.TookPlace = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pilot {pilots[0].FullName} wins the {raceName} race.")
            .AppendLine($"Pilot  {pilots[1].FullName} is second in the {raceName} race.")
            .AppendLine($"Pilot  {pilots[2].FullName} is third in the {raceName} race.");
            return sb.ToString();
        }
    }
}
