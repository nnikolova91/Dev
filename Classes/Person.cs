using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Family: Person
    {
        private List<Person> hora;
        public List<Person> Hora { get {return this.hora; }  set {this.hora =value; } }

        public void AddMember(Person pers, List<Person> hora)
        {
            hora.Add(pers);
            
        }
        public Person GetOldestPerson()
        {
            Person nGP = new Person();
            int maxGodini = 0;
            foreach (var p in Hora)
            {
                if (p.Age>maxGodini)
                {
                    nGP.Age = p.Age;
                    nGP.Name = p.Name;
                    maxGodini = p.Age;
                }
            }

            return nGP;

        }

    }
}
