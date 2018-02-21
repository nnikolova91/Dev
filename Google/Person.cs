using System.Collections.Generic;

namespace Google
{
    public class Person
    {
        private List<Pokemon> pokemons;
        private List<FamilyMember> parents;
        private List<FamilyMember> children;

        public List<Pokemon> Pokemons { get { return pokemons; } }
        public List<FamilyMember> Parents { get { return parents; } }
        public List<FamilyMember> Children { get { return children; } }

        public string Name { get; set; }
        public Company Company { get; set; }
        public Car Car { get; set; }

        public Person()
        {
            pokemons = new List<Pokemon>();
            parents = new List<FamilyMember>();
            children = new List<FamilyMember>();
        }

        public override string ToString()
        {
            return $"{Name}\r\nCompany:\r\n{Company}Car:\r\n{Car}Pokemon:\r\n{string.Join(string.Empty, Pokemons)}Parents:\r\n{string.Join(string.Empty, Parents)}Children:\r\n{string.Join(string.Empty, Children)}";
        }
    }

    public class Company
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} {Department} {Salary:F2}\r\n";
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Name} {Type}\r\n";
        }
    }

    public class FamilyMember
    {
        public string Name { get; set; }
        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"{Name} {BirthDay}\r\n";
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public override string ToString()
        {
            return $"{Model} {Speed}\r\n";
        }
    }
}
