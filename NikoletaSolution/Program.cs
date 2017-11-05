using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace NikoletaSolution
{
    class Program
    {
        static void Main()
        {

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

                foreach (var ke in k.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {ke.Key}-> {ke.Value}");
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

            while (input != string.Empty)
            {
                vhod.AddRange(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList());

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
                else
                {
                    if (!dic2.ContainsKey(vhod[i]))
                    {
                        dic2.Add(vhod[i].ToLower(), int.Parse(vhod[i - 1]));
                    }
                    //else
                    //{
                    //    dic2[vhod[i].ToLower()] += int.Parse(vhod[i - 1]);
                    //}
                }

            }


            Console.WriteLine("{0}", zaglavie);

            foreach (var item in dic1.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in dic2.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void Re4niciZada4a8()
        {
            SortedDictionary<string, SortedDictionary<string, int>> potrebitel = new SortedDictionary<string, SortedDictionary<string, int>>();


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

                        switch (vhod[i][0])
                        {
                            case 'J':
                                sum = multiplier * 11;
                                break;
                            case 'Q':
                                sum = multiplier * 12;
                                break;
                            case 'K':
                                sum = multiplier * 13;
                                break;
                            case 'A':
                                sum = multiplier * 14;
                                break;
                            default:
                                sum = multiplier * int.Parse(string.Join("", vhod[i].Take(vhod[i].Length - 1)));
                                break;
                        }
                        //Slav: 3H, 10S, JC, KD, 5S, 10S 6H, 7S, KC, KD, 5S, 10C
                        //Slav: 6H, 7S, KC, KD, 5S, 10C

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