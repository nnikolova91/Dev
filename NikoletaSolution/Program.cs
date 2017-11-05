using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

namespace NikoletaSolution
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();

            do
            {
                var vhod = Console.ReadLine()
                .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

                if (vhod.Count() < 3 || vhod[0] == "quit")
                {
                    break;
                }

                string imeNa4ervei4e = vhod[0];
                string imeOtbor = vhod[1];
                int skorost = int.Parse(vhod[2].TrimEnd().TrimStart());

                if (!dic.ContainsKey(imeOtbor))
                {
                    dic.Add(imeOtbor, new Dictionary<string, int>());
                }

                bool addWorm = true;
                foreach (var team in dic)
                {
                    if (team.Value.Keys.Contains(imeNa4ervei4e))
                    {
                        addWorm = false;
                    }
                }

                if (addWorm)
                {
                    dic[imeOtbor].Add(imeNa4ervei4e, skorost);
                }

            } while (true);

            if (dic.Keys.Count > 0)
            {
                var ordered = dic
                    .OrderByDescending(t => t.Value.Values.Sum())
                    .ThenByDescending(t => t.Value.Values.Sum() / t.Value.Values.Count);

                int order = 1;
                foreach (var team in ordered)
                {
                    var orderedTeamMembers = team.Value.OrderByDescending(m => m.Value);

                    Console.WriteLine($"{order++}. Team: {team.Key} - {team.Value.Values.Sum()}");
                    foreach (var teamMember in orderedTeamMembers)
                    {
                        Console.WriteLine($"###{teamMember.Key} : {teamMember.Value}");
                    }
                }
            }
        }

        /// <summary>
        /// IZPIT 30 April 2017      Zada4a 3                         100/100
        /// </summary>
        static void Izpit30April2017Zad3()
        {
            var sequence = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int stepsCount = 0;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] != 0)
                {
                    int indexToZeroo = i;
                    i = sequence[i];
                    sequence[indexToZeroo] = 0;
                }

                stepsCount++;
            }

            Console.WriteLine(stepsCount);
        }

        /// <summary>
        /// IZPIT 30 April 2017      Zada4a 2                         70/100
        /// </summary>
        static void Izpit30April2017Zad2()
        {
            do
            {
                string vh = Console.ReadLine();
                if (vh == "Worm Ipsum")
                {
                    break;
                }
                var vhod = vh.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (vhod.Length == 1)
                {
                    var sentense = vhod[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (char.IsUpper(sentense[0][0]))
                    {
                        List<string> words = new List<string>();

                        for (int i = 0; i < sentense.Count; i++)
                        {
                            var MostFrequentLetterGroup = sentense[i]
                                .GroupBy(x => x)
                                .OrderByDescending(x => x.Count())
                                .First();

                            int countMostFrequentLetter = MostFrequentLetterGroup.Count();
                            char mostFrequentLetter = MostFrequentLetterGroup.Key;

                            string word = countMostFrequentLetter > 1 ? new string(mostFrequentLetter, sentense[i].Count()) : sentense[i];
                            words.Add(word);
                        }

                        Console.WriteLine($"{string.Join(" ", words)}.");
                    }
                }


            } while (true);
        }

        /// <summary>
        /// IZPIT 30 April 2017      Zada4a 1                         100/100
        /// </summary>
        static void Izpit30April2017Zad1()
        {
            int duljinaMetri = int.Parse(Console.ReadLine());
            double shirinaSm = double.Parse(Console.ReadLine());

            int duljinaSm = duljinaMetri * 100;
            double result = 0;
            if (duljinaSm % shirinaSm == 0 || duljinaSm == 0 || shirinaSm == 0)
            {
                result = (double)duljinaSm * shirinaSm;
                Console.WriteLine($"{result:f2}");
            }
            else if (duljinaSm % shirinaSm != 0)
            {
                result = (double)duljinaSm * 100d / shirinaSm;
                Console.WriteLine($"{result:f2}%");
            }
        }

        /// <summary>
        /// IZPIT   9 Mai 2017         Zada4a   4                     ?40/100
        /// </summary>
        static void Izpit9Mai2017Zad4()
        {
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            do
            {
                string vhod = Console.ReadLine();
                if (vhod == "quit")
                {
                    break;
                }

                // var regex = @"^([a-zA-Z0-9\-]+) -> ([a-zA-Z0-9]+) -> ([0-9]+)$";

                //if (Regex.IsMatch(vhod, regex) )
                //{
                var vh = vhod.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string durjava = vh[0].ToString();
                durjava = durjava.Remove(durjava.Length - 1, 1);

                string shpionin = vh[1].ToString();
                shpionin = shpionin.Remove(0, 1);
                shpionin = shpionin.Remove(shpionin.Length - 1, 1);

                string dniSlujb = vh[2].ToString();
                dniSlujb = dniSlujb.Remove(0, 1);
                int dniSlujba = int.Parse(dniSlujb);


                if (dniSlujba > 0 && dniSlujba <= int.MaxValue)
                {
                    if (!dic.ContainsKey(durjava))
                    {
                        dic.Add(durjava, new Dictionary<string, int>());
                    }
                    if (dic.ContainsKey(durjava))
                    {
                        if (!dic[durjava].ContainsKey(shpionin))
                        {
                            dic[durjava].Add(shpionin, dniSlujba);
                        }
                        else if (dic[durjava].ContainsKey(shpionin))
                        {
                            dic[durjava][shpionin] += dniSlujba;
                        }
                    }
                }


                //}

            } while (true);
            Console.WriteLine();

            foreach (var d in dic.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {d.Key}");
                foreach (var di in d.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{di.Key} : {di.Value}");
                }
            }
        }

        /// <summary>
        /// IZPIT   9 Mai 2017         Zada4a   3                     100/100
        /// </summary>
        static void Izpit9Mai2017Zad3()
        {
            var vhod = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



            for (int i = 0; i < vhod.Count; i++)
            {

                if (vhod.Count > 2)
                {
                    if (i == 0 && vhod[i] == vhod[i + 1])
                    {
                        vhod.RemoveAt(i + 1);
                        i = 0;
                    }
                    else if (i >= 1 && i <= vhod.Count - 2)
                    {
                        if (vhod[i] == vhod[i - 1] + vhod[i + 1])
                        {

                            vhod.RemoveAt(i + 1);
                            vhod.RemoveAt(i - 1);
                            i = 0;
                        }
                    }
                    else if (i == vhod.Count - 1)
                    {
                        if (vhod[vhod.Count - 1] == vhod[vhod.Count - 2])
                        {
                            vhod.RemoveAt(vhod.Count - 2);
                            i = 0;
                        }
                    }

                }

                else if (vhod.Count == 2)
                {
                    if (vhod[0] == vhod[1])
                    {
                        vhod.RemoveAt(1);
                    }
                }


            }



            foreach (var v in vhod)
            {
                Console.Write($"{v} ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// IZPIT   9 Mai 2017         Zada4a   2                     100/100
        /// </summary>
        static void Izpit9Mai2017Zad2()
        {
            SortedDictionary<string, List<string>> dicimenaIsuob = new SortedDictionary<string, List<string>>();
            List<int> cifrii = new List<int>();
            string cifri = Console.ReadLine();


            for (int i = 0; i < cifri.Length; i++)
            {
                string c = cifri[i].ToString();
                cifrii.Add(int.Parse(c));


            }
            do
            {
                string vh = Console.ReadLine();
                if (vh == "END")
                {
                    break;
                }
                var regex = $"^(TO: ([A-Z]+); MESSAGE: .+;$)";
                string ime = "";

                if (Regex.IsMatch(vh, regex))
                {
                    for (int i = 4; i < vh.Length - 1; i++)
                    {
                        if (vh[i] == ';')
                        {
                            break;
                        }
                        ime += vh[i];
                    }
                    if (!dicimenaIsuob.ContainsKey(ime))
                    {
                        dicimenaIsuob.Add(ime, new List<string>());
                    }

                    string novoSuob6tenie = "";
                    string suob6tenie = vh.ToString();

                    int k = 0;
                    for (int i = 0; i < suob6tenie.Length; i++)
                    {
                        if (k > cifrii.Count - 1)
                        {
                            k = 0;
                        }

                        int chislo = suob6tenie[i];
                        int chisloASCII = cifrii[k] + chislo;
                        //char simvol = chisloASCII;

                        novoSuob6tenie += (char)chisloASCII;

                        k++;
                    }
                    if (dicimenaIsuob.ContainsKey(ime))
                    {
                        dicimenaIsuob[ime].Add(novoSuob6tenie);
                    }

                }

            } while (true);
            foreach (var d in dicimenaIsuob.Values)
            {
                foreach (var di in d)
                {
                    Console.WriteLine(di);
                }

            }
        }

        /// <summary>
        /// IZPIT   9 Mai 2017         Zada4a   1                     100/100
        /// </summary>
        static void Izpit9Mai2017Zad1()
        {
            double razstoqnieVMili = double.Parse(Console.ReadLine());
            double kapazitetNaRezervL = double.Parse(Console.ReadLine());
            double miliVTejkiVetrove = double.Parse(Console.ReadLine());

            double miliVNormalnoVreme = razstoqnieVMili - miliVTejkiVetrove;
            double izrzhodenoGorivoVNormalnoVremevLitri = miliVNormalnoVreme * 25d;
            double izrazhodenoGorivoVLo6oVremeLitri = miliVTejkiVetrove * (25d * 1.5d);
            double izrazhodenoGorivoOb6to = izrazhodenoGorivoVLo6oVremeLitri + izrzhodenoGorivoVNormalnoVremevLitri;
            double dopulnitelnoGorivo = 0.05d * izrazhodenoGorivoOb6to;
            double nujnoGorivo = izrazhodenoGorivoOb6to + dopulnitelnoGorivo;

            Console.WriteLine($"Fuel needed: {nujnoGorivo:f2}L");
            if (nujnoGorivo <= kapazitetNaRezervL)
            {
                Console.WriteLine($"Enough with {(kapazitetNaRezervL - nujnoGorivo):f2}L to spare!");
            }
            else if (nujnoGorivo > kapazitetNaRezervL)
            {
                Console.WriteLine($"We need {(nujnoGorivo - kapazitetNaRezervL):f2}L more fuel.");
            }
        }

        /// <summary>
        /// IZPIT  20 Avgust 2017        Zada4a    4          100/100
        /// </summary>
        static void Ivzpit20Av2017Zad4()
        {
            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            do
            {
                string vh = Console.ReadLine();
                if (vh == "It's Training Men!")
                {
                    break;
                }

                var vhod = vh
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (vhod.Length == 5)
                {
                    if (!dic.ContainsKey(vhod[0]))
                    {
                        dic.Add(vhod[0], new Dictionary<string, int>());

                    }
                    if (dic.ContainsKey(vhod[0]))
                    {
                        dic[vhod[0]].Add(vhod[2], int.Parse(vhod[4]));
                    }
                }
                else if (vhod.Length == 3)
                {
                    if (vhod[1] == "->" || vhod[1] == "=")
                    {
                        if (!dic.ContainsKey(vhod[0]))
                        {
                            dic.Add(vhod[0], new Dictionary<string, int>());
                        }

                        if (dic.ContainsKey(vhod[0]))
                        {
                            if (vhod[1] == "=")
                            {
                                dic[vhod[0]].Clear();
                            }
                            foreach (var it in dic[vhod[2]])
                            {
                                if (!dic[vhod[0]].ContainsKey(it.Key))
                                {
                                    dic[vhod[0]].Add(it.Key, it.Value);
                                }
                                else if (dic[vhod[0]].ContainsKey(it.Key))
                                {
                                    dic[vhod[0]][it.Key] += it.Value;
                                }
                            }

                        }
                    }
                    if (vhod[1] == "->")
                    {
                        //dic[vhod[2]].Clear();
                        dic.Remove(vhod[2]);
                    }
                }

            } while (true);
            Console.WriteLine();

            foreach (var vlak in dic.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(y => y.Value.Count))
            {
                Console.WriteLine($"Train: {vlak.Key}");

                foreach (var v in vlak.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{v.Key} - {v.Value}");
                }
            }
        }

        /// <summary>
        /// IZPIT  20 Avgust 2017        Zada4a    3          100/100
        /// </summary>
        static void Ivzpit20Av2017Zad3()
        {
            List<string> regexi = new List<string>();
            var regex = @"^(<[[][^a-zA-Z0-9]*?]\.(\.\[[a-zA-Z0-9]*\]\.)*)$";
            do
            {


                string vhod = Console.ReadLine();
                if (vhod == "Traincode!")
                {
                    break;
                }

                var rr = Regex.Match(vhod, regex);
                regexi.Add(rr.ToString());


            } while (true);
            foreach (var r in regexi)
            {
                if (r != "")
                {
                    Console.WriteLine(r);
                }

            }
        }

        /// <summary>
        /// IZPIT  20 Avgust 2017        Zada4a    2          70/100
        /// </summary>
        static void Ivzpit20Av2017Zad2()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> vagoniSTeglo = new List<int>();
            int ob6toTeglo = 0;
            do
            {
                string vhod = Console.ReadLine();
                if (vhod == "All ofboard!")
                {
                    break;
                }
                else
                {
                    int teglo = int.Parse(vhod);
                    vagoniSTeglo.Add(teglo);
                    ob6toTeglo += teglo;
                    if (ob6toTeglo > n)
                    {
                        break;
                    }
                }

            } while (true);
            int srednoAritmeti4no = ob6toTeglo / vagoniSTeglo.Count;

            int naiMalkaRazlika = int.MaxValue;
            int index = 0;

            for (int i = 0; i < vagoniSTeglo.Count; i++)
            {

                int razlika = Math.Abs(vagoniSTeglo[i] - srednoAritmeti4no);

                if (razlika < naiMalkaRazlika)
                {
                    naiMalkaRazlika = razlika;
                    index = i;
                }
            }
            vagoniSTeglo.RemoveAt(index);
            vagoniSTeglo.Reverse();
            vagoniSTeglo.Add(n);

            foreach (var vt in vagoniSTeglo)
            {
                Console.Write($"{vt} ");
            }
        }

        /// <summary>
        /// IZPIT  20 Avgust 2017        Zada4a    1          90/100
        /// </summary>
        static void Izpit20Avgust2017Zad1()
        {
            int broiU4astnici = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> grupiIDohodi = new Dictionary<string, decimal>();

            if (broiU4astnici > 0 && broiU4astnici < 1000)
            {
                for (int i = 0; i < broiU4astnici; i++)
                {
                    long razstoqnieMili = long.Parse(Console.ReadLine());
                    decimal tovarVtonove = decimal.Parse(Console.ReadLine());
                    string ekipNaU4astnika = Console.ReadLine();
                    if (razstoqnieMili > 0 && razstoqnieMili < 1000000 && tovarVtonove > 0 && tovarVtonove < 1000000 && (ekipNaU4astnika == "Technical" || ekipNaU4astnika == "Theoretical" || ekipNaU4astnika == "Practical"))
                    {
                        long razstoqnieVMetri = razstoqnieMili * 1600;
                        decimal tovarVKg = tovarVtonove * 1000m;
                        decimal razhodGorivo = 0.7m * (decimal)razstoqnieVMetri * 2.5m;
                        decimal pariOb6to = 1.5m * (decimal)tovarVKg;
                        decimal krainaSuma = pariOb6to - razhodGorivo;

                        if (!grupiIDohodi.ContainsKey(ekipNaU4astnika))
                        {
                            grupiIDohodi.Add(ekipNaU4astnika, krainaSuma);
                        }
                        else if (grupiIDohodi.ContainsKey(ekipNaU4astnika))
                        {
                            grupiIDohodi[ekipNaU4astnika] += krainaSuma;
                        }
                    }
                }
            }

            int m = 1;
            foreach (var grupa in grupiIDohodi.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (m == 1)
                {
                    Console.WriteLine($"The {grupa.Key} Trainers win with ${grupa.Value:f3}.");
                    m++;
                    break;
                }
            }
        }

        /// <summary>
        /// Izpit   4 Septemvri 2017  Zada4a     3                   100/100
        /// </summary>
        static void Izpit4SepZad3()
        {
            List<string> vsi4koo = new List<string>();
            var regex = @"(([^\s_]{3}){1})(\.{1}([^\s_]{3}))*";
            string otgovor = "";

            bool simetric = false;
            do
            {
                string vhod = Console.ReadLine();
                if (vhod == "ReadMe")
                {
                    break;
                }
                var reg = Regex.Match(vhod, regex);

                for (int k = 0; k < vhod.Length / 2; k++)
                {
                    if (vhod[k] == vhod[vhod.Length - 1 - k])
                    {
                        simetric = true;
                    }
                    else
                    {
                        simetric = false;
                        break;
                    }
                }

                if (simetric == false)
                {
                    otgovor = "NO";
                }

                if (!(vhod.Contains(" ") || vhod.Contains("_")))
                {
                    if (reg.Value == vhod && simetric == true)
                    {
                        otgovor = "YES";
                    }
                }
                else
                {
                    otgovor = "NO";
                }
                if (reg.Success == false)
                {
                    otgovor = "NO";
                }
                Console.WriteLine(otgovor);
            } while (true);
        }

        /// <summary>
        /// Izpit   4 Septemvri 2017  Zada4a     2                             100/100  
        /// </summary>
        static void Izpit4Sep2017Zad2()
        {
            var plo6tadka = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int udar = 1;
            int na4alenIndex = int.Parse(Console.ReadLine());
            do
            {
                string vhod = Console.ReadLine();
                if (vhod == "Supernova")
                {
                    break;
                }
                var posokaIstupki = vhod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string posoka = posokaIstupki[0];
                int stupki = int.Parse(posokaIstupki[1]);
                int br = 1;


                while (stupki > 0)
                {
                    if (posoka == "left")
                    {
                        while (stupki > 0)
                        {
                            if (na4alenIndex > 0)
                            {
                                stupki--;

                                na4alenIndex--;
                                plo6tadka[na4alenIndex] = plo6tadka[na4alenIndex] - udar;
                            }
                            if (na4alenIndex == 0 && stupki > 0)
                            {
                                na4alenIndex = plo6tadka.Length;
                                udar++;
                                //stupki++;
                            }
                        }

                    }
                    if (posoka == "right")
                    {
                        while (stupki > 0)
                        {
                            if (na4alenIndex < plo6tadka.Length - 1)
                            {
                                stupki--;

                                na4alenIndex++;
                                plo6tadka[na4alenIndex] = plo6tadka[na4alenIndex] - udar;
                            }
                            if (na4alenIndex == plo6tadka.Length - 1 && stupki > 0)
                            {
                                na4alenIndex = -1;
                                udar++;
                                //stupki++;
                            }
                        }

                    }

                }


            } while (true);
            foreach (var p in plo6tadka)
            {
                Console.Write($"{p} ");
            }
        }

        /// <summary>
        /// Izpit   4 Septemvri 2017  Zada4a     1
        /// </summary>
        static void Izp1()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int duljinaTqlo = int.Parse(Console.ReadLine());
                double shirinaTqlo = double.Parse(Console.ReadLine());
                int duljinaCrilo = int.Parse(Console.ReadLine());

                double godiniOb6to = (double)(duljinaTqlo * duljinaTqlo) * (shirinaTqlo + 2d * (double)duljinaCrilo);
                Console.WriteLine(godiniOb6to);
            }
        }
        /// <summary>
        /// REXEX Mai e gre6na
        /// </summary>
        static void Regex4()
        {
            var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";

            string datiVhod = Console.ReadLine();

            var dati = Regex.Matches(datiVhod, regex);

            foreach (Match d in dati)
            {
                var day = d.Groups["day"].Value;
                var month = d.Groups["month"].Value;
                var year = d.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }

        /// <summary>
        /// REGEX LEKCII Zada4a 3
        /// </summary>
        static void Regex3()
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            string hexaDesimal = Console.ReadLine();
            var hexa = Regex.Matches(hexaDesimal, regex);

            var numbers = hexa.Cast<Match>()
                .Select(a => a.Value)
                .ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
        /// <summary>
        /// REGEX LEKCII Zada4a 2
        /// </summary>
        static void Regex2()
        {
            var regex = @"\+359(\s)?(\-)?[2]\1?\-?\d{3}\1?\2?\d{4}";
            string telefoni = Console.ReadLine();
            var phonMatches = Regex.Matches(telefoni, regex);
            var matchedPhones = phonMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
            Console.WriteLine();
        }
        /// <summary>
        /// REGEX LEKCII Zada4a 1
        /// </summary>
        static void Regex1()
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();
            MatchCollection matchedNames = Regex.Matches(names, regex);

            foreach (Match name in matchedNames)
            {

                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
        /// <summary>
        /// STRING Namirane na 4ast ot tekst i kolko puti se povtarq
        /// </summary>
        static void StringObrabotkaZad2()
        {
            var text = Console.ReadLine().ToLower();
            var patern = Console.ReadLine().ToLower();
            var count = 0;
            var index = -1;


            while (true)
            {
                index = text.IndexOf(patern, index + 1);
                if (index == -1)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
        /// <summary>
        /// IZPIT  Programming Fundamentals  // 23 Oktomvri 2016     Zada4a   4     //  ????????????? Ne moga da gi podredq po Count
        /// </summary>
        static void IzpitZad4()
        {
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();
            do
            {
                var vhod1 = Console.ReadLine();
                if (vhod1 == "Time for Code")
                {
                    break;
                }

                var vhod = vhod1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();


                bool podmini = false;
                for (int i = 1; i < vhod.Length; i++)
                {
                    if (i == 1)
                    {
                        if (vhod[i][0] != '#')
                        {
                            podmini = true;
                        }
                    }
                    if (i > 1)
                    {
                        if (vhod[i][0] != '@')
                        {
                            podmini = true;
                        }
                    }
                }
                string izp = "";
                for (int i = 0; i < vhod[1].Length; i++)
                {
                    if (i > 0)
                    {
                        izp += vhod[1][i];
                    }
                }
                List<string> izpulniteli = new List<string>();
                List<string> listZaDic = new List<string>();
                if (podmini != true)
                {

                    for (int i = 1; i < vhod.Length; i++)
                    {
                        if (i > 1)
                        {

                            izpulniteli.Add(vhod[i]);
                        }
                    }


                    if (!dic.ContainsKey(vhod[0]))
                    {
                        dic.Add(vhod[0], new Dictionary<string, List<string>>());
                        dic[vhod[0]].Add(izp, new List<string>());
                        listZaDic = new List<string>(izpulniteli);
                        dic[vhod[0]][izp] = listZaDic;
                    }
                    if (dic.ContainsKey(vhod[0]))
                    {
                        if (dic[vhod[0]].ContainsKey(izp))
                        {
                            for (int i = 1; i < vhod.Length; i++)
                            {
                                if (i > 1)
                                {
                                    if (!dic[vhod[0]][izp].Contains(vhod[i]))
                                    {
                                        dic[vhod[0]][izp].Add(vhod[i]);
                                    }
                                }
                            }

                        }
                    }
                }
            } while (true);
            //dic.Values.Select(x => x.Select(y => y. Value.Count));
            foreach (var d in dic/*.Select(x => x).OrderByDescending(x=>x.Values.Count)*/)
            {
                foreach (var di in d.Value.OrderBy(x => x.Value.Count))
                {
                    Console.WriteLine($"{di.Key} - {di.Value.Count}");
                    foreach (var m in di.Value)
                    {
                        Console.WriteLine(m);
                    }
                }

            }
        }
        /// <summary>
        /// IZPIT  Programming Fundamentals  // 23 Oktomvri 2016     Zada4a   3     //70/100
        /// </summary>
        static void IzpitZad3()
        {
            var vhod = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //List<string> result = new List<string>();
            Dictionary<int, string> resultt = new Dictionary<int, string>();

            for (int i = 0; i <= vhod.Length - 1; i++)
            {
                string vh = vhod[i].ToString();

                string chislo = "";
                double sborChisla = 0;
                double damage = 0;
                int sumBukvi = 0;
                bool ima4islo = false;
                bool vlqzohVPurvoto = false;

                for (int k = 0; k < vh.Length; k++)
                {
                    if (vh[k] != '+' && vh[k] != '-' && vh[k] != '*' && vh[k] != '/' && vh[k] != '.' &&
                        vh[k] != '0' && vh[k] != '1' && vh[k] != '2' && vh[k] != '3' && vh[k] != '4' && vh[k] != '5' && vh[k] != '6' &&
                        vh[k] != '7' && vh[k] != '8' && vh[k] != '9')
                    {
                        sumBukvi += vh[k];

                        if (ima4islo == true)
                        {
                            sborChisla += double.Parse(chislo);
                            chislo = "";
                            vlqzohVPurvoto = true;
                            ima4islo = false;
                        }
                    }

                    if (vh[k] == '-' || vh[k] == '+' || vh[k] == '.' || vh[k] == '0' || vh[k] == '1' || vh[k] == '2' || vh[k] == '3' || vh[k] == '4'
                        || vh[k] == '5' || vh[k] == '6' || vh[k] == '7' || vh[k] == '8' || vh[k] == '9')
                    {
                        chislo += vh[k];
                        ima4islo = true;
                    }

                }
                if (ima4islo == true)
                {
                    sborChisla += double.Parse(chislo);
                    chislo = "";
                }
                for (int m = 0; m < vh.Length; m++)
                {
                    if (vh[m] == '/')
                    {
                        sborChisla /= (double)2;
                    }
                    if (vh[m] == '*')
                    {
                        sborChisla *= (double)2;
                    }
                }
                string format = $"{vhod[i]} - {sumBukvi} health, {sborChisla:f2} damage";
                resultt.Add(i, format);

                chislo = "";
                sborChisla = 0;
                sumBukvi = 0;
                damage = 0;
            }
            foreach (var r in resultt.OrderBy(x => x.Value))
            {
                Console.WriteLine(r.Value);
            }
        }

        /// <summary>
        /// OBEKTI   Zada4a    10
        /// </summary>
        static void Studentiii()
        {
            var vhod = Console.ReadLine();

            Dictionary<Grad, List<Students>> dic = new Dictionary<Grad, List<Students>>();

            Grad grad = null;
            while (vhod != "End")
            {
                if (vhod.Contains("=>"))
                {
                    string[] input = vhod.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s = s.Trim()).ToArray();

                    grad = new Grad();
                    grad.NameGrad = input[0].ToString();
                    grad.Capacitet = int.Parse(input[1][0].ToString());

                    dic.Add(grad, new List<Students>());
                }
                else
                {
                    string[] input = vhod.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s = s.Trim()).ToArray();

                    Students student = new Students();
                    student.Name = input[0].ToString();
                    student.Email = input[1].ToString();
                    student.Date = DateTime.ParseExact(input[2].ToString(), "d-MMM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    dic[grad].Add(student);
                }

                vhod = Console.ReadLine();
            }

            int towns = dic.Keys.Count;

            int groups = 0;
            foreach (var town in dic)
            {
                groups += town.Value.Count / town.Key.Capacitet;
                groups = town.Value.Count % town.Key.Capacitet == 0 ? groups : groups + 1;
            }

            Console.WriteLine($"Created {groups} groups in {towns} towns:");

            foreach (var cityStudentsPair in dic.OrderBy(d => d.Key.NameGrad))
            {
                var ordered = cityStudentsPair.Value.OrderBy(s => s.Date).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();

                do
                {
                    Console.Write($"{cityStudentsPair.Key.NameGrad} => ");

                    for (int i = 0; i < cityStudentsPair.Key.Capacitet && ordered.Count > 0; i++)
                    {
                        if (i != 0)
                        {
                            Console.Write(", ");
                        }

                        Console.Write(ordered[0].Email);
                        ordered.RemoveAt(0);
                    }
                    Console.WriteLine();
                } while (ordered.Count > 0);
            }
        }

        /// <summary>
        /// OBEKTI Zada4a    7
        /// </summary>
        static void Magazin4e()
        {
            Dictionary<string, decimal> produktiSCeni = new Dictionary<string, decimal>();
            List<Customer> customers = new List<Customer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (!produktiSCeni.ContainsKey(vhod[0]))
                {
                    produktiSCeni.Add(vhod[0], decimal.Parse(vhod[1]));
                }
                else
                {
                    produktiSCeni[vhod[0]] = decimal.Parse(vhod[1]);
                }
            }
            do
            {
                var vhod1 = Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (vhod1[0] == "end of clients")
                {
                    break;
                }

                string customerName = vhod1[0];
                string produkt = vhod1[1];
                int broi = int.Parse(vhod1[2]);

                if (produktiSCeni.ContainsKey(produkt))
                {
                    decimal totalPrice = broi * produktiSCeni[produkt];
                    Customer customer = customers.Where(c => c.Name == customerName).FirstOrDefault();
                    if (customer != null)
                    {
                        customer.Bill += totalPrice;
                        customer.Pokupki.Add(produkt, broi);
                    }
                    else
                    {
                        customers.Add(new Customer()
                        {
                            Bill = totalPrice,
                            Name = customerName,
                            Pokupki = new Dictionary<string, int>() { { produkt, broi } }
                        });
                    }
                }
            } while (true);

            decimal cenaOb6to = 0;
            foreach (var cus in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine($"{cus.Name}");

                foreach (var item in cus.Pokupki)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {cus.Bill:f2}");

                cenaOb6to += cus.Bill;
            }
            Console.WriteLine($"Total bill: {cenaOb6to:f2}");

        }
        /// <summary>
        /// OBEKTI Upr  Zada4a    6
        /// </summary>
        static void Books()
        {
            List<Book> books = new List<Book>();

            List<Book> books1 = new List<Book>();

            Dictionary<string, DateTime> dic = new Dictionary<string, DateTime>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Book book = new Book();

                book.NameBook = vhod[0];
                book.NameAutour = vhod[1];
                book.Publisher = vhod[2];
                book.Data = DateTime.ParseExact(vhod[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.Isbn = long.Parse(vhod[4]);
                book.Price = decimal.Parse(vhod[5]);

                books.Add(book);
            }

            string kd = Console.ReadLine();
            DateTime Na4alnaData = DateTime.ParseExact(kd, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books.Where(x => x.Data > Na4alnaData).OrderBy(x => x.Data).ThenByDescending(x => x.NameBook)
                .ToList().ForEach(x => Console.WriteLine($"{x.NameBook} -> {x.Data.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}"));

        }
        /// <summary>
        ///  OBEKTI upr   Zada4a   5
        /// </summary>
        static void Book()
        {
            List<Book> books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Book book = new Book();

                book.NameBook = vhod[0];
                book.NameAutour = vhod[1];
                book.Publisher = vhod[2];
                book.Data = DateTime.ParseExact(vhod[3], "dd.MM.yyyy", null); ;
                book.Isbn = long.Parse(vhod[4]);
                book.Price = decimal.Parse(vhod[5]);

                books.Add(book);
            }

            Dictionary<string, decimal> authorPrice = new Dictionary<string, decimal>();

            foreach (var author in books.Select(b => b.NameAutour).Distinct())
            {
                if (!authorPrice.ContainsKey(author))
                {
                    authorPrice.Add(author, books.Where(b => b.NameAutour == author).Sum(b => b.Price));
                }
            }

            foreach (var item in authorPrice.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
        /// <summary>
        /// Obekti   Upr   Zada4a    3
        /// </summary>
        ////static void Circle()
        ////{
        //    class Circle
        //{
        //    public double X { get; set; }
        //    public double Y { get; set; }
        //    public double Radius { get; set; }

        //    public double Diagonal { get { return Math.Sqrt(X * X + Y * Y); } }

        //}
        //var okrujnost1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(double.Parse)
        //        .ToArray();

        //    Circle krug1 = new Circle();
        //    krug1.X = okrujnost1[0];
        //    krug1.Y = okrujnost1[1];
        //    krug1.Radius = okrujnost1[2];
        //    double diagonal1 = krug1.Diagonal;

        //    var okrujnost2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(int.Parse)
        //        .ToArray();

        //    Circle krug2 = new Circle();
        //    krug2.X = okrujnost2[0];
        //    krug2.Y = okrujnost2[1];
        //    krug2.Radius = okrujnost2[2];
        //    double diagonal2 = krug2.Diagonal;

        //    double razstoqnie = diagonal2 - diagonal1;
        //    if (razstoqnie <= krug1.Radius + krug2.Radius)
        //    {
        //        Console.WriteLine("Yes");
        //    }
        //    else
        //    {
        //        Console.WriteLine("No");
        //    }
        //}
        /// <summary>
        /// Obekti Sredno-aritmeti4ni ocenki nad 5:00    Zada4a   4
        /// </summary>
        static void ObektiUprZad4()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                string[] inputArguments = Console.ReadLine().Split();

                student.Name = inputArguments[0];
                student.Grades = inputArguments.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }
            students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.Average:F2}"));
        }

        /// <summary>
        /// OBEKTI  -  Count Working Days   Zada4a     1
        /// </summary>
        static void ObektiUprZad1()
        {
            DateTime startDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endtDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holideis = { DateTime.ParseExact("01-01-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("03-03-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-05-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("06-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("22-09-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("01-11-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("24-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("25-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),
            DateTime.ParseExact("26-12-1970", "dd-MM-yyyy", CultureInfo.InvariantCulture),};

            int countOfWorkingDays = 0;

            for (DateTime sega6naData = startDate; sega6naData <= endtDate; sega6naData = sega6naData.AddDays(1))
            {
                if (sega6naData.DayOfWeek != DayOfWeek.Saturday && sega6naData.DayOfWeek != DayOfWeek.Sunday)
                {
                    bool isNotHoliday = true;
                    foreach (var holiday in holideis)
                    {
                        if (holiday.Day == sega6naData.Day && holiday.Month == sega6naData.Month)
                        {
                            isNotHoliday = false;
                            break;
                        }

                    }
                    if (isNotHoliday)
                    {
                        countOfWorkingDays++;
                    }

                }
            }
            Console.WriteLine(countOfWorkingDays);
        }

        /// <summary>
        /// ///////////////////////////////////////////  OBEKTI
        /// </summary>
        static void Listoveeee()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> redica = new List<int>();
            List<int> pomo6tnaRedica = new List<int>();
            List<int> naiDulga = new List<int>();

            int lqv = 0;
            int naiLqv = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                redica.Add(arr[i]);
                do
                {
                    for (int m = i; m >= 0; m--)
                    {

                        if (arr[m] < arr[i])
                        {
                            for (int k = m; k >= 0; k--)
                            {
                                if (arr[m] < redica[0])
                                {
                                    redica.Insert(0, arr[m]);
                                    lqv = m;
                                }
                            }
                        }

                    }
                } while (true);
                for (int l = i; l <= arr.Length - 1; l++)
                {
                    if (arr[l] > redica[redica.Count - 1])
                    {
                        redica.Add(arr[l]);
                    }
                }
                if (redica.Count > naiDulga.Count)
                {
                    naiDulga = new List<int>(redica);
                }
                redica.Clear();
            }
            Console.WriteLine(String.Join(" ", naiDulga));

            int[] arrSort = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrSort[i] = arr[i];
            }

            Array.Sort(arrSort);

            int[] arrIndex = new int[arr.Length];
            int iar = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int k = 0; k <= arr.Length - 1; k++)
                {
                    if (arrSort[i] == arr[k])
                    {
                        arrIndex[iar] = k;
                        iar++;
                        break;
                    }
                }
            }
            List<int> chisla = new List<int>();
            List<int> tchisla = new List<int>();

            int brElementi = 0;
            int maxBrElementi = 0;
            int chislo = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arrIndex[i] < arrIndex[i + 1])
                {
                    chisla.Add(arrSort[i]);
                    brElementi++;
                    for (int m = i; m < arr.Length; m++)
                    {
                        if (arrIndex[m] > arrIndex[i] && arrIndex[m] < arrIndex[i + 1] /* && arrSort[m] < arrSort[i+1]*/)
                        {
                            if (arrIndex[i + 1] > arrIndex[i + 2])
                            {
                                arrIndex[i + 1] = arrIndex[m];
                                chisla.Add(/*arrSort[i + 1]*/arrSort[m]);
                                if (true)
                                {

                                }
                            }


                            //chisla.Add(arrSort[arrIndex[i]]);
                        }

                    }

                }
                else if (arrIndex[i] > arrIndex[i + 1])
                {
                    brElementi = 0;
                    chisla.Clear();
                }
                if (brElementi > maxBrElementi)
                {
                    maxBrElementi = brElementi;
                    tchisla = new List<int>(chisla);
                }
            }
            Console.WriteLine(String.Join(" ", tchisla));
        }
        /// <summary>
        /// 
        /// </summary>
        private static void Re4niciDragons()
        {
            Dictionary<string, List<double>> dic2 = new Dictionary<string, List<double>>();
            Dictionary<string, SortedDictionary<string, int[]>> dic1 = new Dictionary<string, SortedDictionary<string, int[]>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (vhod[2] == "null")
                {
                    vhod[2] = "45";
                    int.Parse(vhod[2]);
                }
                if (vhod[3] == "null")
                {
                    vhod[3] = "250";
                    int.Parse(vhod[3]);
                }
                if (vhod[4] == "null")
                {
                    vhod[4] = "10";
                    int.Parse(vhod[4]);
                }

                if (dic1.ContainsKey(vhod[0]) && dic1[vhod[0]].ContainsKey(vhod[1]))
                {
                    dic1[vhod[0]][vhod[1]] = new int[] { int.Parse(vhod[2]), int.Parse(vhod[3]), int.Parse(vhod[4]) };
                }

                if (!dic1.ContainsKey(vhod[0]))
                {
                    dic1.Add(vhod[0], new SortedDictionary<string, int[]>()/* new int[] { int.Parse(vhod[2]), int.Parse(vhod[3]), int.Parse(vhod[4]) }*/);
                }

                if (!dic1[vhod[0]].ContainsKey(vhod[1]))
                {
                    dic1[vhod[0]].Add(vhod[1], new int[] { int.Parse(vhod[2]), int.Parse(vhod[3]), int.Parse(vhod[4]) });
                }
            }

            int chislo = 0;
            int sredno = 0;

            foreach (var k in dic1)
            {
                List<int> chisla = new List<int>();
                List<double> sredA = new List<double>();

                for (int i = 0; i < 3; i++)
                {
                    foreach (var v in k.Value.Values)
                    {
                        chisla.Add(v[i]);
                    }
                    var average = chisla.Average();
                    sredA.Add(average);
                    chisla.Clear();
                }

                double c1 = sredA[0];
                double c2 = sredA[1];
                double c3 = sredA[2];

                dic2[k.Key] = new List<double> { c1, c2, c3 };
            }

            foreach (var k in dic2)
            {
                Console.WriteLine($"{k.Key}::({k.Value[0]:f2}/{k.Value[1]:f2}/{k.Value[2]:f2})");

                foreach (var d in dic1/*.Values*/.Where(x => x.Key == k.Key))
                {
                    foreach (var r in d.Value)
                    {
                        Console.WriteLine($"-{r.Key} -> damage: {r.Value[0]}, health: {r.Value[1]}, armor: {r.Value[2]}");
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Re4niciiii()
        {
            Dictionary<string, Dictionary<string, long>> mUSuma
                = new Dictionary<string, Dictionary<string, long>>();
            do
            {
                var vhod = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (vhod[0] == "End")
                {
                    break;
                }
                if (vhod.Length >= 4)
                {

                    string predposl = vhod[vhod.Length - 2];
                    long chislo = 0;
                    try
                    {
                        chislo = long.Parse(predposl);


                        string mqsto = string.Empty;
                        long cena = long.Parse(vhod[vhod.Length - 1]) * chislo;

                        //string vh = string.Empty;
                        //for (int i = 0; i < vhod.Length - 2; i++)
                        //{
                        //    vh += vhod[i] + " ";
                        //
                        //}
                        //if (vh.Contains("@"))
                        //{
                        //    for (int i = 0; i < vh.Length-1; i++)
                        //    {
                        //        while (vh[i]!='@')
                        //        {
                        //            ime += vh[i];
                        //        }
                        //    }
                        //    for (int i = ime.Length; i < vh.Length; i++)
                        //    {
                        //        grad+= vh[i];
                        //    }
                        //}

                        //vhod = vh.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                        mqsto = vhod[1];
                        if (mqsto.Contains('@'))
                        {
                            if (!mUSuma.ContainsKey(mqsto))
                            {
                                mUSuma.Add(mqsto, new Dictionary<string, long>());
                            }
                            if (mUSuma.ContainsKey(mqsto))
                            {
                                if (!mUSuma[mqsto].ContainsKey(vhod[0]))
                                {
                                    mUSuma[mqsto].Add(vhod[0], cena);
                                }
                                else
                                {
                                    mUSuma[mqsto][vhod[0]] += cena;
                                }
                            }
                        }


                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

            } while (true);

            foreach (var k in mUSuma)
            {
                Console.WriteLine(k.Key);

                foreach (var ke in k.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {ke.Key}-> {ke.Value}");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void ObrutaneiSumiraneNa4isla()
        {
            //Dictionary<string, string> d = new Dictionary<string, string>();
            // Dictionary<string, Dictionary<string, string>> d1 = new Dictionary<string, Dictionary<string, string>>();

            List<string> num = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int total = 0;
            for (int i = 0; i < num.Count; i++)
            {
                //string current = num[i].ToString();
                //total += int.Parse(string.Join("", current.Reverse()));

                int number = int.Parse(num[i]);
                int reversed = 0;

                while (number != 0)
                {
                    int r = number % 10;
                    reversed = reversed * 10 + r;
                    number /= 10;
                }

                total += reversed;
            }

            Console.WriteLine(total);
        }
        /// <summary>
        /// 
        /// </summary>
        static void ListiPoKomandi()
        {
            List<int> chisla = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comand = Console.ReadLine();
            while (comand != "print")
            {
                List<string> comanda = comand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (comanda[0] == "add")
                {
                    chisla.Insert(int.Parse(comanda[1]), int.Parse(comanda[2]));
                }
                if (comanda[0] == "addMany")
                {
                    //chisla.Insert(chisla[1], int.Parse(comanda[i]));
                    chisla.InsertRange(int.Parse(comanda[1]),
                    comanda.Skip(2).Select(int.Parse).ToArray());
                }
                if (comanda[0] == "contains")
                {
                    for (int i = 0; i < comanda.Count; i++)
                    {
                        if (int.Parse(comanda[1]) == chisla[i])
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
                if (comanda[0] == "remove")
                {
                    chisla.RemoveAt(int.Parse(comanda[1]));

                }
                if (comanda[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(comanda[1]); i++)
                    {
                        chisla.Add(chisla[i]);
                        chisla.RemoveAt(0);
                    }
                }
                if (comanda[0] == "sumPairs")
                {
                    int posledno4islo = chisla[chisla.Count - 1];
                    List<int> sum = new List<int>();
                    for (int i = 0; i <= chisla.Count / 2; i++)
                    {
                        sum.Add(chisla[i] + chisla[i + 1]);
                    }
                    if (chisla.Count % 2 == 0)
                    {
                        chisla = new List<int>(sum);
                    }
                    else
                    {
                        chisla = new List<int>(sum);
                        chisla.Add(posledno4islo);
                    }
                }
                comand = Console.ReadLine();
            }
            if (comand == "print")
            {
                Console.WriteLine(String.Join(" ", chisla));
            }
        }
        /// <summary>
        /// ************** ListUPR Zada4a   4
        /// </summary>
        static void Muka()
        {
            int[] chisla = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> krainaRedica = new List<int>();
            List<int> maxRedica = new List<int>();
            List<int> redica = new List<int>();

            for (int i = 0; i <= chisla.Length - 1; i++)
            {

                redica.Insert(0, chisla[i]);

                for (int k = i; k >= 0; k--)
                {
                    if (chisla[k] < redica[0])
                    {
                        redica.Insert(0, chisla[k]);
                    }
                }
                if (redica.Count >= maxRedica.Count)
                {
                    maxRedica = new List<int>(redica);

                }

                redica.Clear();
            }
            Console.WriteLine(String.Join(" ", maxRedica));
        }

        /// <summary>
        /// Ima ili nqma dadeno 4islo sled premahvane na elementi ot masiv   Zada4a   3
        /// </summary>
        static void ListUprZad3()
        {
            List<int> redica = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] operacii = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> chisla = new List<int>();
            bool ima = false;

            for (int i = 0; i <= operacii[0] - 1; i++)
            {
                chisla.Add(redica[i]);
            }
            for (int i = 0; i < operacii[1]; i++)
            {
                chisla.RemoveAt(0);

            }
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] == operacii[2])
                {
                    ima = true;
                }
            }
            if (ima == true)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
        /// <summary>
        /// Posledovatelno polu4avane na komandi Zada4a   2
        /// </summary>
        static void ListUprZada4a2()
        {
            List<int> chisla = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comanda = Console.ReadLine();

            while (comanda != "Odd" && comanda != "Even")
            {
                string[] comand = comanda
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (comand[0] == "Delete")
                {
                    chisla.RemoveAll(x => x == int.Parse(comand[1]));
                }
                if (comand[0] == "Insert")
                {
                    chisla.Insert(int.Parse(comand[2]), int.Parse(comand[1]));
                }
                comanda = Console.ReadLine();

            }
            if (comanda == "Odd")
            {
                for (int i = 0; i <= chisla.Count - 1; i++)
                {
                    if (chisla[i] % 2 == 1)
                    {
                        Console.Write("{0} ", chisla[i]);
                    }
                }
            }
            else if (comanda == "Even")
            {
                for (int i = 0; i <= chisla.Count - 1; i++)
                {
                    if (chisla[i] % 2 == 0)
                    {
                        Console.Write("{0} ", chisla[i]);
                    }
                }
            }
        }
        /// <summary>
        /// Zist Zad 1
        /// </summary>
        static void ListUprZadd1()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int broiEdnacvi = 1;
            int maxBrEdnakvi = 1;
            int index = 0;

            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    broiEdnacvi++;
                    if (broiEdnacvi > maxBrEdnakvi)
                    {
                        maxBrEdnakvi = broiEdnacvi;
                        index = i;
                    }
                }
                else
                {
                    broiEdnacvi = 1;

                }
            }
            for (int i = 0; i < maxBrEdnakvi; i++)
            {
                Console.Write("{0} ", arr[index]);
            }
        }
        /// <summary>
        /// Glavni, malki ili smeseni bukvi v duma  Zada4a 4
        /// </summary>
        static void ListZada4a4()
        {
            string[] dumi = Console.ReadLine()
                 .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '/', '[', ']', '\\', '\'' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            Console.WriteLine("Lower-case: " + string.Join(", ", dumi.
                Where(
                d => d.All(l =>
                        char.IsLetter(l) && char.IsLower(l)))));

            Console.WriteLine("Mixed-case: " + string.Join(", ",
                dumi.Where(
                    d => d.Any(l => !char.IsLetter(l)) ||
                    (d.Any(l => char.IsLower(l)) && d.Any(l => char.IsUpper(l))))));

            Console.WriteLine("Upper-case: " + string.Join(", ",
                dumi.Where(
                    d => d.All(
                        l => char.IsLetter(l) && char.IsUpper(l)))));



            List<string> glavniDumi = new List<string>();
            List<string> malkiDumi = new List<string>();
            List<string> smeseni = new List<string>();

            for (int i = 0; i <= dumi.Length - 1; i++)
            {
                bool imaGlavni = false;
                bool imaMalki = false;

                char[] duma = dumi[i].ToArray();
                for (int k = 0; k <= duma.Length - 1; k++)
                {
                    if (char.IsUpper(duma[k]))
                    {
                        imaGlavni = true;
                    }
                    else if (char.IsDigit(duma[k]) || !char.IsLetter(duma[k]))
                    {
                        imaMalki = true;
                        imaGlavni = true;
                    }
                    else
                    {
                        imaMalki = true;
                    }
                }

                if (imaMalki && imaGlavni)
                {
                    smeseni.Add(dumi[i]);
                }
                else if (imaGlavni)
                {
                    glavniDumi.Add(dumi[i]);
                }
                else
                {
                    malkiDumi.Add(dumi[i]);
                }
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", malkiDumi));
            Console.WriteLine("Mixed-case: " + string.Join(", ", smeseni));
            Console.WriteLine("Upper-case: " + string.Join(", ", glavniDumi));
        }
        /// <summary>
        /// Zada4a 5 ***
        /// </summary>
        static void ListoveUprZada4aa5()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string comand = Console.ReadLine();

            while (comand != "print")
            {
                var comandArgs = comand
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (comandArgs[0] == "add")
                {
                    numbers.Insert(int.Parse(comandArgs[1]), int.Parse(comandArgs[2]));
                }
                else if (comandArgs[0] == "addMany")
                {
                    numbers.InsertRange(int.Parse(comandArgs[1]),
                        comandArgs.Skip(2).Select(int.Parse).ToArray());
                }
                else if (comandArgs[0] == "contains")
                {
                    int number = int.Parse(comandArgs[1]);
                    // if (numbers.Contains(number))
                    //{
                    Console.WriteLine(numbers.IndexOf(number));
                    //}                    
                }
                else if (comandArgs[0] == "remove")
                {
                    numbers.RemoveAt(int.Parse(comandArgs[1]));
                }
                else if (comandArgs[0] == "shift")
                {
                    int number = int.Parse(comandArgs[1]);
                    number = number % numbers.Count;
                    for (int i = 0; i < number; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (comandArgs[0] == "sumPairs")
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);

                    }
                }

                comand = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        /// <summary>
        /// obru6tane na 4isla razdeleni s "|" i " "  Zada4a   2
        /// </summary>
        static void ListoveZada4a2()
        {
            string[] chisla =
                 Console.ReadLine()
                .Split('|');


            List<int> results = new List<int>();

            for (int i = chisla.Length - 1; i >= 0; i--)
            {
                int[] element =
                    chisla[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                results.AddRange(element);
            }
            Console.WriteLine(String.Join(" ", results));

        }

        private static object Select(Func<string, int> parse)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Premahvane na otricatelni elementi ot spisak  Zada4a   1
        /// </summary>
        static void SpisukZad1()
        {
            int[] chisla = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> chislaa = new List<int>(chisla);
            chislaa.Reverse();

            chislaa.RemoveAll(x => x < 0);
            if (chislaa.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", chislaa));
            }
        }

    }
}