using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        private string model;
        
        //private double fuelAmount;
        //private double fuelConsumptionFor1km;
        //private double distanceTraveled;


        public string Model { get { return this.model; } set { this.model = value; } }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire tire1 { get; set; }
        public Tire tire2 { get; set; }
        public Tire tire3 { get; set; }
        public Tire tire4 { get; set; }
        //public double FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
        //
        //public double FuelConsumptionFor1km { get { return this.fuelConsumptionFor1km; } set { this.fuelConsumptionFor1km = value; } }
        //
        //public double DistanceTraveled { get { return this.distanceTraveled; } set { this.distanceTraveled = value; } }

        //public override string ToString()
        //{
        //    //return string.Concat(base.ToString(), " ", EarSize);
        //    //return $"{base.ToString()} {Model}:\r\n  {ModelEn}:\r\n    Power: {Power}\r\n    Displacement: {Displacement}\r\n    Efficiency: {Efficiency}\r\n  Weight: {Weigth}\r\n  Color: {Color}";
        //
        //}
        //public bool CanMoveDistans(double distans, Car car)
        //{
        //    if (car.FuelConsumptionFor1km * distans <= car.FuelAmount)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
    public class Engine: Car
    {
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo: Car
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    public class Tire:Car
    {
        public double TirePressure { get; set; }
        public int TireAge { get; set; }
    }
    //class Engine : Car
    //{
    //    private string modelEn = "n/a";
    //    private string power = "n/a";
    //    private string displacement = "n/a";
    //    private string efficiency = "n/a";
    //
    //    public string ModelEn { get { return this.modelEn; } set { this.modelEn = value; } }
    //    public string Power { get { return this.power; } set { this.power = value; } }
    //    public string Displacement { get { return this.displacement; } set { this.displacement = value; } }
    //    public string Efficiency { get { return this.efficiency; } set { this.efficiency = value; } }
    //
    //    public override string ToString()
    //    {
    //        //return string.Concat(base.ToString(), " ", EarSize);
    //        return $"{Model}:\r\n  {ModelEn}:\r\n    Power: {Power}\r\n    Displacement: {Displacement}\r\n    Efficiency: {Efficiency}\r\n  Weight: {Weigth}\r\n  Color: {Color}";
    //
    //    }
    //    static void Print()
    //    {
    //
    //    }
    //}
}
