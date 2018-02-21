using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class RaceTower
    {

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {

        }
        public void RegisterDriver(List<string> commandArgs)
        {
            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string typeTyre = commandArgs[4];
            double tyreHardnes = double.Parse(commandArgs[5]);
            double grip = 0;

             
            if (typeTyre == "Ultrasoft")
            {
                grip = double.Parse(commandArgs[6]);

                Tyre tyre = new Ultrasoft("Ultrasoft", tyreHardnes, grip);
                InitializeCarEntDriver(type, name, hp, fuelAmount, tyre);
            }
            else if (typeTyre == "Hard")
            {
                Tyre tyre = new Hard("Ultrasoft", tyreHardnes);
                InitializeCarEntDriver(type, name, hp, fuelAmount, tyre);
            }
            
        }

        private static Drivers InitializeCarEntDriver(string type, string name, int hp, double fuelAmount, Tyre tyre)
        {
            Car car = new Car(hp, fuelAmount, tyre);
            if (type == "Aggressive")
            {
                Drivers driver = new AggressivDriver(name, car);
                return driver;
            }
            else if (type == "Endurance")
            {
                Drivers driver = new EnduranceDriver(name, car);
                return driver;
            }
            
                throw new Exception();
            
           
        }

        public void DriverBoxes()
        {

        }
        public string CompleteLaps(int lengthTrace, List<Drivers> drivers,int broiObikolki)
        {
            
            for (int i = 0; i < broiObikolki; i++)
            {
                foreach (var d in drivers)
                {
                    d.TotalTime += 60 / (lengthTrace / d.Speed);
                    d.Car.FuelAmount -= (lengthTrace * d.FuelConsumptionPerKm);
                    if (d.Car.Tyre.Name == "Ultrasoft")
                    {
                        d.Car.Tyre.Degradation -= (d.Car.Tyre.Hardness + d.Car.Tyre.Grip);
                    }
                    else if (d.Car.Tyre.Name == "Hard")
                    {
                        d.Car.Tyre.Degradation -= (d.Car.Tyre.Hardness);
                    }
                }
            }
            
            return "";
        }
        public string GetLeaderboard()
        {
            return "";
        }
        public void ChangeWeather()
        {

        }
    }

