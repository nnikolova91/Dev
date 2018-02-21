using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix
{
    class AggresiveDriver : Driver
    {
        public AggresiveDriver(double speed) : base(speed)
        {
        }

        public override double Speed
        {
            get
            {
                return base.speed * 1.3;
            }
        }
    }

    class Driver
    {
        protected double speed;
        public virtual double Speed
        {
            get
            {
                return speed;
            }
        }

        public Driver(double speed)
        {
            this.speed = speed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Driver driver = new Driver(100);
            //Driver aggressive = new AggresiveDriver(100);
            //
            //List<Driver> drivers = new List<Driver>() { driver, aggressive };
            //
            //foreach (var driverr in drivers)
            //{
            //    Console.WriteLine(driverr.Speed);
            //}
            //
            //var speed = driver.Speed;
            //
            //int laps = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //
            //Cat c = new Cat(13, "penka");
            //
            //var catName = c.Name;
            int brObikolki = int.Parse(Console.ReadLine());
            int lengthTrase = int.Parse(Console.ReadLine());
            List<Drivers> drivers = new List<Drivers>();

            foreach (var d in drivers)
            {
                for (int i = 0; i < brObikolki; i++)
                {
                    d.TotalTime += 60 / (lengthTrase / d.Speed);
                    d.Car.FuelAmount -= (lengthTrase * d.FuelConsumptionPerKm);
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

        }
    }
}
