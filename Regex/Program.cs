using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexExp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "([a-z]+)([0-9]+)";
            string input = "textabv1 asd TT TTT T wew4 444sxds a4 aaa";

            Regex r = new Regex(pattern);
            //Match match = r.Match(input);

            MatchCollection matches = r.Matches(input);

            int sum = 0;
            foreach (Match m in matches)
            {
                Console.WriteLine(m);
                sum += int.Parse(m.Groups[2].Value);
            }

            //Console.WriteLine(match.Value);
        }
    }
}
