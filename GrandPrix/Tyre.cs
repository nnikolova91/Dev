
public abstract class Tyre
{
    
    private string name;
    private double hardness;
    private double degradation = 100;

    public double Grip { get; set; }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Hardness
    {
        get { return hardness; }
        set { hardness = value; }
    }
    public virtual double Degradation
    {
        get
        {
            if (degradation>=0)
            {
                return degradation;// - hardness;
            }
            else
            {
                throw new System.Exception();
            }
            
        }
        
        set { degradation  = value; }
    }
}
public class Ultrasoft : Tyre
{
    private string name = "Ultrasoft";
    
    //public double Grip { get; set; }

    public override double Degradation
    {
        get
        {
            if (base.Degradation-this.Grip>=30)
            {
                return base.Degradation;// - this.Grip;
            }
            else
            {
                throw new System.Exception();
            }
          
        }
        set { base.Degradation = value - this.Grip; }
    }
    public Ultrasoft(string name, double hardness, double grip)
    {
        this.Name = name;
        this.Hardness = hardness;
        
        this.Grip = grip;
    }
}

public class Hard : Tyre
{
    private string name = "Hard";
    public Hard(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        
        
    }
}
