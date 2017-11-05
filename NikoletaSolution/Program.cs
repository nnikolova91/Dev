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

        }
        /// <summary>
        /// Exam Preparei6un III  Zada4a 2
        /// </summary>
        static void PodgotovkaZaIzpit1()
        {

        }
        /// <summary>
        /// Exam Preparei6un III  Zada4a 1
        /// </summary>
        static void PodgotovkaZaIzpit()
        {

        }
        /// <summary>
        /// kolko puti se sadurja duma v text   zada4a  3
        /// </summary>
        static void FEEx()
        {
            string[] lines = File.ReadAllLines("text.txt").Select(w => w.ToLower()).ToArray();
            string[] words = File.ReadAllText("words.txt").Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var line in lines)
            {
                var wordsInLine = line.Split(new char[] { '.', '!', '?', ' ', '-', '\r', '\n' });
                foreach (var w in wordsInLine)
                {
                    nums[k] += nums[k + 1];
                    nums.RemoveAt(k + 1);
                    k = -1;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
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

        /// <summary>
        /// 
        /// </summary>
        static void Masivi()
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();
            int broi4isla = 0;

            if (arr.Length == 1)
            {
                Console.Write(arr[0]);
            }

            else if (arr.Length % 2 == 0)
            {
                broi4isla = (arr.Length - 2) / 2;
                for (int i = 0; i <= broi4isla + 2 - 1; i++)
                {
                    if (i > broi4isla - 1)
                    {
                        Console.Write(arr[i]);
                        Console.Write(" ");
                    }
                }
            }
            else if (arr.Length % 2 == 1)
            {
                broi4isla = (arr.Length - 3) / 2;
                for (int i = 0; i <= broi4isla + 3 - 1; i++)
                {
                    if (i > broi4isla - 1)
                    {
                        Console.Write(arr[i]);
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Svejdaneto na masiv do edno 4islo 4rez sumirane   Zada4a 8
        /// </summary>
        static void MasiviZad8()
        {
            int[] arr1 = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();
            if (arr1.Length == 1)
            {
                Console.WriteLine(arr1[0]);
            }
            else
            {
                for (int j = arr1.Length - 1; j > 0; j--)
                {
                    int[] condenzed = new int[j];

                    for (int i = 0, m = arr1.Length - 1; i <= arr1.Length - 2; i++, m--)
                    {
                        if (i >= j)
                        {
                            break;
                        }
                        condenzed[i] = arr1[i] + arr1[i + 1];
                        arr1[i] = condenzed[i];
                    }
                    if (j == 1)
                    {
                        Console.WriteLine(condenzed[j - 1]);
                    }
                }
            }
        }
        /// <summary>
        /// Sbor na elementite na dva masiva s razli4na duljina Zada4a   7
        /// </summary>
        static void MasiviZad7()
        {
            int[] arr1 = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();
            int[] arr2 = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();

            int max = Math.Max(arr1.Length, arr2.Length);
            int min = Math.Min(arr1.Length, arr2.Length);


            int sum = 0;
            int[] arr = new int[max];

            for (int i = 0, m = 0; i <= max - 1; i++, m++)
            {
                if (arr2.Length < arr1.Length)
                {
                    if (m < min)
                    {
                        arr[i] = arr2[m];
                        sum = arr[i] + arr1[i];
                        Console.Write("{0} ", sum);
                    }
                    else
                    {
                        m = -1;
                        i--;
                    }
                }
                else
                {
                    if (m < min)
                    {
                        arr[i] = arr1[m];
                        sum = arr[i] + arr2[i];
                        Console.Write("{0} ", sum);
                    }
                    else
                    {
                        m = -1;
                        i--;
                    }
                }

            }

        }
        /// <summary>
        /// Sbor na kraini 4etvurti sus sreda na masiv  Zada4a   3
        /// </summary>
        static void MAsiviUprZad3()
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();

            int[] newarr = new int[arr.Length / 2];
            int[] left = new int[arr.Length / 4];
            int[] right = new int[arr.Length / 4];

            int sum = 0;

            for (int i = arr.Length / 4 - 1, k = 0; i >= 0 && k <= arr.Length / 4 - 1; i--, k++)
            {
                left[k] = arr[i];
            }
            for (int k = arr.Length - 1, j = 0; j <= arr.Length / 4 - 1 && k >= 3 * (arr.Length / 4); k--, j++)
            {
                right[j] = arr[k];
            }
            newarr = left.Concat(right).ToArray();

            int[] myarr = new int[arr.Length / 2];

            for (int i = arr.Length / 4, k = 0; i <= 3 * (arr.Length / 4) - 1; i++, k++)
            {
                myarr[k] = arr[i];
            }

            for (int i = 0; i <= arr.Length / 2 - 1; i++)
            {
                sum = myarr[i] + newarr[i];
                Console.Write(sum);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Razdelqne na masiv na ednakvi po sbor polovini  Zada4a  11
        /// </summary>
        static void MasiviUPRZAd11()
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();

            int sum1 = 0;
            int sum2 = 0;
            bool ima = false;
            if (arr.Length == 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                for (int i = 1; i <= arr.Length - 2; i++)
                {
                    for (int k = i - 1, m = i + 1; k >= 0 || m <= arr.Length - 1; k--, m++)
                    {
                        if (k >= 0)
                        {
                            sum1 += arr[k];
                        }
                        if (m <= arr.Length - 1)
                        {
                            sum2 += arr[m];
                        }
                    }
                    if (sum1 == sum2)
                    {
                        Console.WriteLine(i);
                        ima = true;
                    }
                    else
                    {
                        sum1 = 0;
                        sum2 = 0;
                    }
                }
                if (ima == false)
                {
                    Console.WriteLine("no");
                }
            }
        }
        /// <summary>
        /// Dvoiki 4isla s ednakva razlika  Zada4a    10
        /// </summary>
        static void MasiviUPRZad10()
        {
            int[] arr = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => int.Parse(x))
                 .ToArray();
            int razlika = int.Parse(Console.ReadLine());

            int broi = 0;
            bool ima = false;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int k = i; k >= 0; k--)
                {
                    if (Math.Max(arr[i], arr[k]) - Math.Min(arr[k], arr[i]) == razlika)
                    {
                        broi++;
                        ima = true;
                        // Console.WriteLine($"{arr[k]},{arr[i]}");
                    if (dict.ContainsKey(w))
                    {
                        dict[w]++;
                    }
                    else
                    {
                        dict[w] = 1;
                    }
                }
                File.WriteAllText("results.txt", "");
                foreach (var wordAndCount in dict.OrderBy(w => w.Value))
                {
                    if (words.Contains(wordAndCount.Key))
                    {
                        Console.WriteLine(wordAndCount.Key + " => " + wordAndCount.Value);
                    }

                }
            }
        }
        /// <summary>
        /// Lekcii Ne4etni redove     Zada4a    1
        /// </summary>
        static void FILesEExep()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] oddLines = lines.Where((line, i) => i % 2 == 1).ToArray();
            File.WriteAllLines("output.txt", oddLines);

            foreach (var od in oddLines)
            {
                Console.WriteLine(od);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Dictionary()
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
                    string ime = "";
                    string grad = "";
                    string predposl = vhod[vhod.Length - 2];
                    long chislo = 0;
                    try
                    {
                        chislo = long.Parse(predposl);


                        string mqsto = string.Empty;
                        long cena = long.Parse(vhod[vhod.Length - 1]) * chislo;

                        string vh = string.Empty;
                        for (int i = 0; i < vhod.Length - 2; i++)
                        {
                            vh += vhod[i] + " ";

                        }
                    }
                }
            }
            if (!ima)
            {
                Console.WriteLine("No");
            }
        }

        static void Zada4a3()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1, c = 1; c <= k && j >= 0; j--, c++)
                {
                    arr[i] += arr[j];
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        /// <summary>
        /// Masivi Zada4a 2
        /// </summary>
        static void Obru6taneNa4islaVObratenRed()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                arr[i] = chislo;
            }
            for (int k = 0; k <= n - 1; k++)
            {
                int[] myarr = new int[n];
                myarr[k] = arr[n - 1 - k];
                Console.Write("{0} ", myarr[k]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Sasoooo()
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                FibNums(num);
            }
        }
        static void FibNums(int num)
        {
            int first = 0;
            int second = 1;

            List<int> list = new List<int>()
            {
                first,
                second
            };

            for (int i = 3; i <= num; i++)
            {
                list.Add(first + second);

                int temp = second;
                second += first;
                first = temp;
            }

            Console.WriteLine(string.Join(" ", list));
        }

        private static int Fib(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else if (num == 1)
            {
                return 1;
            }

            int previous = 1;
            int current = 1;

            for (int i = 2; i <= num; i++)
            {
                int temp = current;
                current += previous;
                previous = temp;
            }

            return current;
        }

        static void PrintReversedOrder(decimal num2)
        {
            var stringNum = num2.ToString();
            for (int i = stringNum.Length - 1; i >= 0; i--)
            {
                Console.Write(stringNum[i]);
            }
            Console.WriteLine();
        }

        static string PoslednaCifra(long n)
        {
            switch (n % 10)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void MasiviZad1()
        {
            string[] arr = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if (n > 0 && n < 8)
            {
                Console.WriteLine(arr[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void SborNa4etniINe4etniCifriNa4islo()
        {
            int n = int.Parse(Console.ReadLine());
            int umnojeni = Chetni(n) * Ne4etni(n);
            Console.WriteLine((umnojeni));
        }

        static int Chetni(int n)
        {
            n = Math.Abs(n);
            int sumChetni = 0;
            while (n > 0)
            {
                int posledno4islo = n % 10;
                if (posledno4islo % 2 == 0)
                {
                    sumChetni += posledno4islo;
                }


                n /= 10;
            }
            return sumChetni;
        }
        static int Ne4etni(int n)
        {
            n = Math.Abs(n);
            int sumNe4etni = 0;
            while (n > 0)
            {
                int poslednoChislo = n % 10;
                if (poslednoChislo % 2 == 1)
                {
                    sumNe4etni += poslednoChislo;
                }
                n /= 10;
            }
            return sumNe4etni;
        }

        //int ob6toVremeVSekundi = broiSnimki * vremeZaPreglejdane + (int)procentSnimkiObrabotka * vremeZaObrabotvane;

        //int brSekundi = ob6toVremeVSekundi % 60;
        //int ostSek = ob6toVremeVSekundi - brSekundi;
        //int brMinuti = ostSek % 60;
        //ostSek -= brMinuti;
        //int br4asove = ostSek % 60;
        //ostSek -= br4asove;
        //int brDni = ostSek % 60;

        //Console.WriteLine("{0}:{1}:{2}:{3}", brDni, br4asove, brMinuti, brSekundi);


        //TimeSpan t = new TimeSpan();
        //t = t.Add(TimeSpan.FromSeconds(100));

        //Console.WriteLine(t);

        //var res = Sort(new int[5] { 2, 1, 3, 5, 4 });

        //Console.ReadLine();

        static int[] Sort(int[] nums)
        {
            for (int i = nums.Length; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        Swap(nums, j - 1, j);
                    }
                }
            }

            return nums;
        }

        static void Swap(int[] nums, int first, int second)
        {
            int temp = nums[first];
            nums[first] = nums[second];
            nums[second] = temp;
        }

        static void NaiGolqmo4islo(int purvo, int vtoro)
        {
            int a = Math.Max(purvo, vtoro);

            Console.WriteLine(a);
        }

        static void NaiGolqmTekst(string purvo, string vtoro)
        {
            if (purvo.CompareTo(vtoro) >= 0)
            {
                Console.WriteLine(purvo);
            }


        }
        static void NaiGolqmChar(char purvo, char vtoro)
        {
            int a = purvo.CompareTo(vtoro);
        }

        static void MUKa()
        {

            // int[] arr = { 7,5,1, 81, 64 };
            //
            // int chislo = 0;
            //
            // int indeksNaVtoriMasiv = 0;
            //
            // 
            //
            // int[] myArr = new int[arr.Length];
            //
            // for (int i = 1; i <= 16; i++)
            // {
            //     for (int k = 0; k < arr.Length; k++)
            //     {
            //         arr[k] = arr[k] / 2;
            //
            //         if (arr[k]<1)
            //         {
            //             myArr[indeksNaVtoriMasiv] = chislo;
            //             indeksNaVtoriMasiv++;
            //             Console.Write("{0} ", myArr[indeksNaVtoriMasiv]);
            //         }
            //         
            //     }
            // }

            //int[] arr = { 7, 5, 1, 81, 64 };
            //
            //
            // int brOperacii = 0;
            //
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    string dvoi4na = Convert.ToString(arr[i], 16);
            //    int[] arrOtVsekiElement = new int[dvoi4na.Length];
            //
            //    if (arr[i] == 1)
            //    {
            //
            //    }
            //
            //    Console.WriteLine(dvoi4na);
            //}



            // int broiSnimki = int.Parse(Console.ReadLine());
            // int vremeZaPreglejdane = int.Parse(Console.ReadLine());
            // int procentSnimkiObrabotka = int.Parse(Console.ReadLine());
            // int vremeZaObrabotvane = int.Parse(Console.ReadLine());
            //
            // double brSnimkiZaObrabotka = Math.Ceiling((double)procentSnimkiObrabotka / 100d * broiSnimki);
            //
            //
            // int ob6toVremeVSekundi = broiSnimki * vremeZaPreglejdane + (int)procentSnimkiObrabotka * vremeZaObrabotvane;
            //
            // int brSekundi = ob6toVremeVSekundi % 60;
            // int ostSek = ob6toVremeVSekundi - brSekundi;
            // int brMinuti = ostSek % 60;
            // ostSek -= brMinuti;
            // int br4asove = ostSek % 60;
            // ostSek -= br4asove;
            // int brDni = ostSek % 60;
            //
            // Console.WriteLine("{0}:{1}:{2}:{3}", brDni, br4asove, brMinuti,brSekundi);


            /*  double ednoo = edno * 100000000d;
              double dvee = dve * 100000000d;
              double maksRazlika = 0.000001d * 100000000d;

              if (ednoo-dvee<maksRazlika)
              {
                  Console.WriteLine("Thru");
                  Console.WriteLine((ednoo-dvee)/100000000d);
              }
              else
              {
                  Console.WriteLine("False");
                  Console.WriteLine((ednoo - dvee) / 100000000d);
              }*/



            // {
            //   int chislo1 = int.Parse(Console.ReadLine());
            //     int chislo2 = int.Parse(Console.ReadLine());
            //  int chislo3 = int.Parse(Console.ReadLine());
            // int chislo4 = int.Parse(Console.ReadLine());

            // Console.WriteLine("{0:D4}", 12);
            // Console.WriteLine("{0}", (12).ToString().PadLeft(4));
            //Console.WriteLine("{0}", (12).ToString().PadRight(4, '0'));
            //Console.ReadKey();

            //if (chislo<10)
            //{

            //    Console.Write("000{0} ", chislo);
            //}
            //if (chislo>=10 && chislo<100)
            //{
            //    Console.Write("00{0} ", chislo);
            //}
            //if (chislo>=100 && chislo<1000)
            //{
            //    Console.Write("0{0} ", chislo);
            //}
            //if (chislo>=1000)
            //{
            //    Console.Write("{0} ", chislo);
            //}
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        static void Kum16ti4naIDvui4na()
        {
            int n = int.Parse(Console.ReadLine());

            string m = Convert.ToString(n, 16);
            m = m.ToUpper();
            Console.WriteLine(m);

            string o = Convert.ToString(n, 2);
            Console.WriteLine(o);
        }

        static void ToLower()
        {
            int n = int.Parse(Console.ReadLine());

            int calorii = 0;

            for (int i = 1; i <= n; i++)
            {
                string sustavka = Console.ReadLine();
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

                        vhod = vh.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

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

        /// <summary>
        /// 18 Oktomvri 2015 zada4a - 3
        /// </summary>
        static void PlaidTowel()
        {
            int n = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            char dies = (char)35;
            char dot = (char)46;


            int brt = n;
            int brtv = -1;
            int brts = 2 * n - 1;


            if (a == new string(dot, 1) && b == new string(dies, 1))
            {
                for (int put = 1; put <= 2; put++)
                {

                    for (int row = 1; row <= 2 * n; row++)
                    {
                        if (row == 1)
                        {
                            Console.WriteLine("{0}{2}{1}{2}{0}", new string(dot, n), new string(dot, 2 * n - 1), dies);
                        }
                        if (row > 1 && row <= n)
                        {
                            brt--;
                            brtv += 2;
                            brts -= 2;
                            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(dot, brt), new string(dot, brtv), new string(dot, brts), dies);
                        }
                        if (row == n + 1)
                        {
                            Console.WriteLine("{1}{0}{1}{0}{1}", new string(dot, (4 * n - 2) / 2), dies);
                        }

                        if (row > n + 1 && row <= 2 * n)
                        {
                            brt++;
                            brtv -= 2;
                            brts += 2;
                            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(dot, brt - 1), new string(dot, brtv + 2), new string(dot, brts - 2), dies);
                        }
                    }
                }
                Console.WriteLine("{0}{2}{1}{2}{0}", new string(dot, n), new string(dot, 2 * n - 1), dies);
            }
            if (a == new string(dies, 1) && b == new string(dot, 1))
            {
                for (int put = 1; put <= 2; put++)
                {
                    for (int row = 1; row <= 2 * n; row++)
                    {
                        if (row == 1)
                        {
                            Console.WriteLine("{0}{2}{1}{2}{0}", new string(dies, n), new string(dies, 2 * n - 1), dot);
                        }
                        if (row > 1 && row <= n)
                        {
                            brt--;
                            brtv += 2;
                            brts -= 2;
                            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(dies, brt), new string(dies, brtv), new string(dies, brts), dot);
                        }
                        if (row == n + 1)
                        {
                            Console.WriteLine("{1}{0}{1}{0}{1}", new string(dies, (4 * n - 2) / 2), dot);
                        }

                        if (row > n + 1 && row <= 2 * n)
                        {
                            brt++;
                            brtv -= 2;
                            brts += 2;
                            Console.WriteLine("{0}{3}{1}{3}{2}{3}{1}{3}{0}", new string(dies, brt - 1), new string(dies, brtv + 2), new string(dies, brts - 2), dot);
                        }

                    }
                }
                Console.WriteLine("{0}{2}{1}{2}{0}", new string(dies, n), new string(dies, 2 * n - 1), dot);

            }
        }

        /// <summary>
        /// 16 Avgust 2015 zada4a - 3
        /// </summary>
        static void ChristmasThree()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = n + 1;
            int brch = -1;
            int brtd = (2 * n - 2) / 2 + 1;
            int brchd = 1;
            for (int row = 1; row <= 3 * (n / 2 + 1) + 1; row++)
            {
                if (row >= 1 && row <= n / 2 + 1)
                {
                    brt--;
                    brch += 2;
                    Console.WriteLine("{0}{1}{0}", new string('\'', brt), new string('^', brch));
                }
                if (row > n / 2 + 1 && row <= n + 1)
                {
                    brtd--;
                    brchd += 2;
                    Console.WriteLine("{0}{1}{0}", new string('\'', brtd), new string('^', brchd));
                }
                if (row > n + 1 && row < 3 * (n / 2 + 1) + 1)
                {
                    Console.WriteLine("{0}| |{0}", new string('\'', n - 1));
                }
                if (row == 3 * (n / 2 + 1) + 1)
                {
                    Console.WriteLine("{0}", new string('-', 2 * n + 1));
                }
            }
        }

        /// <summary>
        /// 8 Noemvri 2015 zada4a - 3
        /// </summary>
        static void LcalElections()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            int otb = 0;
            int nomer = 0;
            for (int brl = 1; brl <= a; brl++)
            {
                nomer++;
                otb++;
                if (otb == b)
                {
                    for (int row = 1; row <= 6; row++)
                    {
                        if (row == 1)
                        {
                            Console.WriteLine("{0}", new string('.', 13));
                        }
                        if (row == 2)
                        {
                            Console.WriteLine("...+-----+...");
                        }
                        if (row == 3)
                        {
                            if (c == new string('x', 1) || c == new string('X', 1))
                            {
                                Console.WriteLine("...|.\\./.|...");
                            }
                            if (c == new string('v', 1) || c == new string('V', 1))
                            {
                                Console.WriteLine("...|\\.../|...");
                            }
                        }
                        if (row == 4)
                        {
                            if (c == new string('x', 1))
                            {
                                if (nomer < 10)
                                {
                                    Console.WriteLine("0{0}.|..{1}..|...", nomer, new string('x', 1));
                                }
                                else
                                {
                                    Console.WriteLine("{0}.|..{1}..|...", nomer, new string('x', 1));
                                }
                            }
                            if (c == new string('X', 1))
                            {
                                if (nomer < 10)
                                {
                                    Console.WriteLine("0{0}.|..{1}..|...", nomer, new string('X', 1));
                                }
                                else
                                {
                                    Console.WriteLine("{0}.|..{1}..|...", nomer, new string('X', 1));
                                }
                            }
                            if (c == new string('v', 1) || c == new string('V', 1))
                            {
                                if (otb < 10)
                                {
                                    Console.WriteLine("0{0}.|.\\./.|...", otb);
                                }
                                else
                                {
                                    Console.WriteLine("{0}.|.\\./.|...", otb);
                                }
                            }


                        }
                        if (row == 5)
                        {
                            if (c == new string('x', 1) || c == new string('X', 1))
                            {
                                Console.WriteLine("...|./.\\.|...");
                            }
                            if (row == 5 && c == new string('v', 1))
                            {
                                Console.WriteLine("...|..{0}..|...", new string('v', 1));
                            }
                            if (row == 5 && c == new string('V', 1))
                            {
                                Console.WriteLine("...|..{0}..|...", new string('V', 1));
                            }
                        }

                        if (row == 6)
                        {
                            Console.WriteLine("...+-----+...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    if (nomer < 10)
                    {
                        Console.WriteLine("0{0}.|.....|...", nomer);
                    }
                    else
                    {
                        Console.WriteLine("{0}.|.....|...", nomer);
                    }

                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 28 Noemvri 2015 zada4a - 3
        /// </summary>
        static void AceofDiamonds()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = (n - 3) / 2 + 1;
            int brm = -1;
            int brmd = n - 2;
            int brtd = (n - (2 + brmd)) / 2;
            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine("{0}", new string('*', n));
                }
                if (row > 1 && row <= (n - 1) / 2 + 1)
                {
                    brt--;
                    brm += 2;
                    Console.WriteLine("*{0}{1}{0}*", new string('-', brt), new string('@', brm));
                }
                if (row > (n - 1) / 2 + 1 && row < n)
                {
                    brtd++;
                    brmd -= 2;
                    Console.WriteLine("*{0}{1}{0}*", new string('-', brtd), new string('@', brmd));
                }
            }
        }

        /// <summary>
        /// 17 Qnuari 2016 zada4a - 3
        /// </summary>
        static void IluminatiLock()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = n;
            int brtv = -2;
            int brts = n - 2;
            int brtd = -1;
            int brtvd = (3 * n - 8 - brts) / 2 + 2;
            for (int row = 1; row <= n + 1; row++)
            {
                if (row == 1 || row == n + 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));
                }
                if (row > 1 && row <= n / 2 + 1)
                {
                    brt -= 2;
                    brtv += 2;
                    Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', brt), new string('.', brtv), new string('.', brts));

                }
                if (row > n / 2 + 1 && row < n + 1)
                {
                    brtd += 2;
                    brtvd -= 2;
                    Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', brtd), new string('.', brtvd), new string('.', brts));
                }
            }
        }

        /// <summary>
        /// 21 Fevruari 2016 zada4a - 3
        /// </summary>
        static void CVETE()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = 2 * n + 2;
            int brz = -1;
            int brts = -2;
            int brtd = -1;
            int brzd = n + 1;
            int brtsd = 2 * n + 2;
            for (int row = 1; row <= 3 * n + 1; row++)
            {
                if (row >= 1 && row <= 2 * n + 1)
                {

                    if (row >= 1 && row <= n)
                    {
                        brt -= 2;
                        brz++;
                        brts += 2;
                        Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#", new string('~', brz), new string('.', brt), new string('.', brts));
                    }
                    if (row > n && row <= 2 * n + 1)
                    {
                        brtd += 2;
                        brzd--;
                        brtsd -= 2;
                        Console.WriteLine("{0}#{1}#{2}#{1}#{0}", new string('.', brtd), new string('~', brzd), new string('.', brtsd));
                    }
                }
                if (row > 2 * n + 1 && row <= 3 * n + 1)
                {
                    Console.WriteLine("{0}##{0}", new string('.', (4 * n + 4) / 2));
                }

            }
        }

        /// <summary>
        /// 23 Iuli 2017   zada4a-5
        /// </summary>
        static void KUPA()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = n - 1;
            int brs = 3 * n + 2;

            for (int row = 1; row <= 2 * n + 4; row++)
            {

                if (row >= 1 && row <= n + 2)
                {
                    brt++;
                    brs -= 2;
                    if (row > n / 2 && row <= n + 1)
                    {
                        Console.WriteLine("{0}#{1}#{0}", new string('.', brt), new string('.', brs - 2));
                    }
                    if (row == n + 2)
                    {
                        Console.WriteLine("{0}#{1}#{0}", new string('.', brt - 1), new string('#', brs));
                    }
                    if (row >= 1 && row <= n / 2)
                    {
                        Console.WriteLine("{0}{1}{0}", new string('.', brt), new string('#', brs));
                    }
                }
                if (row > n + 2 && row <= 2 * n + 4)
                {
                    if (row == n + 2 + n / 2 + 1)
                    {
                        Console.WriteLine("{0}{1}^{2}^{3}^{4}^{5}^{0}", new string('.', (5 * n - 10) / 2), new string('D', 1), new string('A', 1), new string('N', 1), new string('C', 1), new string('E', 1));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}", new string('.', (5 * n - (n + 4)) / 2), new string('#', n + 4));
                    }

                }

            }
        }

        /// <summary>
        /// 25 Iuni 2017 zada4a - 5
        /// </summary>
        static void TRIUGULNIK()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = 0;
            int brs = (4 * n - 1 - 3) / 2 + 3;
            int brint = -1;
            int brt1 = n;
            int brs1 = 4 * n + 1 - 2 * (n + 1) + 2;
            for (int row = 1; row <= 2 * n + 1; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}", new string('#', 4 * n + 1));
                }
                if (row > 1 && row <= n + 1)
                {
                    brt++;
                    brs -= 2;
                    brint += 2;
                    if (row == n / 2 + 2)
                    {
                        Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', brt), new string('#', brs), new string(' ', (4 * n - 1 - 2 * brt - 2 * brs) / 2));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', brt), new string('#', brs), new string(' ', brint));
                    }

                }
                if (row > n + 1 && row <= 2 * n + 1)
                {
                    brt1++;
                    brs1 -= 2;
                    Console.WriteLine("{0}{1}{0}", new string('.', brt1), new string('#', brs1));
                }
            }
        }

        /// <summary>
        /// 7 Mai 2017 zada4a-5
        /// </summary>
        static void Korona()
        {
            int n = int.Parse(Console.ReadLine());
            int inter = (2 * n - 1 - 9) / 2 + 2;
            int brt = 0;
            int brts = -1;
            for (int row = 1; row <= n / 2 + 4; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("@{0}@{0}@", new string(' ', (2 * n - 4) / 2));
                }
                if (row == 2)
                {
                    Console.WriteLine("**{0}*{0}**", new string(' ', (2 * n - 6) / 2));
                }
                if (row > 2 && row <= n / 2)
                {
                    brt++;
                    inter -= 2;
                    brts += 2;
                    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', brt), new string(' ', inter), new string('.', brts));
                }
                if (row == n / 2 + 1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*", new string('.', n / 2 - 1), new string('.', 2 * n - 1 - 4 - 2 * (n / 2 - 1)));
                foreach (var ke in k.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {ke.Key}-> {ke.Value}");
                }
                if (row == n / 2 + 2)
                {
                    Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', (n - 4) / 2));
                }
                if (row == n / 2 + 3 || row == n / 2 + 4)
                {
                    Console.WriteLine("{0}", new string('*', 2 * n - 1));
                }
            }
        }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void Re4niciZada4a9()
        {
            Dictionary<string, int> dic1 = new Dictionary<string, int>();
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            //new DayOfWeek().PrintDayOfWeek(Console.ReadLine());
            var vhod = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            string input = Console.ReadLine();

        /// <summary>
        /// 
        /// </summary>
        static void PQSUCHEN19Mart2017morn()
        {
            int n = int.Parse(Console.ReadLine());
            int maimun = 2 * n - 3;
            int brt = 1;
            int brtd = 2 * n / 2;
            int brint = -1;
            for (int row = 1; row <= 2 * n + 1; row++)
            {
                if (row == 1 || row == 2 * n + 1)
                {
                    Console.WriteLine(new string('*', 2 * n + 1));
                }
                if (row == 2)
                {
                    Console.WriteLine(".*{0}*.", new string(' ', 2 * n - 3));
                }
                if (row > 2 && row <= n)
                {
                    maimun -= 2;
                    brt++;
                    Console.WriteLine("{0}*{1}*{0}", new string('.', brt), new string('@', maimun));
                }
                if (row == n + 1)
                {
                    Console.WriteLine("{0}*{0}", new string('.', n));
                }
                if (row > n + 1 && row < 2 * n)
                {
                    brtd--;
                    brint++;
                    Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', brtd), new string(' ', brint));

                }
                if (row == 2 * n)
                {
                    Console.WriteLine(".*{0}*.", new string('@', 2 * n - 3));
                }

            }

        }
        /// <summary>
        /// 
        /// </summary>
        static void SHAPKA18Mart2017()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = (12 * n) / 2;
            int brz = -3;
            int brtd = -1;
            int brzd = (12 * n - 6) / 2;

                input = Console.ReadLine();
            }

            dic1["fragments"] = 0;
            dic1["shards"] = 0;
            dic1["motes"] = 0;
            bool ima = false;

            string zaglavie = string.Empty;
            for (int i = 1; i <= vhod.Count - 1; i += 2)
            {
                if (vhod[i] == "fragments" || vhod[i] == "shards" || vhod[i] == "motes")
                {
                    //if (!dic1.ContainsKey(vhod[i]))
                    //{
                    //    dic1.Add(vhod[i].ToLower(), int.Parse(vhod[i - 1]));
                    //}
                    //else
                    //{
                    dic1[vhod[i].ToLower()] += int.Parse(vhod[i - 1]);
                    //}
                    if (dic1.ContainsKey("fragments") && dic1["fragments"] > 250)
                    {
                        zaglavie = "Valanyr obtained!";
                        dic1["fragments"] -= 250;
                        ima = true;
                    }
                    else if (dic1.ContainsKey("shards") && dic1["shards"] > 250)
                    {
                        if (ima == true)
                        {
                            continue;
                        }
                        else
                        {
                            ima = true;
                        }
                        zaglavie = "Shadowmourne obtained!";
                        dic1["shards"] -= 250;

                    }
                    Console.WriteLine();
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void RAKETA20november2016zad5()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = (3 * n - 2) / 2 + 1;
            int inter = -2;
            int brtd = n / 2 + 1;
            int brzd = 2 * n - 4;
            for (int row = 1; row <= 3 * n + 1 + n / 2; row++)
            {
                if (row >= 1 && row <= n)
                {
                    brt--;
                    inter += 2;
                    Console.WriteLine("{0}/{1}\\{0}", new string('.', brt), new string(' ', inter));
                }
                if (row == n + 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));
                }
                if (row > n + 1 && row <= 3 * n + 1)
                {
                    Console.WriteLine("{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
                }
                if (row > 3 * n + 1)
                {

                    brtd--;
                    brzd += 2;
                    Console.WriteLine("{0}/{1}\\{0}", new string('.', brtd), new string('*', brzd));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Lisica20Novemb2016Zad5()
        {
            int n = int.Parse(Console.ReadLine());
            int brz = 0;
            int brtir = 2 * n + 1;
            int brz1 = (n - 1) / 2 - 1;
            int brz2 = n + 2;
            int brzd = 0;
            int brtird = 2 * n + 1;
            for (int row = 1; row <= 2 * n + (n) / 3; row++)
            {
                if (row >= 1 && row <= n)
                {
                    brz++;
                    brtir -= 2;
                    Console.WriteLine("{0}\\{1}/{0}", new string('*', brz), new string('-', brtir));
                }
                if (row >= n + 1 && row <= n + n / 3)
                {
                    brz1++;
                    brz2 -= 2;
                    Console.WriteLine("|{0}\\{1}/{0}|", new string('*', brz1), new string('*', brz2));
                }
                if (row > n + n / 3)
                {

                    brzd++;
                    brtird -= 2;
                    Console.WriteLine("{0}\\{1}/{0}", new string('-', brzd), new string('*', brtird));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void SASO()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char ch = '\u00AF';
            char ch2 = (char)175;

            string mnogoGorniCherti = new string(ch, 10);
            string s2 = "";

            string s3 = string.Format($"");

            Console.WriteLine($"{mnogoGorniCherti}");

            Zadacha5Bradva();
        }

        private static void Zadacha5Bradva()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = -1;
            int brt1 = 3 * n + 1;
            int brt2 = n - 3;
            int brt3 = n;
            if (n % 2 == 1)
            {
                Chetno(n - 1, ref brt, ref brt1, ref brt2, ref brt3);
            }
            else
            {
                Chetno(n, ref brt, ref brt1, ref brt2, ref brt3);
            }
        }

        private static void Chetno(int n, ref int brt, ref int brt1, ref int brt2, ref int brt3)
        {
            for (int row = 1; row <= 2 * n; row++)
            {
                if (row >= 1 && row <= n)
                {
                    brt++;
                    Console.WriteLine("{0}*{1}*{2}", new string('-', 3 * n), new string('-', brt), new string('-', (2 * n) - 2 - brt));
                }
                if (row > n && row <= (2 * n - 1) - (n - 1) / 2)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('*', 3 * n), new string('-', n - 1), new string('-', n - 1));
                }
                if (row > (2 * n - 1) - (n - 1) / 2 && row <= 2 * n)
                {
                    brt1--;
                    brt2 += 2;
                    brt3--;
                    if (row < 2 * n)
                    {
                        Console.WriteLine("{0}*{1}*{2}", new string('-', brt1), new string('-', brt2), new string('-', brt3));
                    }
                    if (row == 2 * n)
                    {
                        Console.WriteLine("{0}*{1}*{2}", new string('-', brt1), new string('*', brt2), new string('-', brt3));
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Diamand17iuli2016Zad5()
        {

            int n = int.Parse(Console.ReadLine());
            int brt = n;
            int brtz = 3 * n - 2;
            int dbrt = 0;
            int dbrtz = 5 * n - 2;
            for (int row = 1; row <= 3 * n + 2; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));
                }
                if (row > 1 && row <= n)
                {
                    brt--;
                    brtz += 2;
                    Console.WriteLine("{0}*{1}*{0}", new string('.', brt), new string('.', brtz), new string('.', brt));
                }
                if (row == n + 1)
                {
                    Console.WriteLine(new string('*', 5 * n));
                    else if (dic1.ContainsKey("motes") && dic1["motes"] > 250)
                    {
                        if (ima == true)
                        {
                            continue;
                        }
                        else
                        {
                            ima = true;
                        }
                        zaglavie = "Dragonwrath obtained!";
                        dic1["motes"] -= 250;
                    }
                }
                if (row > n + 1 && row <= 3 * n + 1)
                {
                    dbrt++;
                    dbrtz -= 2;

                    Console.WriteLine("{0}*{1}*{0}", new string('.', dbrt), new string('.', dbrtz), new string('.', dbrt));

                }
                if (row == 3 * n + 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2), new string('.', 2 * n + 1));
                }

            }
        }

        static void Peperuda()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= 2 * (n - 2) + 1; row++)
            {
                if (row % 2 == 1 && row < n - 1)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', n - 2));
                }
                if (row % 2 == 0 && row < n - 1)

                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', n - 2));
                }
                else if (row == n)

                {
                    Console.WriteLine("{0}@{0}", new string(' ', n - 1));
                }

                if (row % 2 == 1 && row > n - 1)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', n - 2));
                }
                if (row % 2 == 0 && row > n - 1)

                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', n - 2));
                }

            }

        }

        static void Mart2016Zad5()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                if (row != 1 && row != n)
                {
                    Console.WriteLine("|" + new string(' ', (2 * n) - 2) + "|");
                }
                if (row == 1 && n % 2 == 0)
                {
                    int brCh = (n - 2) / 2 + 1;
                    int brTir = (n - 2) / 2 - 1;
                    Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', brCh), new string('_', brTir * 2));
                }
                if (row == 1 && n % 2 == 1)
                {
                    int brCh = (n - 3) / 2 + 1;
                    int brTir = (n - 3) / 2;
                    Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', brCh), new string('_', brTir * 2));
                }
                if (row == n && n % 2 == 0)
                {
                    int brCh = (n - 2) / 2 + 1;
                    int brTir = (n - 2) / 2 - 1;
                    Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', brCh), new string('\u00AF', brTir * 2));
                }
                if (row == n && n % 2 == 1)
                {

                    int brCh = (n - 3) / 2 + 1;
                    int brTir = (n - 3) / 2;
                    Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', brCh), new string('\u00AF', brTir * 2));

                }

            }
        }

        static void Sasooooo()
        {
            double num1 = 1.2321321321;

            double num = Math.Round(num1, 2);


            for (int i = 0; i < 120; i++)
            {
                char c = (char)i;
                Console.WriteLine($"number:  {i} - symbol:  {c}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void IzpitMart2016Zad4()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int nomerChislo = 1; nomerChislo <= n; nomerChislo++)
            {
                int cOP = int.Parse(Console.ReadLine());
                if (cOP < 200)
                {
                    p1++;
                }
                if (cOP >= 200 && cOP <= 399)
                {
                    p2++;
                }
                if (cOP >= 400 && cOP <= 599)
                {
                    p3++;
                }
                if (cOP >= 600 && cOP <= 799)
                {
                    p4++;
                }
                if (cOP >= 800 && cOP <= 1000)
                {
                    p5++;
                }
            }

            Console.WriteLine("{0:0.00}%", p1 / n * 100);
            Console.WriteLine("{0:0.00}%", p2 / n * 100);
            Console.WriteLine("{0:0.00}%", p3 / n * 100);
            Console.WriteLine("{0:0.00}%", p4 / n * 100);
            Console.WriteLine("{0:0.00}%", p5 / n * 100);
        }

        static void Mart2016zad2()
        {
            int n = int.Parse(Console.ReadLine());
            string vreme = Console.ReadLine();
            if (n < 20 && vreme == "day")
            {
                Console.WriteLine((double)(0.7 + n * 0.79));
            }
            if (n < 20 && vreme == "night")
            {
                Console.WriteLine((double)(0.7 + n * 0.9));
            }
            if (n >= 20 && n < 100)
            {
                Console.WriteLine((double)(n * 0.09));
            }
            if (n >= 100)
            {
                Console.WriteLine((double)(n * 0.06));
            }
        }

        static void Mart2016ZadEdno()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            int biuraNaRed = (int)((h - 1) / 0.7);
            int broiReda = (int)(w / 1.2);

            int res = biuraNaRed * broiReda - 3;

            Console.WriteLine(res);
        }
        /// <summary>
        /// STRINGOVE
        /// </summary>
        static void Vajno()
        {
            int num1 = int.Parse(Console.ReadLine());

            string s1 = string.Format("dsadsadsa {0} dsadsa {1}}", 1, 1);
            string s2 = "432432432";
            string s3 = "dsadsa" + s2 + s1 + "dsadsa";
            string s4 = string.Format("{0}{1}{2}{3}", "dsadsa", s2, s1, "dsadsa");
            string s5 = $"{"dsadsa"}{s2}{s1}{"dsadsa"}";
            char ch = s5[0];

            string nums = Console.ReadLine();
            int evenCount = nums.Length / 2 + nums.Length % 2;

            int sum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += int.Parse(nums[i].ToString());
            }
            Console.WriteLine($"{evenCount} {sum}");
        }

        /// <summary>
        /// izpit
        /// </summary>
        static void Zadacha1()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int r = 0;
            if (b > 2 && b < 4)
            {
                r = a + c;
                if (r % 3 < 1)
                {
                    Console.WriteLine(" R se deli na 3:");
                    Console.WriteLine(r / 3);
                    Console.WriteLine(r);
                }
                if (r % 3 > 0 && r % 3 < 2)
                {
                    Console.WriteLine(" Ostatuka ot R e 1");
                    Console.WriteLine(r);
                }
                if (r % 3 > 1)
                {
                    Console.WriteLine(" Ostatuka ot R e 2");
                    Console.WriteLine(r);
                }
            }
            if (b > 5 && b < 7)
            {
                r = a * c;
                if (r % 3 < 1)
                {
                    Console.WriteLine("R se deli na 3:");
                    Console.WriteLine(r / 3);
                    Console.WriteLine(r);
                }
                if (r % 3 > 0 && r % 3 < 2)
                {
                    Console.WriteLine(" Ostatuka ot R e 1");
                    Console.WriteLine(r);
                }
                if (r % 3 > 1)
                {
                    Console.WriteLine(" Ostatuka ot R e 2");
                    Console.WriteLine(r);
                }
            }
            if (b > 8 && b < 10)
            {
                r = a % c;
                if (r % 3 < 1)
                {
                    Console.WriteLine(" R se deli na 3:");
                    Console.WriteLine(r / 3);
                    Console.WriteLine(r);
                }
                if (r % 3 > 0 && r % 3 < 2)
                {
                    Console.WriteLine(" Ostatuka ot R e 1");
                    Console.WriteLine(r);
                }
                if (r % 3 > 1)
                {
                    Console.WriteLine(" Ostatuka ot R e 2");
                    Console.WriteLine(r);
                }
            }
        }

        /// <summary>
        /// Greshno!!!!!!!!!!!
        /// </summary>
        static void TriugulniOchila()
        {
            int briZvezdichki = 0;
            for (int row = 1; row <= 5; row++)
            {

                string broiIntervali = new string(' ', (5 - briZvezdichki) / 2);
                int mBrIntervali = 2 * ((5 - briZvezdichki) / 2) + 5 - 2;

                Console.WriteLine(broiIntervali + new string('*', briZvezdichki) + new string(' ', mBrIntervali) + new string('*', briZvezdichki) + broiIntervali);

                if (row <= (5 - 1) / 2)
                {
                    briZvezdichki += 2;

                }
                else if (row >= (5 - 1) / 2)
                {
                    briZvezdichki -= 2;
                }

                else
                {
                    Console.WriteLine(new string('*', 5) + new string('-', 5 - 2) + new string('*', 5));
                }
            }
        }


        /// <summary>
        /// Risuvane na romb sus zvezdichki.
        /// </summary>
        static void Romb()
        {
            int n = int.Parse(Console.ReadLine());
            int starCount = 1;
            for (int row = 1; row <= n; row++)
            {
                string emptySpace = new string(' ', (n - starCount) / 2);

                Console.WriteLine(emptySpace + new string('*', starCount) + emptySpace);
                if (row <= n / 2)
                {
                    starCount += 2;
                }
                else
                {
                    starCount -= 2;
                }
            }
        }

            }



        /// <summary>
        /// 
        /// </summary>
        static void KvadratPrazen()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    if (row > 1 && row < 5 && col > 1 && col < 5)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }




        /// <summary>
        /// 
        /// </summary>
        static void TriugVrDoloDqsno()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col <= n - row)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }

        }











        /// <summary>
        /// 
        /// </summary>
        static void Batman()
        {



            Console.WriteLine("             i");
            Console.WriteLine("             ii");
            Console.WriteLine("             ii");
            Console.WriteLine("            iii");
            Console.WriteLine("            iiii");
            Console.WriteLine("           iiiiii                             i ");
            Console.WriteLine("         i iiiii                           ::  ");
            Console.WriteLine("          iiiiiiii                           :: ");
            Console.WriteLine("          iiiiiiii                 /iiiiiiiiiiiiii,,,                 ");
            Console.WriteLine("          iiiiiiii| @       /iiiiiiiiiiiiiiiiiiiiiiiiiiiii");
            Console.WriteLine("        i iiiiiiiii|    /iiiiiiiiiiiiiiiiiiii            iiii ");
            Console.WriteLine("        i iiiiiiiiiii /iiiiiiiiiiiiiiiiiii ^^^^^^^^^^ | ");
            Console.WriteLine("       i  iiiii  iiiiiiiiiiiiiiiiiiiiiiii^^^^^^^^ ^ ^ ^");
            Console.WriteLine("       i  iiiiii    ^ ^ ^ ^^^^^^ ^ ^ ^ ^  ^ ^ ^ ^ ^   ^  ^  ^");
            Console.WriteLine("       i  iiiiiii  ^^^^^^^^ ^ ^ ^ ^ ^ ^ ^  ^  ^  ^  ^   ^   ^");
            Console.WriteLine("      /i  iiiiiiiii");
            Console.WriteLine("    /ii   11111111i");
            Console.WriteLine("     /i    iiiiiiiii");
            Console.WriteLine("     /i      iiiiiiiii");
            Console.WriteLine("    /i     iiiiiiiiiiiiiiii   ");
            Console.WriteLine("    /ii   iiiiiiiiiiiiiiiii");
            Console.WriteLine("  //      iiiiiiiiiiiiiiiiiii");
            Console.WriteLine("  //      iiiiiiiiiiiiiiiiiii");
            Console.WriteLine("  //      iiiiiiiiii");
            Console.WriteLine("  ///     iiiiiiiiiiiii");
            Console.WriteLine("  ///     iiiiiiiiiiiiiiiiiiiiiiiiii                   i    ");
            Console.WriteLine("   //   iiiiiiiiiiiiiiiiiiiiiiiiiii                     ii ");
            Console.WriteLine("    /    iiiiiiiiiiiiiiiiiiiiiiiiii                      ii                    iiiiiiii  ");
            Console.WriteLine("   //     i      iiiiiiiiiiiiiiiiiii                   iii    iiii          iii        iii");
            Console.WriteLine("   //      i       iiiiiiiiiiiiiiiiii                 iiiiiiiiiiii     /iiiii      iiiii    ");
            Console.WriteLine("    //      ii             iiiiiiiiii               iiiiiiiiiiiiiiiiiii           iiiii");
            Console.WriteLine("    //       |             `   iiiiiiiiiiii         iiiiiiiiii                  iii");
            Console.WriteLine("     ///    i                 i ``  iiiiiiiii       iiiiiii                     iii");
            Console.WriteLine("     ///   iiii         __=====i===iiiiiiiiiiii       iiiii===1=====__      iiii");
            Console.WriteLine("    //    iiiiiii__iiii                                               ii__iii");
            Console.WriteLine("    // /iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
            Console.WriteLine("    //    iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii    iiiiiiiiiiiiiiiiiiii");
            Console.WriteLine("   ///      iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii/                 iiiiiii");
            Console.WriteLine("   ///      iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii/                       ii");
            Console.WriteLine("   ii         iiiiiiiiiiiiiiiiiiiiiiiiii/iiiiiii| ");
            Console.WriteLine("   ii        ,iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii| ");
            Console.WriteLine("    ii   ================iiiiiiiiiiii/iiiiiiiiii|            ==  iiiiiiiii====///////");
            Console.WriteLine("    ii      i,                      / iiiiiiiiii|          ===i");
            Console.WriteLine("    ii        i,                 /    iiiiiiiiii|          i");
            Console.WriteLine("    ii         i               /         iiiiiii|      i");
            Console.WriteLine("               i              /              iii|  i");
            Console.WriteLine("               /       ");
            Console.WriteLine("              i       ");
            Console.WriteLine("              i       ");
            Console.WriteLine("              i         ");
            Console.WriteLine("              i         <<</// =================    ///////////_______      ");
            Console.WriteLine("              i,       <<<====--------============ ///////////////////________");
            Console.WriteLine("               i_                 ");
            Console.WriteLine("                 i,        ");
            Console.WriteLine("                  i  ");
            Console.WriteLine("                   i       ");
            Console.WriteLine("                    i__,    ");
            Console.WriteLine("                       i       ");
            Console.WriteLine("                        i,  ");
            Console.WriteLine("                          i,    ");
            Console.WriteLine("                            i===================");








        }


        /// <summary>
        /// 
        /// </summary>
        static void Re4niciZada4a8()
        {
            SortedDictionary<string, SortedDictionary<string, int>> potrebitel = new SortedDictionary<string, SortedDictionary<string, int>>();


            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    duljinaNaRedica = 1;
                    purvoChislo = i + 1;
                }
                else
                {
                    duljinaNaRedica++;

                }
                if (duljinaNaRedica > naiDulgaRedica)
                {
                    naiDulgaRedica = duljinaNaRedica;
                    novoPurvoChislo = purvoChislo;
                }
            }

            for (int i = novoPurvoChislo; i < naiDulgaRedica + novoPurvoChislo; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// namirane na pyrvite n chlena ot redicata na Fibonaci
        /// </summary>
        static void FibonaciSequence()
        {
            int n = int.Parse(Console.ReadLine());

            int pyrvoChislo = 0;
            int vtoroChislo = 1;

            if (n == 1)
            {
                Console.WriteLine(pyrvoChislo);
            }
            if (n == 2)
            {
                Console.WriteLine(pyrvoChislo);
                Console.WriteLine(vtoroChislo);
            }
            else if (n > 2)
            {
                Console.WriteLine(pyrvoChislo);
                Console.WriteLine(vtoroChislo);

                for (int i = 0; i < n - 2; i++)
                {
                    int sledvashtoChislo = pyrvoChislo + vtoroChislo;

                    Console.WriteLine(sledvashtoChislo);

                    pyrvoChislo = vtoroChislo;
                    vtoroChislo = sledvashtoChislo;
                }
            }
        }

        /// <summary>
        /// Maksimalna redica ot posledovatelni ednakvi elementi v masiv
        /// </summary>
        static void Glava7zadacha4()
        {
            int[] array = new int[] { 1, 1, 3, 3, 3, 3, 3, 6, 6, 7, 7, 7, 7, 7, 7, 7 };
            int startIndex = 0, length = 1;
            int bestStartIndex = 0, bestLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[startIndex])
                {
                    startIndex = i;
                    length = 1;
                }
                else
                {
                    length++;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStartIndex = startIndex;
                }
            }

            for (int i = bestStartIndex; i < bestStartIndex + bestLength; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


        //######################################################

        
        /// <summary>
        /// Preobladava6ti ednakvi elementi v masiv  Zada4a 6
        /// </summary>
        static void MasiviUPRZada4a6()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int broi4 = 1;
            int maxBroi4 = 0;
            int chislo = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (!potrebitel.ContainsKey(vhod[1]))
                {
                    potrebitel.Add(vhod[1], new SortedDictionary<string, int>());
                    potrebitel[vhod[1]].Add(vhod[0], int.Parse(vhod[2]));
                }
                else
                {
                    if (potrebitel[vhod[1]].ContainsKey(vhod[0]))
                    {
                        chislo = potrebitel[vhod[1]][vhod[0]];
                        potrebitel[vhod[1]][vhod[0]] = chislo + int.Parse(vhod[2]);
                    }
                    else
                    {
                        potrebitel[vhod[1]].Add(vhod[0], int.Parse(vhod[2]));
                    }

                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, int>> p in potrebitel)
            {
                Console.Write("{0}: {1} ", p.Key, p.Value.Sum(x => x.Value));
                Console.Write("[");

                string s = string.Empty;
                foreach (var d in p.Value)
                {
                    s += string.Format("{0}, ", d.Key);
                    //Console.Write("{0}, ", d.Key);
                }
                s = s.Remove(s.Length - 2);
                Console.Write(s);
                Console.WriteLine("]");

            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void Re4niciZada7a7()
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();


            while (input != "report")
            {
                var vhod = input
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string city = vhod[0];
                string country = vhod[1];
                long pop = long.Parse(vhod[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, pop);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, pop);
                    }
                }
                input = Console.ReadLine();

            }

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()}");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}:{city.Value}");
                }
            }
        }
        /// <summary>
        //
        /// </summary>
        static void DictionaryZada4a6()
        {
            SortedDictionary<string, Dictionary<string, int>> dic = new SortedDictionary<string, Dictionary<string, int>>();

            do
            {

                var vhod = Console.ReadLine()
                    .Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (vhod[0] == "end")
                {
                    break;
                }
                vhod.RemoveAt(0);
                vhod.RemoveAt(1);
                vhod.RemoveAt(1);
                vhod.RemoveAt(1);
                int broi = 1;
                if (!dic.ContainsKey(vhod[1]))
                {
                    //dic[vhod[1]][vhod[0]] = broi;
                    dic.Add(vhod[1], new Dictionary<string, int>());
                }
                if (dic.ContainsKey(vhod[1]))
                {
                    if (dic[vhod[1]].ContainsKey(vhod[0]))
                    {
                        dic[vhod[1]][vhod[0]] = ++broi;
                    }
                    else
                    {
                        broi = 1;
                        //dic[vhod[1]].Add(vhod[0].ToString(),(int)broi);
                        dic[vhod[1]][vhod[0]] = broi;
                    }
                }

            } while (true);

            foreach (var d in dic)
            {
                Console.WriteLine("{0}:", d.Key);

                string output = "";
                foreach (var item in d.Value)
                {
                    output += $"{item.Key} => {item.Value}, ";
                }
                output.Remove(output.Length - 2);
                Console.WriteLine(output + ".");
            }
            // Console.Write("{0}: {1}", pii.Key, pii.Value.Sum(x => x.Value));
        }

        private static void DictionaryZadacha5HandsOfCards()
        {
            Dictionary<string, Dictionary<string, int>> peopleToCards = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (input != "JOKER")
            {
                var vhod = input
                  .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

                if (!peopleToCards.ContainsKey(vhod[0]))
                {
                    peopleToCards.Add(vhod[0], new Dictionary<string, int>());

                }

                int sum = 0;

                for (int i = 1; i < vhod.Count; i++)
                {
                    if (!peopleToCards[vhod[0]].ContainsKey(vhod[i]))
                    {
                        int multiplier = 1;
                        switch (vhod[i][vhod[i].Length - 1])
                        {
                            case 'S':
                                multiplier = 4;
                                break;
                            case 'H':
                                multiplier = 3;
                                break;
                            case 'D':
                                multiplier = 2;
                                break;
                            case 'C':
                                multiplier = 1;
                                break;
                            default:
                                break;
                        }

            Console.WriteLine(sum);
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    8
        /// </summary>
        static void ChetnaNe4etnaSuma()
        {
            int n = int.Parse(Console.ReadLine());
            int chetni = 0;
            int ne4etni = 0;
            for (int i = 1; i <= n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    ne4etni += chislo;
                }
                if (i % 2 == 0)
                {
                    chetni += chislo;
                }
            }
            if (chetni == ne4etni)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", chetni);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(chetni - ne4etni));
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    7
        /// </summary>
        static void LqvaIDqsnaSuma()
        {
            int suma1 = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                suma1 = suma1 + chislo;
            }
            int suma2 = 0;
            for (int k = 0; k < n; k++)
            {
                int chislo1 = int.Parse(Console.ReadLine());
                suma2 = suma2 + chislo1;
            }
            if (Math.Abs(suma1 - suma2) == 0)
            {
                Console.WriteLine("Yes, sum = {0}", suma1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(suma1 - suma2));
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    6
        /// </summary>
        static void NaiMalko4islo()
        {
            int n = int.Parse(Console.ReadLine());
            int naiMalko4islo = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo < naiMalko4islo)
                {
                    naiMalko4islo = chislo;
                }
            }
            Console.WriteLine(naiMalko4islo);
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    5
        /// </summary>
        static void NaiGolqmoChislo()
        {
            int n = int.Parse(Console.ReadLine());
            int naiGolqmo4islo = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo > naiGolqmo4islo)
                {
                    naiGolqmo4islo = chislo;
                }
            }
            Console.WriteLine(naiGolqmo4islo);
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    4
        /// </summary>
        static void SumiraneNa4isla()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                sum = sum + chislo;
            }
            Console.WriteLine(sum);
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    3
        /// </summary>
        static void Vsi4kiLatinskiBukvi()
        {
            for (char i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    2
        /// </summary>
        static void ChislataDo1000Zavu6va6tiNa7()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    1
        /// </summary>
        static void ChislataOt1Do100()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }


        /// <summary>
        /// Po-slojni logi4eski proverki Zada4a   14
        /// </summary>
        static void To4kaVuvFigurata()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x == h && y >= h && y <= h * 4) || (x == 2 * h && y >= h && y <= 4 * h)
                || (y == 4 * h && x >= h && x <= 2 * h) || (y == 0 && x >= 0 && x <= 3 * h)
                || (y == h && x >= 0 && x <= h) || (y == h && x >= 2 * h && x <= 3 * h)
                || (x == 0 && y >= 0 && y <= h) || (x == 3 * h && y >= 0 && y <= h))
            {
                Console.WriteLine("border");
            }
            else if ((x > h && x < 2 * h && y > 0 && y < 4 * h) || (x > 0 && x < 3 * h && y > 0 && y < h))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }

        /// <summary>
        ///  Po-slojni logi4eski proverki Zada4a   13
        /// </summary>
        static void Voleibol()
        {
            string godina = Console.ReadLine();
            int broiPraznici = int.Parse(Console.ReadLine());
            int broiUikendiRG = int.Parse(Console.ReadLine());

            int uikendiVSf = 48 - broiUikendiRG;
            double igriVSF = 3 / 4d * uikendiVSf + 2 / 3d * broiPraznici;
            double ob6toIgri = igriVSF + broiUikendiRG;

            if (godina == "leap")
            {
                Console.WriteLine("{0}", Math.Floor(ob6toIgri + 15 / 100d * ob6toIgri));
            }
            if (godina == "normal")
            {
                Console.WriteLine("{0}", Math.Floor(ob6toIgri));
            }
        }

        /// <summary>
        /// Po-slojni logi4eski proverki Zada4a   12
        /// </summary>
        static void Kino()
        {
            string tipProjekciq = Console.ReadLine();
            int broiRedove = int.Parse(Console.ReadLine());
            int broiColoni = int.Parse(Console.ReadLine());

            if (tipProjekciq == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", broiRedove * broiColoni * 12.00m);
            }
            if (tipProjekciq == "Normal")
            {
                Console.WriteLine("{0:f2} leva", broiRedove * broiColoni * 7.50m);
            }
            if (tipProjekciq == "Discount")
            {
                Console.WriteLine("{0:f2} leva", broiRedove * broiColoni * 5m);
            }
        }

        /// <summary>
        /// Po-slojni logi4eski proverki Zada4a   11
        /// </summary>
        static void KLasJivotno()
        {
            string jivotno = Console.ReadLine();

            switch (jivotno)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":

                case "tortoise":

                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }

        /// <summary>
        /// Po-slojni logi4eski proverki Zada4a   10
        /// </summary>
        static void DenOtSedmicata()
        {
            int den = int.Parse(Console.ReadLine());

            switch (den)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;


                default:
                    Console.WriteLine("error");
                    break;
            }

        }

        /// <summary>
        /// Po-slojni logi4eski proverki Zada4a   9
        /// </summary>
        static void TurgovskiKomisionni()
        {
            string grad = Console.ReadLine();
            decimal obemProdajbi = decimal.Parse(Console.ReadLine());

            if (grad == "Sofia")
            {
                if (obemProdajbi >= 0 && obemProdajbi <= 500)
                {
                    Console.WriteLine("{0:f2}", 5 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 500 && obemProdajbi <= 1000)
                {
                    Console.WriteLine("{0:f2}", 7 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                {
                    Console.WriteLine("{0:f2}", 8 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 10000)
                {
                    Console.WriteLine("{0:f2}", 12 / 100m * obemProdajbi);
                }
            }
            if (grad == "Varna")
            {

                if (obemProdajbi >= 0 && obemProdajbi <= 500)
                {
                    Console.WriteLine("{0:f2}", 4.5m / 100 * obemProdajbi);
                }
                if (obemProdajbi > 500 && obemProdajbi <= 1000)
                {
                    Console.WriteLine("{0:f2}", 7.5m / 100 * obemProdajbi);
                }
                if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                {
                    Console.WriteLine("{0:f2}", 10 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 10000)
                {
                    Console.WriteLine("{0:f2}", 13 / 100m * obemProdajbi);
                }
            }
            if (grad == "Plovdiv")
            {

                if (obemProdajbi >= 0 && obemProdajbi <= 500)
                {
                    Console.WriteLine("{0:f2}", 5.5m / 100 * obemProdajbi);
                }
                if (obemProdajbi > 500 && obemProdajbi <= 1000)
                {
                    Console.WriteLine("{0:f2}", 8 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                {
                    Console.WriteLine("{0:f2}", 12 / 100m * obemProdajbi);
                }
                if (obemProdajbi > 10000)
                {
                    Console.WriteLine("{0:f2}", 14.5m / 100 * obemProdajbi);
                }
            }
            if ((grad != "Sofia" && grad != "Varna" && grad != "Plovdiv") || obemProdajbi < 0)
            {
                Console.WriteLine("error");
            }

        }

        /// <summary>
        /// Po-slojni logi4eski proverki  Zada4a  8
        /// </summary>
        static void MagazinZaPlodove()
        {
            string plod = Console.ReadLine();
            string denOtsedmicata = Console.ReadLine();
            decimal koli4estvo = decimal.Parse(Console.ReadLine());

            if (denOtsedmicata == "Monday" || denOtsedmicata == "Tuesday" || denOtsedmicata == "Wednesday"
                || denOtsedmicata == "Thursday" || denOtsedmicata == "Friday")
            {

                if (plod == "banana")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 2.5m);
                }
                else if (plod == "apple")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 1.2m);
                }
                else if (plod == "orange")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 0.85m);
                }
                else if (plod == "grapefruit")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 1.45m);
                }
                else if (plod == "kiwi")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 2.7m);
                }
                else if (plod == "pineapple")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 5.5m);
                }
                else if (plod == "grapes")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 3.85m);
                }

            }
            if (denOtsedmicata == "Saturday" || denOtsedmicata == "Sunday")
            {

                        peopleToCards[vhod[0]].Add(vhod[i], sum);
                    }

                }


                input = Console.ReadLine();
            }
            foreach (var pii in peopleToCards)
            {
                Console.Write("{0}: {1}", pii.Key, pii.Value.Sum(x => x.Value));
                Console.WriteLine();
            }
        }
    }
}