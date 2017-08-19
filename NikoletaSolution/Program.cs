using System;

namespace NikoletaSolution
{
    class Progra
    {
        static void Main()
        {
            char s = (char)65;
            int a = (int)65.3;
            double d = (double)a;

            Console.WriteLine(s);
            Console.WriteLine((int)s);
            Console.WriteLine(d);
            Console.WriteLine(a);


            //DeleneBezOstatuk();


            decimal bitcoini = decimal.Parse(Console.ReadLine());  
            decimal kitai = decimal.Parse(Console.ReadLine());
            decimal komisionna = decimal.Parse(Console.ReadLine());

            decimal vsKitai = kitai * 0.15m * 1.76m;
            decimal vsBitkoini = bitcoini * 1168m;
            decimal ob6to = vsKitai + vsBitkoini;
            decimal vEvro = ob6to / 1.95m;
            decimal pkomisionna = komisionna / 100m * vEvro;
            decimal par = vEvro - pkomisionna;
            Console.WriteLine("{0:f2}", par);

        }


        /// <summary>
        /// 24 April 2016   Zada4a   6
        /// </summary>
        static void Specialni4isla()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                if (n % i == 0)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        if (n % k == 0)
                        {
                            for (int l = 1; l <= 9; l++)
                            {
                                if (n % l == 0)
                                {
                                    for (int m = 1; m <= 9; m++)
                                    {
                                        if (n % m == 0)
                                        {
                                            Console.Write("{0}{1}{2}{3} ", i, k, l, m);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 24 April 2016   Zada4a   4
        /// </summary>
        static void UmnataLili()
        {
            int godini = int.Parse(Console.ReadLine());
            decimal cenaPeralnq = decimal.Parse(Console.ReadLine());
            int cenaIgra4ka = int.Parse(Console.ReadLine());

            int pari1 = 0;
            int brIgra4ki = 0;
            int pari = 0;

            for (int i = 1; i <= godini; i++)
            {
                if (i % 2 == 0)
                {
                    pari += 10;
                    pari1 = pari1 + pari - 1;

                }
                if (i % 2 == 1)
                {
                    brIgra4ki++;
                }
            }
            int pariIgra4ki = brIgra4ki * cenaIgra4ka;
            decimal ob6toPari = pariIgra4ki + pari1;

            if (cenaPeralnq <= ob6toPari)
            {
                Console.WriteLine("Yes! {0:f2}", ob6toPari - cenaPeralnq);
            }
            if (cenaPeralnq > ob6toPari)
            {
                Console.WriteLine("No! {0:f2}", cenaPeralnq - ob6toPari);
            }
        }

        /// <summary>
        /// 24 April 2016   Zada4a  2
        /// </summary>
        static void PospalivataKotka()
        {
            int n = int.Parse(Console.ReadLine());
            int igraVRabotniDni = (365 - n) * 63;
            int igraVPo4ibniDni = n * 127;
            int ob6toIgra = igraVPo4ibniDni + igraVRabotniDni;
            int razlikaOtNormata = 0;
            if (ob6toIgra > 30000)
            {
                razlikaOtNormata = ob6toIgra - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", razlikaOtNormata / 60, razlikaOtNormata % 60);
            }
            if (ob6toIgra <= 30000)
            {
                razlikaOtNormata = 30000 - ob6toIgra;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", razlikaOtNormata / 60, razlikaOtNormata % 60);
            }
        }

        /// <summary>
        /// 24 April 2016  Zada4a   1
        /// </summary>
        static void RemontNaPlo4ki()
        {
            double duljinaPlo6tadka = double.Parse(Console.ReadLine());
            double shirinaPlo4ka = double.Parse(Console.ReadLine());
            double duljinaPlo4ka = double.Parse(Console.ReadLine());
            double shirinaPeika = double.Parse(Console.ReadLine());
            double duljinaPeika = double.Parse(Console.ReadLine());

            double sPlo6tadka = duljinaPlo6tadka * duljinaPlo6tadka;
            double sPlo4ka = shirinaPlo4ka * duljinaPlo4ka;
            double sPeika = shirinaPeika * duljinaPeika;

            double broiPlo4ki = (sPlo6tadka - sPeika) / sPlo4ka;
            double vreme = broiPlo4ki * 0.2;
            Console.WriteLine("{0:f2}", broiPlo4ki);
            Console.WriteLine("{0:f2}", vreme);
        }

        /// <summary>
        /// 26 Mart 2016   Zad  6
        /// </summary>
        static void Magi4eski4isla()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            for (int p = 1; p <= 9; p++)
                            {
                                for (int r = 1; r <= 9; r++)
                                {
                                    if (i * k * l * m * p * r == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", i, k, l, m, p, r);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 26 Mart 2016   Zada4a 4
        /// </summary>
        static void DeleneBezOstatuk()
        {
            int n = int.Parse(Console.ReadLine());

            int br2 = 0;
            int br3 = 0;
            int br4 = 0;

            for (int i = 0; i < n; i++)
            {

                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    br2++;
                }
                if (a % 3 == 0)
                {
                    br3++;
                }
                if (a % 4 == 0)
                {
                    br4++;
                }

            }
            Console.WriteLine("{0:f2}%", (double)br2 / (double)n * 100);
            Console.WriteLine("{0:f2}%", (double)br3 / (double)n * 100);
            Console.WriteLine("{0:f2}%", (double)br4 / (double)n * 100);
        }

        /// <summary>
        /// 6 Mart 2016   Zada4a   6
        /// </summary>
        static void TupiParoli()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int k = 1; k <= n; k++)
            {
                for (int m = 1; m <= n; m++)
                {
                    for (int i = 97; i < l + 97; i++)
                    {
                        for (int j = 97; j < l + 97; j++)
                        {
                            for (int r = 1; r <= n; r++)
                            {
                                if (r > k && r > m)
                                {
                                    Console.Write($"{k}{m}{(char)(i)}{(char)(j)}{r} ");
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 26 Mart 2016   Zada4a   2
        /// </summary>
        static void TrubiVBasein()
        {
            int obemBasein = int.Parse(Console.ReadLine());
            int limitTraba1 = int.Parse(Console.ReadLine());
            int limitTraba2 = int.Parse(Console.ReadLine());
            double chasove = double.Parse(Console.ReadLine());

            double pulnenetr1 = limitTraba1 * chasove;
            double pulneneTr2 = limitTraba2 * chasove;
            double pulnene = pulnenetr1 + pulneneTr2;
            if (pulnene <= obemBasein)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", (int)(pulnene / obemBasein * 100), (int)(pulnenetr1 / pulnene * 100), (int)(pulneneTr2 / pulnene * 100));
            }
            if (pulnene > obemBasein)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.", chasove, pulnene - obemBasein);
            }
        }

        /// <summary>
        /// 26 Mart 2016   Zada4a   1
        /// </summary>
        static void Zelen4ukovaBorsa()
        {
            decimal cenaZelen4uci = decimal.Parse(Console.ReadLine());
            decimal cenaPlodove = decimal.Parse(Console.ReadLine());
            int kiloZelen4uci = int.Parse(Console.ReadLine());
            int kiloPlodove = int.Parse(Console.ReadLine());
            decimal ob6taCena = cenaZelen4uci * kiloZelen4uci + cenaPlodove * kiloPlodove;
            decimal cenaVEvro = ob6taCena / 1.94m;
            Console.WriteLine(cenaVEvro);
        }

        /// <summary>
        ///  6 Mart 2016  Zada4a 4
        /// </summary>
        static void M()
        {
            int n = int.Parse(Console.ReadLine());

            double pod200 = 0;
            double ot200do399 = 0;
            double ot400do599 = 0;
            double ot600do799 = 0;
            double ot800 = 0;

            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());


                if (a < 200)
                {
                    pod200++;
                }
                if (a >= 200 && a < 400)
                {
                    ot200do399++;
                }
                if (a >= 400 && a < 600)
                {
                    ot400do599++;
                }
                if (a >= 600 && a < 800)
                {
                    ot600do799++;
                }
                if (a >= 800)
                {
                    ot800++;
                }
            }
            Console.WriteLine("{0:f2}%", pod200 / n * 100);
            Console.WriteLine("{0:f2}%", ot200do399 / n * 100);
            Console.WriteLine("{0:f2}%", ot400do599 / n * 100);
            Console.WriteLine("{0:f2}%", ot600do799 / n * 100);
            Console.WriteLine("{0:f2}%", ot800 / n * 100);

        }
        /// <summary>
        /// Mart 2016 zada4a 2
        /// </summary>
        static void Zada4a2()
        {
            int n = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            decimal naiEvtinTransport = Decimal.MaxValue;

            if (day == "day")
            {
                if (n >= 20 && n < 100)
                {
                    naiEvtinTransport = n * 0.09m;
                }
                if (n >= 100)
                {
                    naiEvtinTransport = n * 0.06m;
                }
                if (n < 20)
                {
                    naiEvtinTransport = 0.7m + n * 0.79m;
                }
            }
            if (day == "night")
            {
                if (n >= 20 && n < 100)
                {
                    naiEvtinTransport = n * 0.09m;
                }
                if (n >= 100)
                {
                    naiEvtinTransport = n * 0.06m;
                }
                if (n < 20)
                {
                    naiEvtinTransport = 0.7m + n * 0.9m;
                }
            }
            Console.WriteLine(naiEvtinTransport);

        }

        /// <summary>
        /// Mart 2016  Zada4a 1
        /// </summary>
        static void U4ebnaZala()
        {
            double duljina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());

            double brRedove = Math.Floor(duljina * 100 / 120);
            double brNaRed = Math.Floor((shirina * 100 - 100) / 70);
            Console.WriteLine(brNaRed * brRedove - 3);
        }
        /// <summary>
        /// 23 Iuli 2017   Zada4a   3
        /// </summary>
        static void FinalenKonkurs()
        {
            int broiTanciori = int.Parse(Console.ReadLine());
            decimal broiTo4ki = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            string mqsto = Console.ReadLine();

            decimal pariNagrada = 0;

            if (mqsto == "Bulgaria")
            {
                pariNagrada = broiTanciori * broiTo4ki;
                if (sezon == "summer")
                {
                    pariNagrada = pariNagrada - 0.05m * pariNagrada;
                }
                if (sezon == "winter")
                {
                    pariNagrada = pariNagrada - 0.08m * pariNagrada;
                }
            }
            if (mqsto == "Abroad")
            {
                pariNagrada = broiTanciori * broiTo4ki + 0.5m * (broiTanciori * broiTo4ki);
                if (sezon == "summer")
                {
                    pariNagrada = pariNagrada - 0.1m * pariNagrada;
                }
                if (sezon == "winter")
                {
                    pariNagrada = pariNagrada - 0.15m * pariNagrada;
                }

            }
            decimal blagotvor = 0.75m * pariNagrada;
            decimal pariNa4ovek = (pariNagrada - blagotvor) / broiTanciori;
            Console.WriteLine("Charity - {0:f2}", blagotvor);
            Console.WriteLine("Money per dancer - {0:f2}", pariNa4ovek);
        }

        /// <summary>
        /// 25 June 2017    Zada4a  3
        /// </summary>
        static void PlodoviKokteili()
        {
            string plod = Console.ReadLine();
            string razmer = Console.ReadLine();
            int brPitieta = int.Parse(Console.ReadLine());


            decimal cenaPitie = 0;
            if (razmer == "small")
            {
                if (plod == "Watermelon")
                {
                    cenaPitie = 2 * 56m;
                }
                if (plod == "Mango")
                {
                    cenaPitie = 2 * 36.66m;
                }
                if (plod == "Pineapple")
                {
                    cenaPitie = 2 * 42.10m;
                }
                if (plod == "Raspberry")
                {
                    cenaPitie = 2 * 20m;
                }
            }
            if (razmer == "big")
            {
                if (plod == "Watermelon")
                {
                    cenaPitie = 5 * 28.7m;
                }
                if (plod == "Mango")
                {
                    cenaPitie = 5 * 19.6m;
                }
                if (plod == "Pineapple")
                {
                    cenaPitie = 5 * 24.8m;
                }
                if (plod == "Raspberry")
                {
                    cenaPitie = 5 * 15.2m;
                }
            }
            decimal cenaVs = cenaPitie * brPitieta;
            if (cenaVs >= 400 && cenaVs <= 1000)
            {
                cenaVs = cenaVs - 0.15m * cenaVs;
            }
            if (cenaVs > 1000)
            {
                cenaVs = cenaVs - 0.5m * cenaVs;
            }

            Console.WriteLine("{0:f2} lv.", cenaVs);

        }

        /// <summary>
        /// 7 May 2017    Zada4a   3
        /// </summary>
        static void SchoolCamp()
        {
            string sezon = Console.ReadLine();
            string vidGrupa = Console.ReadLine();
            int broiU4enici = int.Parse(Console.ReadLine());
            int broiNo6tuvki = int.Parse(Console.ReadLine());

            decimal cenaNo6tuvki = 0;
            string vidSport = "aa";

            if (sezon == "Winter")
            {

                if (vidGrupa == "girls" || vidGrupa == "boys")
                {
                    if (vidGrupa == "girls")
                    {
                        Console.Write("Gymnastics");
                    }
                    if (vidGrupa == "boys")
                    {
                        Console.Write("Judo");
                    }
                    cenaNo6tuvki = broiNo6tuvki * 9.6m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }

                }
                else if (vidGrupa == "mixed")
                {
                    Console.Write("Ski");
                    cenaNo6tuvki = broiNo6tuvki * 10m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }
                }
                Console.WriteLine(" {0:f2} lv.", cenaNo6tuvki);
            }
            if (sezon == "Spring")
            {
                if (vidGrupa == "girls" || vidGrupa == "boys")
                {
                    if (vidGrupa == "girls")
                    {
                        Console.Write("Athletics");
                    }
                    if (vidGrupa == "boys")
                    {
                        Console.Write("Tennis");
                    }
                    cenaNo6tuvki = broiNo6tuvki * 7.20m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }
                }
                else if (vidGrupa == "mixed")
                {
                    Console.Write("Cycling");
                    cenaNo6tuvki = broiNo6tuvki * 9.50m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }
                }
                Console.WriteLine(" {0:f2} lv.", cenaNo6tuvki);
            }
            if (sezon == "Summer")
            {
                if (vidGrupa == "girls" || vidGrupa == "boys")
                {
                    if (vidGrupa == "girls")
                    {
                        Console.Write("Volleyball");
                    }
                    if (vidGrupa == "boys")
                    {
                        Console.Write("Football");
                    }
                    cenaNo6tuvki = broiNo6tuvki * 15m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }
                }
                else if (vidGrupa == "mixed")
                {
                    Console.Write("Swimming");
                    cenaNo6tuvki = broiNo6tuvki * 20m * broiU4enici;
                    if (broiU4enici >= 10 && broiU4enici < 20)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.05m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 20 && broiU4enici < 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.15m * cenaNo6tuvki;
                    }
                    if (broiU4enici >= 50)
                    {
                        cenaNo6tuvki = cenaNo6tuvki - 0.5m * cenaNo6tuvki;
                    }
                }
                Console.WriteLine(" {0:f2} lv.", cenaNo6tuvki);
            }
        }

        /// <summary>
        /// 19 March 2017 - Evening   Zada4a   3
        /// </summary>
        static void TruckDriver()
        {
            string sezon = Console.ReadLine();
            decimal kilometri = decimal.Parse(Console.ReadLine());

            decimal zaplata = 0;
            if (kilometri <= 5000)
            {
                if (sezon == "Spring" || sezon == "Autumn")
                {
                    zaplata = kilometri * 0.75m;
                }
                if (sezon == "Summer")
                {
                    zaplata = kilometri * 0.9m;
                }
                if (sezon == "Winter")
                {
                    zaplata = kilometri * 1.05m;
                }

            }
            if (kilometri > 5000 && kilometri <= 10000)
            {
                if (sezon == "Spring" || sezon == "Autumn")
                {
                    zaplata = kilometri * 0.95m;
                }
                if (sezon == "Summer")
                {
                    zaplata = kilometri * 1.1m;
                }
                if (sezon == "Winter")
                {
                    zaplata = kilometri * 1.25m;
                }
            }
            if (kilometri > 10000 && kilometri <= 20000)
            {
                zaplata = kilometri * 1.45m;
            }

            Console.WriteLine("{0:f2}", 4 * zaplata - 0.1m * zaplata * 4);
        }

        /// <summary>
        /// 19 Mart 2017 Morning   Zada4a 3
        /// </summary>
        static void Vacation()
        {
            decimal pari = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();


            if (pari <= 1000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine("Alaska - Camp - {0:f2}", 0.65m * pari);
                }
                if (sezon == "Winter")
                {
                    Console.WriteLine("Morocco - Camp - {0:f2}", 0.45m * pari);
                }
            }
            if (pari > 1000 && pari <= 3000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine("Alaska - Hut - {0:f2}", 0.8m * pari);
                }
                if (sezon == "Winter")
                {
                    Console.WriteLine("Morocco - Hut - {0:f2}", 0.6m * pari);
                }
            }
            if (pari > 3000)
            {
                if (sezon == "Summer")
                {
                    Console.WriteLine("Alaska - Hotel - {0:f2}", 0.9m * pari);
                }
                if (sezon == "Winter")
                {
                    Console.WriteLine("Morocco - Hotel - {0:f2}", 0.9m * pari);
                }
            }

        }

