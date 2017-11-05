using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikoletaSolution
{
    public class Cat
    {
        public static int godinaNaProizhodNaKotkite;

        public string name;
        public int age;
        public int speeed;
        public int kg;
        public int sleepTime;

        public void Meaw()
        {
            Console.WriteLine("Meaw");
        }

        public void Eat(int kg)
        {
            this.kg = this.kg + kg;
            Console.WriteLine("eating. now i am {0}kg after the eating", this.kg);
        }

        public static void PrintWhatCatsLike()
        {
            Console.WriteLine("all cats like milk");
        }
    }
}
