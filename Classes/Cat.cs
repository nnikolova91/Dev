namespace Classes
{
    public abstract class Cat
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{Breed} {Name}";
        }
    }
    public class Siamese : Cat
    {
        public int EarSize { get; set; }

        public override string ToString()
        {
            //return string.Concat(base.ToString(), " ", EarSize);
            return $"{base.ToString()} {EarSize}";
        }
    }

    public class Cymirc : Cat
    {
        public double FurLenth { get; set; }

        public override string ToString()
        {
            return string.Concat(base.ToString(), " ", $"{FurLenth:F2}");
        }
    }

    public class StreetExtraordinaire : Cat
    {
        public int DecibelsOfMewous { get; set; }

        public override string ToString()
        {
            return string.Concat(base.ToString(), " ", DecibelsOfMewous);
        }
    }

}
