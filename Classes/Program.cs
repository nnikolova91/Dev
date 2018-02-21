using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string name = "No name";
        public int age = 1;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }

    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Trainer> treniori = new List<Trainer>();
            Dictionary<string, List<Pokemon>> dic = new Dictionary<string, List<Pokemon>>();
            do
            {
                var vh = Console.ReadLine();
                if (vh == "Tournament")
                {
                    break;
                }
                var vhod = vh.Split(' ').ToArray();


                Pokemon pokemon = new Pokemon()
                {
                    Name = vhod[1],
                    Element = vhod[2],
                    Health = int.Parse(vhod[3])
                };
                if (!dic.ContainsKey(vhod[0]))
                {
                    dic.Add(vhod[0], new List<Pokemon>());
                }
                if (dic.ContainsKey(vhod[0]))
                {
                    dic[vhod[0]].Add(pokemon);
                }
            } while (true);

            foreach (var d in dic)
            {
                Trainer trainer = new Trainer()
                {
                    Name = d.Key,
                    Pokemons = d.Value
                };
                treniori.Add(trainer);
            }
            do
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                //treniori.GroupBy(x => x.Name);
                foreach (var t in treniori)
                {
                    for (int i = 0; i < t.Pokemons.Count; i++)
                    {
                        if (t.Pokemons[i].Element == command)
                        {
                            t.NumberOfBadges++;
                        }
                        else
                        {
                            t.Pokemons[i].Health -= 10;
                        }
                        if (t.Pokemons[i].Health <= 0)
                        {
                            t.Pokemons.Remove(t.Pokemons[i]);
                            i--;
                        }
                    }
                    
                }

            } while (true);
            foreach (var t in treniori)
            {
                Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}");
            }
        }

        private static void RawData()
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Car car = new Car();
                Engine engin = new Engine();
                Cargo cargo = new Cargo();
                Tire gum1 = new Tire();
                Tire gum2 = new Tire();
                Tire gum3 = new Tire();
                Tire gum4 = new Tire();

                var vhod = Console.ReadLine().Split(' ').ToArray();
                car.Model = vhod[0];
                engin.EngineSpeed = int.Parse(vhod[1]);
                engin.EnginePower = int.Parse(vhod[2]);
                cargo.CargoWeight = int.Parse(vhod[3]);
                cargo.CargoType = vhod[4];

                gum1.TirePressure = double.Parse(vhod[5]);
                gum1.TireAge = int.Parse(vhod[6]);
                gum2.TirePressure = double.Parse(vhod[7]);
                gum2.TireAge = int.Parse(vhod[8]);
                gum3.TirePressure = double.Parse(vhod[9]);
                gum3.TireAge = int.Parse(vhod[10]);
                gum4.TirePressure = double.Parse(vhod[11]);
                gum4.TireAge = int.Parse(vhod[12]);

                car.Engine = engin;
                car.Cargo = cargo;
                car.tire1 = gum1;
                car.tire2 = gum2;
                car.tire3 = gum3;
                car.tire4 = gum4;

                cars.Add(car);

            }
            string command = Console.ReadLine();
            cars.GroupBy(x => x.Cargo.CargoType).Where(x => x.Key == command);
            foreach (var c in cars)
            {
                if (command == "fragile" && (c.tire1.TirePressure < 1 || c.tire2.TirePressure < 1 ||
                    c.tire3.TirePressure < 1 || c.tire4.TirePressure < 1))
                {
                    Console.WriteLine(c.Model);
                }
                else if (command == "flamable" && (c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(c.Model);
                }

            }
        }

        private static void SpeedRacing()
        {
            //List<Car> list = new List<Car>();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Car car = new Car();
            //    var kola = Console.ReadLine().Split(' ').ToArray();
            //
            //    car.Model = kola[0];
            //    car.FuelAmount = double.Parse(kola[1]);
            //    car.FuelConsumptionFor1km = double.Parse(kola[2]);
            //    list.Add(car);
            //}
            //List<string> neUspe6no = new List<string>();
            //do
            //{
            //    var vhod = Console.ReadLine();
            //    if (vhod == "End")
            //    {
            //        break;
            //    }
            //    var vh = vhod.Split(' ').ToArray();
            //    string neUs = "Insufficient fuel for the drive";
            //
            //    double kilometri = 0;
            //    foreach (var c in list)
            //    {
            //        if (c.Model == vh[1])
            //        {
            //
            //            if (c.CanMoveDistans(double.Parse(vh[2]), c) == true)
            //            {
            //                c.FuelAmount = c.FuelAmount - (double.Parse(vh[2]) * c.FuelConsumptionFor1km);
            //                c.DistanceTraveled += double.Parse(vh[2]);
            //
            //            }
            //            else
            //            {
            //                neUspe6no.Add(neUs);
            //            }
            //        }
            //    }
            //} while (true);
            //for (int i = 0; i < neUspe6no.Count; i++)
            //{
            //    Console.WriteLine(neUspe6no[i]);
            //}
            //foreach (var c in list)
            //{
            //    Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.DistanceTraveled}");
            //}
        }

        private static void CompanyRoster()
        {
            int n = int.Parse(Console.ReadLine());
            //List<Employee> employees = new List<Employee>();

            Dictionary<string, Department> departments = new Dictionary<string, Department>();

            for (int i = 0; i < n; i++)
            {
                Employee employ = new Employee();
                var slujitel = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                employ.Name = slujitel[0];
                employ.Salary = decimal.Parse(slujitel[1]);
                employ.Position = slujitel[2];

                employ.Salary = decimal.Parse(slujitel[1]);

                if (slujitel.Length == 5)
                {
                    int age;
                    if (int.TryParse(slujitel[4], out age))
                    {
                        employ.Age = age;
                    }
                    else
                    {
                        employ.Email = slujitel[4];
                    }
                }
                else if (slujitel.Length > 5)
                {
                    employ.Email = slujitel[4];
                    employ.Age = int.Parse(slujitel[5]);
                }

                string department = slujitel[3];

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new Department()
                    {
                        Name = department,
                        Employees = new List<Employee>()
                    };
                }

                departments[department].Employees.Add(employ);
            }

            string maxSalaryDepartmentName = departments
                .Values
                .OrderByDescending(d => d.Employees
                    .Average(e => e.Salary))
                    .First().Name;

            Console.WriteLine($"Highest Average Salary: {maxSalaryDepartmentName}");


            foreach (var employee in departments[maxSalaryDepartmentName].Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }

        private static void OpinionPool()
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Person person = new Person();
                person.Name = vhod[0];
                person.Age = int.Parse(vhod[1]);
                if (person.Age > 30)
                {
                    persons.Add(person);
                }
            }
            persons.OrderBy(x => x.Name);
            foreach (var x in persons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{x.Name} - {x.Age}");
            }
        }

        //private static void CarsSalement()
        //{
        //    List<List<string>> list = new List<List<string>>();
        //    int n = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < n; i++)
        //    {
        //        var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //            .ToList();
        //        list.Add(vhod);
        //    }
        //    int m = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < m; i++)
        //    {
        //        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //            .ToArray();
        //        
        //        Engine engine = new Engine();
        //        for (int k = 0; k < input.Length; k++)
        //        {
        //            if (k == 0)
        //            {
        //                engine.Model = input[0];
        //            }
        //            else if (k == 1)
        //            {
        //                for (int r = 0; r < list.Count; r++)
        //                {
        //                    if (list[r][0] == input[1])
        //                    {
        //
        //
        //                        engine.ModelEn = input[1];
        //
        //
        //                        if (list[r].Count >= 2)
        //                        {
        //                            engine.Power = list[r][1];
        //                        }
        //                        if (list[r].Count >= 3)
        //                        {
        //                            int result;
        //                            if (int.TryParse(list[r][2], out result))
        //                            {
        //                                engine.Displacement = list[r][2];
        //                            }
        //                            else
        //                            {
        //                                engine.Efficiency = list[r][2];
        //                                break;
        //                            }
        //
        //                        }
        //                        if (list[r].Count == 4)
        //                        {
        //                            engine.Efficiency = list[r][3];
        //                        }
        //
        //
        //                    }
        //                }
        //            }
        //
        //
        //            else if (k == 2)
        //            {
        //                int result;
        //                if (int.TryParse(input[2], out result))
        //                {
        //                    engine.Weigth = (input[2]).ToString();
        //                }
        //                else
        //                {
        //                    engine.Color = input[2];
        //                    break;
        //                }
        //
        //            }
        //            else if (k == 3)
        //            {
        //                engine.Color = input[3];
        //            }
        //        }
        //        Console.WriteLine(engine.ToString());
        //    }
        //}

        private static void Cotki()
        {
            //new DrawingTool(new Square() { Side = 3 }).Draw();

            //new DrawingTool(new Rectangle() { Heigth = 3, Width = 7 }).Draw();

            List<Cat> cats = new List<Cat>();

            do
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                var cat = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (cat[0])
                {
                    case "Siamese":
                        cats.Add(new Siamese()
                        {
                            Name = cat[1],
                            Breed = cat[0],
                            EarSize = int.Parse(cat[2])
                        });

                        break;
                    case "Cymric":
                        cats.Add(new Cymirc()
                        {
                            Name = cat[1],
                            Breed = cat[0],
                            FurLenth = double.Parse(cat[2])
                        });

                        break;

                    case "StreetExtraordinaire":
                        cats.Add(new StreetExtraordinaire()
                        {
                            Name = cat[1],
                            Breed = cat[0],
                            DecibelsOfMewous = int.Parse(cat[2])
                        });

                        break;

                    default:
                        break;
                }

            } while (true);
            string imeNaKotka = Console.ReadLine();

            Console.WriteLine(cats
                .First(cat => cat.Name == imeNaKotka)
                ?.ToString() ?? string.Empty);
        }
    }
}
