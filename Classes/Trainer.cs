using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Trainer
    {
        public int numberOfBadges = 0;

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons = new List<Pokemon>();
    }
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
    }
}
