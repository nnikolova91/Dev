using System;

namespace Classes
{
    public class Square : IShape
    {
        public int Side { get; set; }

        public void Draw()
        {
            for (int i = 0; i < Side; i++)
            {
                if (i == 0 || i == Side - 1)
                {
                    Console.WriteLine($"|{new string('-', Side)}|");
                }
                else
                {
                    Console.WriteLine($"|{new string(' ', Side)}|");
                }
            }
        }
    }
}
