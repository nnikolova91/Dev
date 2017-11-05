using System.Collections.Generic;

namespace NikoletaSolution
{
    class Customer
    {
        public string Name { get; set; }
        
        public Dictionary<string, int> Pokupki { get; set; }

        public decimal Bill { get; set; }


       //public override string ToString()
       //{
       //    return $"{Name} -- {Pokupki.Keys} - {Pokupki.Values} Bill: {Bill}";
       //}
    }  //

   
}
