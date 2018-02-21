using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var commandArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = commandArgs[0];

                Person person = people.FirstOrDefault(p => p.Name == name);

                if (person == null)
                {
                    person = new Person() { Name = name };
                    people.Add(person);
                }

                switch (commandArgs[1])
                {
                    case "company":
                        person.Company = new Company()
                        {
                            Name = commandArgs[2],
                            Department = commandArgs[3],
                            Salary = decimal.Parse(commandArgs[4])
                        };
                        break;

                    case "pokemon":
                        person.Pokemons.Add(new Pokemon() { Name = commandArgs[2], Type = commandArgs[3] });
                        break;

                    case "parents":
                        person.Parents.Add(new FamilyMember()
                        {
                            Name = commandArgs[2],
                            BirthDay = commandArgs[3]
                        });
                        break;

                    case "children":
                        person.Children.Add(new FamilyMember()
                        {
                            Name = commandArgs[2],
                            BirthDay = commandArgs[3]
                        });
                        break;

                    case "car":
                        person.Car = new Car() { Model = commandArgs[2], Speed = int.Parse(commandArgs[3]) };
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            string personName = Console.ReadLine();

            Person personToPrint = people.FirstOrDefault(p => p.Name == personName);

            if (personToPrint != null)
            {
                Console.WriteLine(personToPrint);
            }
        }
    }
}
