
public class Car
{
    private int hp;
    private double fuelAmount;
    private Tyre tyre;


    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    public double FuelAmount
    {
        get
        {
            if (this.fuelAmount>160)
            {
                fuelAmount = 160;
            }
            
            return fuelAmount;
        }
        set
        {
            if (this.fuelAmount < 0)
            {
                throw new System.Exception();
            }
            fuelAmount = value;
        }
    }
    public Tyre Tyre
    {
        get { return tyre; }
        set { tyre = value; }
    }
    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }
}
