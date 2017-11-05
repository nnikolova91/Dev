using System;
using System.Collections.Generic;
using System.Linq;

namespace NikoletaSolution
{
    public class Dragon
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

      //static void Main(string[] args)
      //{
      //    Dragon dragon = new Dragon();
      
      //    dragon.PrintDragonsLogic();
      //}

        public override string ToString()
        {
            return $"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}";
        }

        public void PrintDragonsLogic()
        {
            List<Dragon> dragons = new List<Dragon>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                Dragon existing = dragons.Where(d => d.Color == vhod[0] && d.Name == vhod[1]).FirstOrDefault();

                if (existing != null)
                {
                    existing.Damage = vhod[2] != "null" ? int.Parse(vhod[2]) : 45;
                    existing.Health = vhod[3] != "null" ? int.Parse(vhod[3]) : 250;
                    existing.Armor = vhod[4] != "null" ? int.Parse(vhod[4]) : 10;
                }
                else
                {
                    dragons.Add(new Dragon()
                    {
                        Color = vhod[0],
                        Name = vhod[1],
                        Damage = vhod[2] != "null" ? int.Parse(vhod[2]) : 45,
                        Health = vhod[3] != "null" ? int.Parse(vhod[3]) : 250,
                        Armor = vhod[4] != "null" ? int.Parse(vhod[4]) : 10
                    });
                }
            }

            var dragonColors = dragons.Select(d => d.Color).Distinct();

            foreach (var color in dragonColors)
            {
                var avrgDamage = dragons.Where(d => d.Color == color).Average(d => d.Damage);
                var avrgHealth = dragons.Where(d => d.Color == color).Average(d => d.Health);
                var avrgArmor = dragons.Where(d => d.Color == color).Average(d => d.Armor);

                Console.WriteLine($"{color}::({avrgDamage:f2}/{avrgHealth:f2}/{avrgArmor:f2})");

                foreach (var dragon in dragons.Where(d => d.Color == color).OrderBy(d => d.Name))
                {
                    Console.WriteLine(dragon);
                }
            }
        }
    }
}
