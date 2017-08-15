using System;

namespace NikoletaSolution
{
    class Progra
    {
        static void Main()
        {
            string mesec = Console.ReadLine();
            int brNoshtuvki = int.Parse(Console.ReadLine());

            decimal cenaApartament = 0;
            decimal cenaStudio = 0;

            if (mesec == "May" || mesec == "October")
            {
                cenaApartament = 65;
                cenaStudio = 50;
                if (brNoshtuvki > 7 && brNoshtuvki <= 14)
                {
                    cenaStudio = 50 - 0.05m * 50;
                }
                if (brNoshtuvki > 14)
                {
                    cenaStudio = cenaStudio - 0.3m * cenaStudio;
                    cenaApartament = cenaApartament - 0.1m * cenaApartament;
                }
            }
            if (mesec == "June" || mesec == "September")
            {
                cenaApartament = 68.70m;
                cenaStudio = 75.20m;
                if (brNoshtuvki > 14)
                {
                    cenaStudio = 75.20m - 0.2m * 75.20m;
                    cenaApartament = 68.70m - 0.1m * 68.70m;
                }
            }
            if (mesec == "July" || mesec == "August")
            {
                cenaApartament = 77;
                cenaStudio = 76;
                if (brNoshtuvki > 14)
                {
                    cenaApartament = 77 - 0.1m * 77m;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", cenaApartament * brNoshtuvki);
            Console.WriteLine("Studio: {0:f2} lv.", cenaStudio * brNoshtuvki);
        }


        /// <summary>
        /// 17 Iuli 2016   ZAda4a   3
        /// </summary>
        static void BiletiZaMa4a()
        {
            decimal pari = decimal.Parse(Console.ReadLine());
            string kategoriq = Console.ReadLine();
            int brh = int.Parse(Console.ReadLine());
            decimal parizabileti = 0;
            decimal parizaput = 0;
            if (brh >= 1 && brh <= 4)
            {
                parizaput = 0.75m * pari;

            }
            if (brh >= 5 && brh <= 9)
            {
                parizaput = 0.6m * pari;
            }
            if (brh >= 10 && brh <= 24)
            {
                parizaput = 0.5m * pari;
            }
            if (brh >= 25 && brh <= 49)
            {
                parizaput = 0.4m * pari;
            }
            if (brh >= 50)
            {
                parizaput = 0.25m * pari;
            }
            if (kategoriq == "VIP")
            {
                parizabileti = brh * 499.99m;
            }
            if (kategoriq == "Normal")
            {
                parizabileti = brh * 249.99m;
            }
            if (pari > parizaput + parizabileti)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", pari - (parizaput + parizabileti));
            }
            if (pari < parizaput + parizabileti)
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (parizaput + parizabileti) - pari);
            }
        }