        /// <summary>
        /// 18 Mart 2016   Zada4a   3
        /// </summary>
        static void KolaPodNaem()
        {
            decimal pari = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();



            if (pari <= 100)
            {
                Console.WriteLine("Economy class");
                if (sezon == "Summer")
                {
                    Console.WriteLine("Cabrio - {0:f2}", 0.35m * pari);
                }
                if (sezon == "Winter")
                {
                    Console.WriteLine("Jeep - {0:f2}", 0.65m * pari);
                }

            }
            if (pari > 100 && pari <= 500)
            {
                Console.WriteLine("Compact class");
                if (sezon == "Summer")
                {
                    Console.WriteLine("Cabrio - {0:f2}", 0.45m * pari);
                }
                if (sezon == "Winter")
                {
                    Console.WriteLine("Jeep - {0:f2}", 0.8m * pari);
                }

            }
            if (pari > 500 && (sezon == "Summer" || sezon == "Winter"))
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine("Jeep - {0:f2}", 0.9m * pari);
            }

        }

        /// <summary>
        /// 18 Dekemvri  2016   Zada4a   3
        /// </summary>
        static void Flowers()
        {
            int broiHrizantemi = int.Parse(Console.ReadLine());
            int broiRozi = int.Parse(Console.ReadLine());
            int broiLaleta = int.Parse(Console.ReadLine());
            string mesec = Console.ReadLine();
            string praznikIliDelnik = Console.ReadLine();

            int broiCvetq = broiHrizantemi + broiRozi + broiLaleta;
            decimal cenaBuket = 0;

            if (praznikIliDelnik == "N")
            {
                if (mesec == "Spring" || mesec == "Summer")
                {
                    decimal cenaHrizantemi = 2.00m;
                    decimal cenaRozi = 4.10m;
                    decimal cenaLaleta = 2.50m;
                    cenaBuket = cenaHrizantemi * broiHrizantemi + cenaRozi * broiRozi + cenaLaleta * broiLaleta;
                    if (broiCvetq > 20)
                    {

                        cenaBuket = cenaBuket - 0.2m * cenaBuket;
                    }

                    if (mesec == "Spring" && broiLaleta > 7)
                    {
                        cenaBuket = cenaBuket - 0.05m * cenaBuket;
                    }
                }
                if (mesec == "Autumn" || mesec == "Winter")
                {
                    decimal cenaHrizantemi = 3.75m;
                    decimal cenaRozi = 4.50m;
                    decimal cenaLaleta = 4.15m;
                    cenaBuket = cenaHrizantemi * broiHrizantemi + cenaRozi * broiRozi + cenaLaleta * broiLaleta;
                    if (broiCvetq > 20)
                    {
                        cenaBuket = cenaBuket - 0.2m * cenaBuket;
                    }
                    if (mesec == "Winter" && broiRozi >= 10)
                    {
                        cenaBuket = cenaBuket - 0.1m * cenaBuket;
                    }
                }
                Console.WriteLine("{0:f2}", cenaBuket + 2);

            }
            if (praznikIliDelnik == "Y")
            {
                if (mesec == "Spring" || mesec == "Summer")
                {
                    decimal cenaHrizantemi = 2.00m;
                    decimal cenaRozi = 4.10m;
                    decimal cenaLaleta = 2.50m;
                    cenaBuket = cenaHrizantemi * broiHrizantemi + cenaRozi * broiRozi + cenaLaleta * broiLaleta;
                    cenaBuket = cenaBuket + 0.15m * cenaBuket;
                    if (broiCvetq > 20)
                    {

                        cenaBuket = cenaBuket - 0.2m * cenaBuket;
                    }

                    if (mesec == "Spring" && broiLaleta > 7)
                    {
                        cenaBuket = cenaBuket - 0.05m * cenaBuket;
                    }

                }
                if (mesec == "Autumn" || mesec == "Winter")
                {
                    decimal cenaHrizantemi = 3.75m;
                    decimal cenaRozi = 4.50m;
                    decimal cenaLaleta = 4.15m;
                    cenaBuket = cenaHrizantemi * broiHrizantemi + cenaRozi * broiRozi + cenaLaleta * broiLaleta;
                    cenaBuket = cenaBuket + 0.15m * cenaBuket;
                    if (broiCvetq > 20)
                    {
                        cenaBuket = cenaBuket - 0.2m * cenaBuket;
                    }
                    if (mesec == "Witer" && broiRozi >= 10)
                    {
                        cenaBuket = cenaBuket - 0.1m * cenaBuket;
                    }

                }
                Console.WriteLine("{0:f2}", cenaBuket + 2);
            }

        }


        /// <summary>
        /// 20 Noemvri 2016 Evening  Zada4a 3
        /// </summary>
        static void BikeRace()
        {
            int mlad6i = int.Parse(Console.ReadLine());
            int star6i = int.Parse(Console.ReadLine());
            string vidsustezanie = Console.ReadLine();

            int ob6toSustezateli = mlad6i + star6i;
            decimal ob6taSuma = 0;

            if (vidsustezanie == "trail")
            {
                ob6taSuma = mlad6i * 5.50m + star6i * 7m;
            }
            if (vidsustezanie == "cross-country")
            {
                ob6taSuma = mlad6i * 8m + star6i * 9.50m;
                if (ob6toSustezateli >= 50)
                {
                    ob6taSuma = ob6taSuma - 0.25m * ob6taSuma;
                }
                else if (ob6toSustezateli < 50)
                {
                    ob6taSuma = mlad6i * 8m + star6i * 9.50m;
                }
            }
            if (vidsustezanie == "downhill")
            {
                ob6taSuma = mlad6i * 12.25m + star6i * 13.75m;
            }
            if (vidsustezanie == "road")
            {
                ob6taSuma = mlad6i * 20m + star6i * 21.50m;
            }
            Console.WriteLine("{0:f2}", ob6taSuma - 0.05m * ob6taSuma);
        }

        /// <summary>
        /// 20 Noemvri 2016 Morning   zada4a  3
        /// </summary>
        static void Vacatio()
        {
            int vuzrastni = int.Parse(Console.ReadLine());
            int deca = int.Parse(Console.ReadLine());
            int brn = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            decimal obshtaSuma = 0;
            int obshtoHora = vuzrastni + deca;

            if (transport == "train")
            {
                obshtaSuma = 2 * (vuzrastni * 24.99m + deca * 14.99m);
                if (obshtoHora >= 50)
                {
                    obshtaSuma = obshtaSuma - 0.5m * obshtaSuma;
                }
            }
            if (transport == "bus")
            {

                obshtaSuma = 2 * (vuzrastni * 32.50m + deca * 28.50m);
            }
            if (transport == "boat")
            {
                obshtaSuma = 2 * (vuzrastni * 42.99m + deca * 39.99m);
            }
            if (transport == "airplane")
            {
                obshtaSuma = 2 * (vuzrastni * 70.00m + deca * 50.00m);
            }
            decimal hotel = brn * 82.99m;
            decimal comisionna = 0.1m * (brn * 82.99m + obshtaSuma);

            Console.WriteLine("{0:f2}", obshtaSuma + hotel + comisionna);
        }

        /// <summary>
        ///  28 Avgust  2016   Zada4a  3 
        /// </summary>
        static void HotelskaStaq()
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


