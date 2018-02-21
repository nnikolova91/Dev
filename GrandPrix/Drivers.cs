using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class Cat
//{
//    public int Test { get; set; }
//    
//    private int age;
//    public int Age
//    {
//        get
//        {
//            return age;
//        }
//
//        set
//        {
//            if (value <= 0)
//            {
//                throw new ArgumentException("godinite trqbva da sa polojitelno chislo");
//            }
//
//            age = value;
//        }
//    }
//
//    private string name;
//    public string Name
//    {
//        get
//        {
//            return name;
//        }
//    }
//
//    public Cat(int age, string name)
//    {
//        this.age = age;
//        this.name = name;
//    }
//
//    public Cat()
//    {
//        age = 25;
//        name = "gosho";
//    }
//}


public abstract class Drivers
{
    
    protected string name;
    protected double totalTime;    
    public Car Car { get; set; }
    


    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double TotalTime
    {
        get { return totalTime; }
        set { totalTime = value; }
    }
    public abstract double FuelConsumptionPerKm { get; }
    
    public virtual double Speed
    {
        get
        {
            return (this.Car.Hp +this.Car.Tyre.Degradation) / Car.FuelAmount;
        }
        
    }
    
}
public class AggressivDriver :Drivers
{
    private string Name = "Aggressiv";

    public override double FuelConsumptionPerKm
    {
        get { return 2.7; }         
    }
    public override double Speed => base.Speed * 1.3;
    public AggressivDriver(string name, Car car)
    {
        this.Name = name;
        
        this.Car = car;
    }

}
public class EnduranceDriver : Drivers
{
    public override double FuelConsumptionPerKm
    {
        get { return 1.5; }
    }
    public EnduranceDriver(string name, Car car)
    {
        this.Name = name;
        
        this.Car = car;
    }
}