        /// <summary>
        /// 24 April 2016    Zada4a 3
        /// </summary>
        static void OperaciiMejduChisla()
        {
            double n = double.Parse(Console.ReadLine());
            double n1 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            if (n1 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n);
            }
            else if (oper == "+" || oper == "-" || oper == "*")
            {
                if (oper == "+")
                {
                    Console.Write("{0} + {1} = {2} ", n, n1, n + n1);
                    if ((n + n1) % 2 == 0)
                    {
                        Console.WriteLine("- even");
                    }
                    else
                    {
                        Console.WriteLine("- odd");
                    }

                }
                if (oper == "-")
                {
                    Console.Write("{0} - {1} = {2} ", n, n1, n - n1);
                    if ((n - n1) % 2 == 0)
                    {
                        Console.WriteLine("- even");
                    }
                    else
                    {
                        Console.WriteLine("- odd");
                    }

                }
                if (oper == "*")
                {
                    Console.Write("{0} * {1} = {2} ", n, n1, n * n1);
                    if ((n * n1) % 2 == 0)
                    {
                        Console.WriteLine("- even");
                    }
                    else
                    {
                        Console.WriteLine("- odd");
                    }


                }
            }
            else if (oper == "/")
            {

                Console.WriteLine("{0} / {1} = {2:f2} ", n, n1, n / n1);

            }
            else if (oper == "%")
            {

                Console.WriteLine("{0} % {1} = {2} ", n, n1, n % n1);
            }
        }


        /// <summary>
        /// 6 Mart 2016   Zada4a 3
        /// </summary>
        static void NiVremeZaIzpit()
        {
            int chiz = int.Parse(Console.ReadLine());
            int miniz = int.Parse(Console.ReadLine());
            int chpr = int.Parse(Console.ReadLine());
            int minpr = int.Parse(Console.ReadLine());



            int ciz = chiz * 60 + miniz;
            int cpr = chpr * 60 + minpr;
            int rmin = 0;
            if (ciz >= cpr && ciz - cpr <= 30)
            {
                rmin = ciz - cpr;
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", rmin);

            }
            if (ciz > cpr && ciz == cpr || ciz - cpr > 30)
            {
                rmin = ciz - cpr;

                if (rmin < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", rmin);
                }
                if (rmin >= 60)
                {
                    if (rmin % 60 < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:0{1} hours before the start", rmin / 60, rmin % 60);
                    }
                    if (rmin % 60 >= 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1} hours before the start", rmin / 60, rmin % 60);
                    }
                }

            }
            if (cpr > ciz)
            {
                rmin = cpr - ciz;
                if (rmin < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", rmin);
                }
                if (rmin >= 60)
                {
                    if (rmin % 60 < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:0{1} hours after the start", rmin / 60, rmin % 60);
                    }
                    if (rmin % 60 >= 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine("{0}:{1} hours after the start", rmin / 60, rmin % 60);
                    }
                }
            }
        }

        /// <summary>
        /// 26 Mart 2016 zada4a 3
        /// </summary>
        static void Puteshestvie()
        {
            decimal pari = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string mqsto = "am";
            string hot = "ba";
            decimal cena = 0;
            if (sezon == "summer")
            {
                if (pari <= 100)
                {
                    mqsto = "Bulgaria";
                    hot = "Camp";
                    cena = pari * 0.3m;
                }
                if (pari > 100 && pari <= 1000)
                {
                    mqsto = "Balkans";
                    hot = "Camp";
                    cena = pari * 0.4m;
                }
            }
            if (sezon == "winter")
            {
                if (pari <= 100)
                {
                    mqsto = "Bulgaria";
                    hot = "Hotel";
                    cena = pari * 0.7m;
                }
                if (pari > 100 && pari <= 1000)
                {
                    mqsto = "Balkans";
                    hot = "Hotel";
                    cena = pari * 0.8m;
                }
            }
            if (pari > 1000)
            {
                mqsto = "Europe";
                hot = "Hotel";
                cena = pari * 0.9m;
            }
            Console.WriteLine("Somewhere in {0}", mqsto);
            Console.Write("{0}", hot);
            Console.Write(" - ");
            Console.WriteLine("{0:f2}", cena);

        }

        /// <summary>
        /// 4as + 15 minuti    Zada4a   15
        /// </summary>
        static void Logi4Proverki()
        {
            int ch = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int nmin = 0;

            if (min + 15 > 60 && ch < 23)
            {
                ch++;
                nmin = min + 15 - 60;
                if (nmin < 10)
                {
                    Console.WriteLine("{0}:0{1}", ch, nmin);
                }
                if (nmin >= 10)
                {
                    Console.WriteLine("{0}:{1}", ch, nmin);
                }
            }
            if (min + 15 == 60 && ch < 23)
            {
                ch++;
                Console.WriteLine("{0}:00", ch);
            }
            if (min + 15 < 60 && ch <= 23)
            {
                Console.WriteLine("{0}:{1}", ch, min + 15);
            }
            if (ch == 23 && min + 15 > 60)
            {
                ch = 0;
                nmin = min + 15 - 60;
                if (nmin < 10)
                {
                    Console.WriteLine("0:0{1}", ch, nmin);
                }
                if (nmin >= 10)
                {
                    Console.WriteLine("0:{1}", ch, nmin);
                }
            }
            if (ch == 23 && min == 45)
            {
                Console.WriteLine("0:00");
            }
        }

        /// <summary>
        /// 4islata ot 0 do 100 s dumi      zada4a 17*
        /// </summary>
        static void ProstiLogi4Presmqtaniq()
        {
            int m = int.Parse(Console.ReadLine());
            if (m > 20 && m < 100)
            {
                int k = m / 10;
                if (k == 2)
                {
                    Console.Write("twenty");
                }
                if (k == 3)
                {
                    Console.Write("thirty");
                }
                if (k == 4)
                {
                    Console.Write("forty");
                }
                if (k == 5)
                {
                    Console.Write("fifty");
                }
                if (k == 6)
                {
                    Console.Write("sixty");
                }
                if (k == 7)
                {
                    Console.Write("seventy");
                }
                if (k == 8)
                {
                    Console.Write("eighty");
                }
                if (k == 9)
                {
                    Console.Write("ninety");
                }
                int l = m % 10;
                if (l == 1)
                {
                    Console.WriteLine(" one");
                }
                if (l == 2)
                {
                    Console.WriteLine(" two");
                }
                if (l == 3)
                {
                    Console.WriteLine(" three");
                }
                if (l == 4)
                {
                    Console.WriteLine(" four");
                }
                if (l == 5)
                {
                    Console.WriteLine(" five");
                }
                if (l == 6)
                {
                    Console.WriteLine(" six");
                }
                if (l == 7)
                {
                    Console.WriteLine(" seven");
                }
                if (l == 8)
                {
                    Console.WriteLine(" eight");
                }
                if (l == 9)
                {
                    Console.WriteLine(" nine");
                }

            }
            else if (m <= 20)
            {
                if (m == 1)
                {
                    Console.WriteLine("one");
                }
                if (m == 2)
                {
                    Console.WriteLine("two");
                }
                if (m == 3)
                {
                    Console.WriteLine("three");
                }
                if (m == 4)
                {
                    Console.WriteLine("four");
                }
                if (m == 5)
                {
                    Console.WriteLine("five");
                }
                if (m == 6)
                {
                    Console.WriteLine("six");
                }
                if (m == 7)
                {
                    Console.WriteLine("seven");
                }
                if (m == 8)
                {
                    Console.WriteLine("eight");
                }
                if (m == 9)
                {
                    Console.WriteLine("nine");
                }
                if (m == 10)
                {
                    Console.WriteLine("ten");
                }
                if (m == 11)
                {
                    Console.WriteLine("eleven");
                }
                if (m == 12)
                {
                    Console.WriteLine("twelve");
                }
                if (m == 13)
                {
                    Console.WriteLine("thirteen");
                }
                if (m == 14)
                {
                    Console.WriteLine("fourteen");
                }
                if (m == 15)
                {
                    Console.WriteLine("fifteen");
                }
                if (m == 16)
                {
                    Console.WriteLine("sixteen");
                }
                if (m == 17)
                {
                    Console.WriteLine("seventeen");
                }
                if (m == 18)
                {
                    Console.WriteLine("eighteen");
                }
                if (m == 19)
                {
                    Console.WriteLine("nineteen");
                }
                if (m == 20)
                {
                    Console.WriteLine("twenty");
                }
            }
            if (m == 100)
            {
                Console.WriteLine("one hundred");
            }
            if (m == 0)
            {
                Console.WriteLine("zero");
            }
            if (m < 0 || m > 100)
            {
                Console.WriteLine("invalid number");
            }
        }

        /// <summary>
        /// Ednakvi dumi  Zada4a 12
        /// </summary>
        static void ProstiLogi4eskiPresmqtamiq()
        {
            string word = Console.ReadLine();
            string word1 = Console.ReadLine();
            word = word.ToLower();
            word1 = word1.ToLower();
            if (word == word1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        /// <summary>
        /// Prosti Logi4eski Proverki Zada4a 9
        /// </summary>
        static void MerniEdinici()
        {
            float ch = float.Parse(Console.ReadLine());
            string ed = Console.ReadLine();
            string dv = Console.ReadLine();
            if (ed == "m")
            {
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch * 1.0936133);
                }
            }
            if (ed == "mm")
            {
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 1000 * 1.0936133);
                }
            }
            if (ed == "cm")
            {
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 1000);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 100 * 1.0936133);
                }
            }
            if (ed == "mi")
            {
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 100);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 0.000621371192 * 1.0936133);
                }
            }
            if (ed == "in")
            {
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 0.000621371192);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 39.3700787 * 1.0936133);
                }
            }
            if (ed == "km")
            {
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 39.3700787);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 0.001 * 1.0936133);
                }
            }
            if (ed == "ft")
            {
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 0.001);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399);
                }
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch / 3.2808399 * 1.0936133);
                }
            }
            if (ed == "yd")
            {
                if (dv == "yd")
                {
                    Console.WriteLine("{0:f8}", ch);
                }
                if (dv == "mm")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 1000);
                }
                if (dv == "cm")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 100);
                }
                if (dv == "mi")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 0.000621371192);
                }
                if (dv == "in")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 39.3700787);
                }
                if (dv == "km")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 0.001);
                }
                if (dv == "ft")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133 * 3.2808399);
                }
                if (dv == "m")
                {
                    Console.WriteLine("{0:f8}", ch / 1.0936133);
                }
            }
        }

        /// <summary>
        /// PROSTI PRESMQTANIQ   zada4a 13*
        /// </summary>
        static void MejduvalutenKonvertor()
        {
            double suma = double.Parse(Console.ReadLine());
            string vh = Console.ReadLine();
            string iz = Console.ReadLine();


            if (vh == "BGN")

            {
                if (iz == "USD")
                {
                    Console.WriteLine(Math.Round(suma / 1.79569, 2));
                }
                if (iz == "EUR")
                {
                    Console.WriteLine(Math.Round(suma / 1.95583, 2));
                }
                if (iz == "GBP")
                {
                    Console.WriteLine(Math.Round(suma / 2.53405, 2));
                }
            }
            if (vh == "USD")

            {
                if (iz == "BGN")
                {
                    Console.WriteLine(Math.Round(suma * 1.79569, 2));
                }
                if (iz == "EUR")
                {
                    Console.WriteLine(Math.Round(suma * 1.79549 / 1.95583, 2));
                }
                if (iz == "GBP")
                {
                    Console.WriteLine(Math.Round(suma * 1.79569 / 2.53405, 2));
                }
            }
            if (vh == "EUR")

            {
                if (iz == "USD")
                {
                    Console.WriteLine(Math.Round(suma * 1.95583 / 1.79569, 2));
                }
                if (iz == "BGN")
                {
                    Console.WriteLine(Math.Round(suma * 1.95583, 2));
                }
                if (iz == "GBP")
                {
                    Console.WriteLine(Math.Round(suma * 1.95583 / 2.53405, 2));
                }
            }
            if (vh == "GBP")

            {
                if (iz == "USD")
                {
                    Console.WriteLine(Math.Round(suma * 2.53405 / 1.79569, 2));
                }
                if (iz == "EUR")
                {
                    Console.WriteLine(Math.Round(suma * 2.53405 / 1.95583, 2));
                }
                if (iz == "BGN")
                {
                    Console.WriteLine(Math.Round(suma * 2.53405, 2));
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void RRR()
        {
            int n = int.Parse(Console.ReadLine());
            int brk = 0;
            if (n % 3 == 1)
            {
                for (int row = 1; row <= ((n + n / 2) * n) / 3; row++)
                {
                    brk++;
                    Console.Write('#');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                    brk++;
                    Console.Write('.');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                    brk++;
                    Console.Write('.');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                }
            }
            if (n % 3 == 0)
            {
                for (int row = 1; row <= ((n + n / 2) * n) / 3; row++)
                {
                    brk++;
                    Console.Write('#');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                    brk++;
                    Console.Write('.');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                    brk++;
                    Console.Write('.');
                    if (brk == n)
                    {
                        Console.WriteLine();
                        brk = 0;
                    }
                }
            }
        }


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


        /// <summary>
        /// 19 Mart 2017 - ve4er   ZADA4A-5
        /// </summary>
        static void Paralelepiped()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = 2 * n + 1;
            int brtl = -1;
            int brtd = -1;
            int brts = 2 * n + 1;

            for (int row = 1; row <= 4 * n + 4; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("+{0}+{1}", new string('~', n - 2), new string('.', 2 * n + 1));
                }
                if (row >= 2 && row <= 2 * n + 2)
                {
                    brt--;
                    brtl++;
                    Console.WriteLine("|{0}\\{1}\\{2}", new string('.', brtl), new string('~', n - 2), new string('.', brt));
                }
                if (row > 2 * n + 2 && row <= 4 * n + 3)
                {
                    brtd++;
                    brts--;
                    Console.WriteLine("{0}\\{1}|{2}|", new string('.', brtd), new string('.', brts), new string('~', n - 2));
                }
                if (row == 4 * n + 4)
                {
                    Console.WriteLine("{0}+{1}+", new string('.', 2 * n + 1), new string('~', n - 2));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void Zad6est19Mart2017sutrin()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magChislo = int.Parse(Console.ReadLine());
            int brmag = 0;
            int combN = 0;
            int combbr = 0;
            bool toExit = false;
            for (int i = a; i >= b; i--)
            {
                for (int i1 = a; i1 >= b; i1--)
                {
                    combN++;
                    if (i + i1 == magChislo)
                    {
                        brmag++;
                        Console.WriteLine("Combination N:{0}", combN);
                        Console.WriteLine("({0} + {1} = {2})", i, i1, magChislo);
                        toExit = true;
                        break;
                    }
                    combbr++;
                    if (i == b && i1 == b)
                    {
                        Console.WriteLine("{0} combinations -neither equals{1} ", combbr, magChislo);

                        toExit = true;
                        break;
                    }
                }
                if (toExit)
                {
                    break;
                }
            }
        }


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

            for (int row = 1; row <= 4 * n - 2; row++)
            {
                if (row >= 1 && row < 2 * n)
                {
                    brt -= 3;
                    brz += 3;
                    Console.WriteLine("{0}{1}#{1}{0}", new string('.', brt), new string('#', brz));
                }
                if (row == 2 * n)
                {
                    Console.WriteLine(new string('#', 12 * n - 5));
                }
                if (row > 2 * n && row <= 3 * n - 2)
                {
                    brtd += 3;
                    brzd -= 3;
                    Console.WriteLine("|{0}{1}#{1}{0}.", new string('.', brtd), new string('#', brzd));
                }
                if (row > 3 * n - 2 && row < 4 * n - 2)
                {
                    Console.WriteLine("|{0}{1}#{1}{2}", new string('.', (12 * n - 12) / 4 - 1), new string('#', (12 * n - 12) / 4 + 3), new string('.', (12 * n - 12) / 4));
                }
                if (row == 4 * n - 2)
                {
                    Console.WriteLine("@{0}{1}#{1}{2}", new string('.', (12 * n - 12) / 4 - 1), new string('#', (12 * n - 12) / 4 + 3), new string('.', (12 * n - 12) / 4));
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        static void KOLEDNAshapka18Dec2016()
        {
            int n = int.Parse(Console.ReadLine());
            int brt = (4 * n - 2) / 2 + 1;
            int brtir = -1;
            char c = '\u02CD';

            for (int row = 1; row <= 4 * n - 1; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}/|\\{0}", new string('.', (4 * n - 2) / 2));
                }
                if (row == 2)
                {
                    Console.WriteLine("{0}\\|/{0}", new string('.', (4 * n - 2) / 2));
                }
                if (row > 2 && row <= 2 * n + 2)
                {
                    brt--;
                    brtir++;
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', brt), new string(c, brtir));
                }
                if (row == 2 * n + 3 || row == 2 * n + 5)
                {
                    Console.WriteLine(new string('*', 4 * n + 1));
                }
                if (row == 2 * n + 4)
                {
                    for (int col = 1; col <= 4 * n + 1; col++)
                    {
                        if (col % 2 == 1)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }

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

        static void Zadacha5Bradva()
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

        /// <summary>
        /// risuvane na kvadratni ochila na konzolata
        /// </summary>
        static void Ochila()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    Console.WriteLine(new string('*', n) + new string(' ', n - 2) + new string('*', n));
                }
                else if (row == n / 2 + 1)
                {
                    Console.WriteLine("*" + new string('-', n - 2) + "*" + new string('-', n - 2) + "*" + new string('-', n - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('-', n - 2) + "*" + new string(' ', n - 2) + "*" + new string('-', n - 2) + "*");
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
        static void TriugGoreDolo()
        {
            Console.WriteLine("Vuvedi chislo nechetno chislo.");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n / 2 + 1; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            for (int row = n / 2; row >= 1; row--)
            {
                for (int col = row; col >= 1; col--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pravougulen triugulnik s prav ugul v dolniq lqv ugul, zapylnen sys zvezdichki
        /// </summary>
        static void Triugulnik()
        {
            Console.WriteLine("Vuvedi chislo");

            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// /// Nai- dulga redica ot posledovatelni narastvashti elementi.
        /// </summary>
        static void glava7zadacha5()
        {
            int[] array = { 9, 7, 8, 9, 2, 2, 4 };
            int purvoChislo = 1; int duljinaNaRedica = 1;
            int novoPurvoChislo = 0; int naiDulgaRedica = 1;

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
    }
}


