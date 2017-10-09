using System;
using System.Collections.Generic;
using System.Linq;

namespace NikoletaSolution
{
    class Program
    {
        static void Main()
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
                for (int k = 0; k <= arr.Length - 1; k++)
                {
                    if (Math.Max(arr[i], arr[k]) - Math.Min(arr[k], arr[i]) == razlika)
                    {
                        broi++;
                        ima = true;
                        Console.WriteLine($"{arr[i]},{arr[k]}");
                    }
                }
            }

            Console.WriteLine(broi);
        }
        /// <summary>
        /// Nai mnogo ednakvi 4isla v masiv   Zad 8
        /// </summary>
        static void MasiviUPRZAd8()
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int broi = 1;
            int maxBroi = 0;
            int chislo = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int k = i; k >= 0; k--)
                {
                    if (i != k && (arr[i] == arr[k]))
                    {
                        broi++;

                    }

                }
                if (broi > maxBroi)
                {
                    maxBroi = broi;
                    chislo = arr[i];

                }
                broi = 1;
            }

            Console.WriteLine(chislo);
        }
        /// <summary>
        /// 
        /// </summary>
        static void Masiviii()
        {
            string ar1 = Console.ReadLine();
            string ar2 = Console.ReadLine();

            string[] arr1 = ar1.Split(' ');
            string[] arr2 = ar2.Split(' ');

            int[] a1 = new int[arr1.Length];
            int[] a2 = new int[arr2.Length];


            int poDulga = Math.Max(arr1.Length, arr2.Length);
            int poCusa = Math.Min(arr1.Length, arr2.Length);

            int sum = 0;

            for (int i = 0; i < poDulga; i++)
            {
                a1[i] = int.Parse(arr1[i]);
                a2[i] = int.Parse(arr2[i]);

                if (arr1.Length > arr2.Length)
                {
                    do
                    {
                        sum = a1[i] + a2[i];
                    } while (true);

                }

            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void MasiviZada4a6()
        {
            string input = Console.ReadLine();

            string[] strings = input.Split(' ');

            for (int i = strings.Length - 1; i >= 0; i--)
            {
                Console.Write(strings[i]);
                if (i != 0)
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        private static void MasiviZadacha5RoundingNums()
        {
            string chisla = Console.ReadLine();

            string[] nums = chisla.Split(' ');

            decimal[] arr = new decimal[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = decimal.Parse(nums[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => { Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }
        }

        private static void Masivizadacha4()
        {
            string chisla = Console.ReadLine();

            string[] nums = chisla.Split(' ');

            int[] arr = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            bool ima = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (arr[i] + arr[k] == arr[j])
                        {
                            ima = true;
                            Console.WriteLine("{0} + {1} == {2}", arr[i], arr[k], arr[j]);
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

                sustavka = sustavka.ToLower();

                if (sustavka == "cheese")
                {
                    calorii += 500;
                }
                else if (sustavka == "tomato sauce")
                {
                    calorii += 150;
                }

                else if (sustavka == "salami")
                {
                    calorii += 600;
                }
                else if (sustavka == "pepper")
                {
                    calorii += 50;
                }
                else
                {
                    calorii += 0;
                }
            }

            Console.WriteLine("Total calories: {0}", calorii);
        }
        static void Huuummmmm()
        {
            string sustavka = Console.ReadLine();

            char c = sustavka[sustavka.Length - 1];

            bool z = sustavka.EndsWith("sol");
        }

        static void RRR()
        {
            bool vesokosnaGodinaLiE = DateTime.IsLeapYear(2002);
            if (!vesokosnaGodinaLiE)
            {
                Console.WriteLine(DateTime.UtcNow);
                Console.WriteLine(DateTime.Now);

                DateTime datetime = DateTime.Now;

                Console.WriteLine(datetime.DayOfWeek);
                Console.WriteLine();
            }


            for (int i = 0; i < 10; i++)
            {

                // Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(12321321321);

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(12321321321);

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(12321321321);

                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(12321321321);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(12321321321);

            }



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

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    broi4++;
                    if (broi4 > maxBroi4)
                    {
                        maxBroi4 = broi4;
                        chislo = arr[i];
                    }

                }
                else
                {
                    broi4 = 1;
                }
            }
            for (int i = 0; i < maxBroi4; i++)
            {
                Console.Write(chislo);
                Console.Write(" ");
            }
        }

        /// <summary>
        ///  Namirane na vsi4ki prosti 4isla v interval     Zada4a   4
        /// </summary>
        static void MasiviUPRZada4a4()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i);
                    Console.WriteLine(" ");
                }
            }
        }

        /// <summary>
        /// 4islo razdelq6to masiv na dve polovini s ednakuv sbor na elementite  Zada4a 11
        /// </summary>
        static void MasiviUPRZada4a11()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFind = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    Console.WriteLine(i);
                    isFind = true;
                    break;
                }

            }
            if (isFind == false)
            {
                Console.WriteLine("no");
            }

        }
        /// <summary>
        /// Zavurtane i sumirane Zada4a   2
        /// </summary>
        static void MasiviUPRZada4a2()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotation = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int j = 0; j < rotation; j++)
            {


                int reminder = numbers[numbers.Length - 1];

                for (int i = numbers.Length - 1; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                    sum[i] += numbers[i];

                }
                numbers[0] = reminder;
                sum[0] += numbers[0];
            }
            Console.WriteLine($"{string.Join(" ", sum)}");
        }

        /// <summary>
        ///  Obru6tane na elementite Na krainite 4etvurti na masiv Zada4a  3
        /// </summary>
        static void MasiviUPRZada4a3()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] leftArr = numbers.Take(k).ToArray();
            int[] middleArr = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = middleArr[i] + leftArr[i];
                result[i + k] = middleArr[i + k] + rightArr[i];
            }
            Console.WriteLine($"{string.Join(" ", result)}");
        }

        /// <summary>
        /// Zada4a    1
        /// </summary>

        static void MasiviUPRZada4a1()
        {
            string[] firstArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondtArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = NamiraneNaMaxCommonItem(firstArr, secondtArr);

            Array.Reverse(firstArr);
            Array.Reverse(secondtArr);
            //secondtArr = secondtArr.Reverse().ToArray();

            int rightCount = NamiraneNaMaxCommonItem(firstArr, secondtArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");
        }

        private static int NamiraneNaMaxCommonItem(string[] firstArr, string[] secondtArr)
        {
            int duljina = Math.Min(firstArr.Length, secondtArr.Length);
            int count = 0;

            for (int i = 0; i < duljina; i++)
            {
                if (firstArr[i] == secondtArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }


        /// <summary>
        /// 
        /// </summary>
        static void Simetriq()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            bool symmetric = true;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k < n / 2; k++)
            {
                if (arr[k] != arr[n - k - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);
        }

        static void Obru6taneNaMasivVobratenRed()
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            int length = myArray.Length;

            int[] reversed = new int[length];

            for (int i = 0; i < length; i++)
            {
                reversed[length - i - 1] = myArray[i];
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }

        static void Zada4a6()
        {
            int kontrolnaStoinost = int.Parse(Console.ReadLine());

            int br4etvorki = 0;
            int edno = 0;
            int dve = 0;
            int tri = 0;
            int chet = 0;

            bool ima = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int m = 1; m <= 9; m++)
                        {
                            if (i < k && l > m && i * k + l * m == kontrolnaStoinost)
                            {
                                br4etvorki++;
                                Console.Write("{0}{1}{2}{3} ", i, k, l, m);
                                if (br4etvorki == 4)
                                {
                                    edno = i;
                                    dve = k;
                                    tri = l;
                                    chet = m;
                                    ima = true;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (ima == true)
            {
                Console.WriteLine("Password: {0}{1}{2}{3}", edno, dve, tri, chet);
            }
            if (br4etvorki < 4)
            {
                Console.WriteLine("No!");
            }
        }

        static void Zada4a5()
        {
            int n = int.Parse(Console.ReadLine());

            int brzvezdi4kig = n - 1;
            int brTo4kig = (n - 1) / 2 + 1;

            int brzd = n - 1;
            int brtd = (n - 1) / 2 + 1;

            for (int row = 1; row <= 2 * n + 8; row++)
            {
                if (row == 1 || row == 2 * n + 8)
                {
                    Console.WriteLine("{0}x{0}", new string('.', (3 * n - 1) / 2));
                }
                else if (row == 2 || row == n + 4)
                {
                    Console.WriteLine("{0}/x\\{0}", new string('.', (3 * n - 3) / 2));
                }
                else if (row == 3 || row == 2 * n + 6)
                {
                    Console.WriteLine("{0}x|x{0}", new string('.', (3 * n - 3) / 2));
                }
                else if (row == n + 5 || row == 2 * n + 7)
                {
                    Console.WriteLine("{0}\\x/{0}", new string('.', (3 * n - 3) / 2));
                }

                else if ((row >= 4 && row <= n / 2 + 4))
                {
                    brTo4kig--;
                    brzvezdi4kig++;
                    Console.WriteLine("{0}{1}|{1}{0}", new string('.', brTo4kig), new string('x', brzvezdi4kig));

                }
                else if ((row > n / 2 + 4 && row <= n + 3))
                {
                    brTo4kig++;
                    brzvezdi4kig--;
                    Console.WriteLine("{0}{1}|{1}{0}", new string('.', brTo4kig), new string('x', brzvezdi4kig));
                }
                else if ((row >= n + 5 && row <= n + n / 2 + 6))
                {
                    brtd--;
                    brzd++;
                    Console.WriteLine("{0}{1}|{1}{0}", new string('.', brtd), new string('x', brzd));
                }
                else if ((row > n + n / 2 + 6 && row <= 2 * n + 5))
                {
                    brtd++;
                    brzd--;
                    Console.WriteLine("{0}{1}|{1}{0}", new string('.', brtd), new string('x', brzd));
                }
            }
        }

        static void Zada4a4()
        {
            int broiDni = int.Parse(Console.ReadLine());

            double ob6toKoli4estvoRakiq = 0;
            double ob6toGradusi = 0;

            for (int i = 1; i <= broiDni; i++)
            {
                double koli4estvoRakiq = double.Parse(Console.ReadLine());
                double gradusRakiq = double.Parse(Console.ReadLine());

                ob6toKoli4estvoRakiq += koli4estvoRakiq;
                ob6toGradusi += koli4estvoRakiq * gradusRakiq;
            }
            Console.WriteLine("Liter: {0:f2}", ob6toKoli4estvoRakiq);
            Console.WriteLine("Degrees: {0:f2}", ob6toGradusi / ob6toKoli4estvoRakiq);

            if (ob6toGradusi / ob6toKoli4estvoRakiq < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (ob6toGradusi / ob6toKoli4estvoRakiq >= 38 && ob6toGradusi / ob6toKoli4estvoRakiq <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (ob6toGradusi / ob6toKoli4estvoRakiq > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }

        static void Zada4aaaaa3()
        {
            string srokNaDogovor = Console.ReadLine();
            string tipDogovor = Console.ReadLine();
            string dobavenInternet = Console.ReadLine();
            int broiMeseci = int.Parse(Console.ReadLine());

            decimal cenaNaMesec = 0;
            decimal ob6taCena = 0;

            if (tipDogovor == "Small")
            {
                if (srokNaDogovor == "one")
                {
                    cenaNaMesec = 9.98m;
                }
                if (srokNaDogovor == "two")
                {
                    cenaNaMesec = 8.58m;
                }
            }
            else if (tipDogovor == "Middle")
            {
                if (srokNaDogovor == "one")
                {
                    cenaNaMesec = 18.99m;
                }
                if (srokNaDogovor == "two")
                {
                    cenaNaMesec = 17.09m;
                }
            }
            else if (tipDogovor == "Large")
            {
                if (srokNaDogovor == "one")
                {
                    cenaNaMesec = 25.98m;
                }
                if (srokNaDogovor == "two")
                {
                    cenaNaMesec = 23.59m;
                }
            }
            else if (tipDogovor == "ExtraLarge")
            {
                if (srokNaDogovor == "one")
                {
                    cenaNaMesec = 35.99m;
                }
                if (srokNaDogovor == "two")
                {
                    cenaNaMesec = 31.79m;
                }
            }
            if (dobavenInternet == "yes")
            {
                if (cenaNaMesec <= 10)
                {
                    ob6taCena = cenaNaMesec + 5.5m;

                }
                else if (cenaNaMesec > 10 && cenaNaMesec <= 30)
                {
                    ob6taCena = cenaNaMesec + 4.35m;
                }
                else if (cenaNaMesec > 30)
                {
                    ob6taCena = cenaNaMesec + 3.85m;
                }
            }
            else
            {
                ob6taCena = cenaNaMesec;
            }
            if (srokNaDogovor == "two")
            {
                ob6taCena = ob6taCena - 3.75m / 100 * ob6taCena;
            }

            Console.WriteLine("{0:f2} lv.", ob6taCena * (decimal)broiMeseci);
        }

        static void Zada4aaa2()
        {
            double brat1 = double.Parse(Console.ReadLine());
            double brat2 = double.Parse(Console.ReadLine());
            double brat3 = double.Parse(Console.ReadLine());
            double vremeZaRibolov = double.Parse(Console.ReadLine());

            double ob6toVreme = 1d / (1d / brat1 + 1d / brat2 + 1d / brat3);
            double vremeSPo4ivka = ob6toVreme + 0.15d * ob6toVreme;
            Console.WriteLine("Cleaning time: {0:f2}", vremeSPo4ivka);

            if (vremeZaRibolov >= vremeSPo4ivka)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(vremeZaRibolov - vremeSPo4ivka));
            }
            else if (vremeSPo4ivka > vremeZaRibolov)
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Ceiling(vremeSPo4ivka - vremeZaRibolov));
            }
        }

        static void Zad1()
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirinaVSm = int.Parse(Console.ReadLine());
            int viso4inaVSm = int.Parse(Console.ReadLine());
            double procenti = double.Parse(Console.ReadLine());

            int obemAkvarium = duljina * shirinaVSm * viso4inaVSm;
            double ob6toLitri = (double)obemAkvarium * 0.001d;
            double procent = procenti * 0.01d;
            double neobhodimiLitri = ob6toLitri * (1d - procent);

            Console.WriteLine("{0:f3}", neobhodimiLitri);
        }
        /// <summary>
        /// STOP
        /// </summary>
        static void STOP()
        {
            int n = int.Parse(Console.ReadLine());

            int brt = n + 1;
            int brTir = 2 * n - 3;

            for (int row = 1; row <= 2 * n + 2; row++)
            {
                if (row == 1)
                {
                    Console.WriteLine("{0}__{1}__{0}", new string('.', brt), new string('_', brTir));
                    brt--;
                    brTir += 2;
                }
                if (row > 1 && row < n + 2)
                {
                    Console.WriteLine("{0}//{1}{2}{0}", new string('.', brt), new string('_', brTir), new string('\\', 2));
                    brt--;
                    brTir += 2;
                }
                if (row == n + 2)
                {
                    Console.WriteLine("{0}//{1}STOP!{1}{2}{0}", new string('.', brt), new string('_', (brTir - 5) / 2), new string('\\', 2));
                }

                if (row == n + 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("{0}{1}//", new string('\\', 2), new string('_', brTir));
                }

                if (row > n + 3 && row <= 2 * n + 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    brt++;
                    brTir -= 2;
                    Console.WriteLine("{0}{1}{2}//{0}", new string('.', brt), new string('\\', 2), new string('_', brTir));

                }
            }
        }
        /// <summary>
        /// 21 Fevruari 2016 Zada4a 1
        /// </summary>
        static void Garfild()
        {
            decimal pariD = decimal.Parse(Console.ReadLine());
            decimal kursNaD = decimal.Parse(Console.ReadLine());
            decimal cenaPicaLV = decimal.Parse(Console.ReadLine());
            decimal cenaLazanqLv = decimal.Parse(Console.ReadLine());
            decimal cenaSandvi4iLv = decimal.Parse(Console.ReadLine());
            decimal koli4estvoPica = decimal.Parse(Console.ReadLine());
            decimal koli4estvoLazanq = decimal.Parse(Console.ReadLine());
            decimal koli4estvoSandvi4i = decimal.Parse(Console.ReadLine());

            decimal neobhodimiPari = cenaPicaLV / kursNaD * koli4estvoPica + cenaLazanqLv / kursNaD * koli4estvoLazanq + cenaSandvi4iLv / kursNaD * koli4estvoSandvi4i;
            if (neobhodimiPari <= pariD)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", pariD - neobhodimiPari);
            }
            if (neobhodimiPari > pariD)
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", neobhodimiPari - pariD);
            }
        }
        /// <summary>
        /// 21 Fevruari 2016  Zada4a 2
        /// </summary>
        static void EncodedAnswers()
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            int bra = 0;
            int brb = 0;
            int brc = 0;
            int brd = 0;
            string bukvi = "";
            for (int i = 1; i <= n; i++)
            {
                long chislo = long.Parse(Console.ReadLine());
                if (chislo % 4 == 0)
                {
                    bukvi += "a ";
                    bra++;
                }
                if (chislo % 4 == 1)
                {
                    bukvi += "b ";
                    brb++;
                }
                if (chislo % 4 == 2)
                {
                    bukvi += "c ";
                    brc++;
                }
                if (chislo % 4 == 3)
                {
                    bukvi += "d ";
                    brd++;
                }

            }
            Console.WriteLine(bukvi);
            Console.WriteLine("Answer A: {0}", bra);
            Console.WriteLine("Answer B: {0}", brb);
            Console.WriteLine("Answer C: {0}", brc);
            Console.WriteLine("Answer D: {0}", brd);
        }
        /// <summary>
        /// Vlojeni cikli Zada4a 12               !!!!!!!!!!!!!!!!!!!!!!!!!!!
        /// </summary>
        static void TRYCATCH()
        {
            for (int i = 1; i <= int.MaxValue; i++)
            {
                string chislo = (Console.ReadLine());
                try
                {
                    int chislo1 = int.Parse(chislo);

                    if (chislo1 % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: {0}", chislo);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("catch");
                }
                finally
                {
                    Console.WriteLine("finally");
                }
                Console.WriteLine("Invalid number!");
            }
        }

        /// <summary>
        /// Vlojeni cikli Zada4a 11
        /// </summary>
        static void ProstoLiE4isloto()
        {
            int n = int.Parse(Console.ReadLine());
            bool prosto = false;
            if (n == 2)
            {
                prosto = true;
            }
            if (n == 3)
            {
                prosto = true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if ((n % i == 0 || n < 2) && n != 2)
                {
                    prosto = false;
                    break;
                }
                else if (n % i == 1)
                {

                    prosto = true;
                }
            }
            if (prosto == false)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }
        }
        /// <summary>
        /// Vlojeni cikli Zada4a 10
        /// </summary>
        static void SumiraneNaCifriNa4islo()
        {
            string n = Console.ReadLine();
            int chislo = int.Parse(n);
            int s = 0;
            int suma = 0;
            for (int i = 1; i <= n.Length; i++)
            {

                s = chislo % 10;
                suma += s;
                chislo = chislo / 10;
            }
            Console.WriteLine(suma);
        }
        /// <summary>
        /// Vlojeni cikli Zada4a 8
        /// </summary>
        static void NaiGolqmOb6tDelitel()
        {
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());
            int ostatuk = Math.Max(chislo1, chislo2) % Math.Min(chislo1, chislo2);

            for (int i = ostatuk; i >= 0; i--)
            {
                if (chislo1 == chislo2)
                {
                    Console.WriteLine(chislo1);
                    break;
                }
                chislo1 = chislo1 % chislo2;
                if (chislo1 == 0)
                {
                    Console.WriteLine(chislo2);
                    break;
                }
                chislo2 = chislo2 % chislo1;

                if (chislo2 == 0)
                {
                    Console.WriteLine(chislo1);
                    break;
                }

            }
        }
        /// <summary>
        /// 3 Septemvri 2017  zada4a   6
        /// </summary>
        static void Moneti()
        {
            int brMonetiPo1 = int.Parse(Console.ReadLine());
            int brM2 = int.Parse(Console.ReadLine());
            int brM5 = int.Parse(Console.ReadLine());
            int suma = int.Parse(Console.ReadLine());

            for (int i = 0; i <= brMonetiPo1; i++)
            {
                for (int k = 0; k <= brM2; k++)
                {
                    for (int l = 0; l <= brM5; l++)
                    {
                        if (i * 1 + k * 2 + l * 5 == suma)
                        {
                            Console.WriteLine("{0} * 1 lv. + {1} * 2 lv. + {2} * 5 lv. = {3} lv.", i, k, l, suma);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 3 Septemvri 2017  zada4a   4
        /// </summary>
        static void Torta()
        {
            int shirinaTorta = int.Parse(Console.ReadLine());
            int duljinaTorta = int.Parse(Console.ReadLine());

            int broiPar4eta = shirinaTorta * duljinaTorta;
            int teku6tBrP = 0;
            bool stop = false;
            bool k = false;

            for (int i = 1; i <= broiPar4eta; i++)
            {
                string brPar4eta = Console.ReadLine();

                //int brParchetaT;

                //bool stop = int.TryParse(Console.ReadLine(), out brParchetaT);

                if (brPar4eta == "STOP")
                {
                    stop = true;
                    break;
                }

                teku6tBrP += int.Parse(brPar4eta);
                if (teku6tBrP > broiPar4eta)
                {
                    k = true;
                    break;
                }

            }
            if (stop == true)
            {
                Console.WriteLine($"{broiPar4eta - teku6tBrP} pieces are left.");
            }
            else if (k == true)
            {
                Console.WriteLine($"No more cake left! You need {teku6tBrP - broiPar4eta} pieces more.");
            }
        }
        /// <summary>
        /// 3 Septemvri 2017  zada4a   3
        /// </summary>
        private static void FotoSnimka()
        {
            int brSnimki = int.Parse(Console.ReadLine());
            string razmer = Console.ReadLine();
            string na4inNaPoru4ka = Console.ReadLine();

            decimal cenaPoru4ka = 0;

            if (razmer == "9X13")
            {
                cenaPoru4ka = (decimal)brSnimki * 0.16m;
                if (brSnimki >= 50)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.05m * cenaPoru4ka;

                }

                if (na4inNaPoru4ka == "online")
                {
                    cenaPoru4ka = cenaPoru4ka - 0.02m * cenaPoru4ka;
                }
            }
            if (razmer == "10X15")
            {
                cenaPoru4ka = (decimal)brSnimki * 0.16m;
                if (brSnimki >= 80)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.03m * cenaPoru4ka;

                }

                if (na4inNaPoru4ka == "online")
                {
                    cenaPoru4ka = cenaPoru4ka - 0.02m * cenaPoru4ka;
                }
            }
            if (razmer == "13X18")
            {
                cenaPoru4ka = (decimal)brSnimki * 0.38m;
                if (brSnimki >= 50 && brSnimki <= 100)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.03m * cenaPoru4ka;

                }
                if (brSnimki > 100)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.05m * cenaPoru4ka;
                }

                if (na4inNaPoru4ka == "online")
                {
                    cenaPoru4ka = cenaPoru4ka - 0.02m * cenaPoru4ka;
                }
            }
            if (razmer == "20X30")
            {
                cenaPoru4ka = (decimal)brSnimki * 2.90m;
                if (brSnimki >= 10 && brSnimki <= 50)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.07m * cenaPoru4ka;

                }
                if (brSnimki > 50)
                {
                    cenaPoru4ka = cenaPoru4ka - 0.09m * cenaPoru4ka;
                }

                if (na4inNaPoru4ka == "online")
                {
                    cenaPoru4ka = cenaPoru4ka - 0.02m * cenaPoru4ka;
                }
            }
            Console.WriteLine("{0:f2}BGN", cenaPoru4ka);
        }
        /// <summary>
        /// 3 Septemvri 2017  zada4a   2
        /// </summary>
        static void Stipendiq()
        {


            decimal dohodLV = decimal.Parse(Console.ReadLine());
            decimal sredenUspeh = decimal.Parse(Console.ReadLine());
            decimal minimalnazaplata = decimal.Parse(Console.ReadLine());

            decimal razmerSocS = 35 / 100m * minimalnazaplata;
            decimal stipendiqZaUspeh = sredenUspeh * 25m;

            if (sredenUspeh >= 5.50m)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(stipendiqZaUspeh));
            }
            else if (sredenUspeh > 4.50m && dohodLV < minimalnazaplata)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(razmerSocS));
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
        /// <summary>
        /// 3 Septemvri 2017  zada4a   1
        /// </summary>
        static void Shiva6kiCeh()
        {
            int broiMasi = int.Parse(Console.ReadLine());
            decimal dujinaMasa = decimal.Parse(Console.ReadLine());
            decimal shirinaMasa = decimal.Parse(Console.ReadLine());

            decimal plo6tPokrivki = (decimal)broiMasi * (dujinaMasa + 2m * 0.30m) * (shirinaMasa + 2m * 0.30m);
            decimal plo6tKareta = (decimal)broiMasi * (dujinaMasa / 2m) * (dujinaMasa / 2m);
            decimal cenaDolari = (decimal)plo6tPokrivki * 7m + (decimal)plo6tKareta * 9m;
            decimal cenaBgn = cenaDolari * 1.85m;

            Console.WriteLine("{0:f2} USD", cenaDolari);
            Console.WriteLine("{0:f2} BGN", cenaBgn);
        }
        /// <summary>
        /// 03 Septemvri 2017  zada4a   5
        /// </summary>
        static void Snejinka()
        {
            int n = int.Parse(Console.ReadLine());

            int brt = 0;
            int brtv = n;

            for (int row = 1; row <= 2 * n + 1; row++)
            {
                if (row >= 1 && row < n)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', brt), new string('.', brtv));
                    brt++;
                    brtv--;
                }
                if (row == n)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', brt), new string('*', brtv));
                }
                if (row == n + 1)
                {
                    Console.WriteLine("{0}", new string('*', 2 * n + 3));
                }
                if (row == n + 2)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', brt), new string('*', brtv));
                    brt--;
                    brtv++;
                }
                if (row > n + 2)
                {
                    Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', brt), new string('.', brtv));
                    brt--;
                    brtv++;
                }
            }
        }
        /// <summary>
        /// Risuvane na figuri zad 11
        /// </summary>
        static void Diamand()
        {
            int n = int.Parse(Console.ReadLine());


            if (n % 2 == 1)
            {
                int tireta = (n - 1) / 2 - 1;
                int vTir = n - 2 * tireta - 2;
                int tiretaD = 1;
                int vTirD = n - 4;
                for (int row = 1; row <= n; row++)
                {
                    if (row == 1 || row == n)
                    {
                        Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                    }
                    if (row > 1 && row <= (n + 1) / 2)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', tireta), new string('-', vTir));
                        tireta--;
                        vTir += 2;
                    }
                    if (row > (n + 1) / 2 && row < n)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', tiretaD), new string('-', vTirD));
                        tiretaD++;
                        vTirD -= 2;
                    }
                }
            }
            if (n % 2 == 0)
            {
                int tireta = (n - 1) / 2 - 1;
                int vTir = n - 2 * tireta - 2;
                int tiretaD = 1;
                int vTirD = n - 4;
                for (int row = 1; row <= n - 1; row++)
                {
                    if (row == 1 || row == n - 1)
                    {
                        Console.WriteLine("{0}**{0}", new string('-', (n - 1) / 2));
                    }
                    if (row > 1 && row <= n / 2)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', tireta), new string('-', vTir));
                        tireta--;
                        vTir += 2;
                    }
                    if (row > (n) / 2 && row < n - 1)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', tiretaD), new string('-', vTirD));
                        tiretaD++;
                        vTirD -= 2;
                    }
                }
            }
        }
        /// <summary>
        /// risuvane na figuri zad 10
        /// </summary>
        static void Ku6ti4ka()
        {
            int n = int.Parse(Console.ReadLine());
            int broiZvezdi4ki = 0;
            int brTireta = 0;
            if (n % 2 == 0)
            {
                broiZvezdi4ki = 2;
                brTireta = (n - broiZvezdi4ki) / 2;
            }
            if (n % 2 == 1)
            {
                broiZvezdi4ki = 1;
                brTireta = (n - broiZvezdi4ki) / 2;
            }
            for (int row = 1; row <= n; row++)
            {
                if (row >= 1 && row <= (n + 1) / 2)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', brTireta), new string('*', broiZvezdi4ki));
                    broiZvezdi4ki += 2;
                    brTireta = (n - broiZvezdi4ki) / 2;
                }

                if (row > (n + 1) / 2)
                {
                    Console.WriteLine("|{0}|", new string('*', n - 2));
                }
            }
        }
        /// <summary>
        /// Romb ot zvezdi4ki
        /// </summary>
        static void RisuvanePoKonzolata()
        {
            int n = int.Parse(Console.ReadLine());

            int brIntrvali = n;
            int brzvezdi4ki = n - brIntrvali;
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(' ');
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            for (int row = n - 1; row >= 1; row--)
            {
                Console.Write(new string(' ', n - row));
                Console.Write('*');
                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(' ');
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 23 Iuli 2017  Zada4a  6
        /// </summary>
        static void ImeNaGrupa()
        {
            char gBukva = char.Parse(Console.ReadLine());
            char mB1 = char.Parse(Console.ReadLine());
            char mB2 = char.Parse(Console.ReadLine());
            char mB3 = char.Parse(Console.ReadLine());
            int chislo = int.Parse(Console.ReadLine());

            int broiKombinacii = -1;

            for (char i = 'A'; i <= gBukva; i++)
            {
                for (char k = 'a'; k <= mB1; k++)
                {
                    for (char l = 'a'; l <= mB2; l++)
                    {
                        for (char m = 'a'; m <= mB3; m++)
                        {
                            for (int r = 0; r <= chislo; r++)
                            {
                                broiKombinacii++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(broiKombinacii);
        }
        /// <summary>
        /// 23 Iuli 2017  Zada4a  4
        /// </summary>
        static void RazhodnaEnergiq()
        {
            int broitrenirovu4niDni = int.Parse(Console.ReadLine());
            int broiTanciori = int.Parse(Console.ReadLine());

            int energiq = 0;
            int energiqOtVsi4ki = 0;

            for (int i = 1; i <= broitrenirovu4niDni; i++)
            {
                int chasoveTrenirovka = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && chasoveTrenirovka % 2 == 0)
                {
                    energiq = 68 * broiTanciori;
                    energiqOtVsi4ki += energiq;
                }
                if (i % 2 == 1 && chasoveTrenirovka % 2 == 0)
                {
                    energiq = 49 * broiTanciori;
                    energiqOtVsi4ki += energiq;
                }
                if (i % 2 == 0 && chasoveTrenirovka % 2 == 1)
                {
                    energiq = 65 * broiTanciori;
                    energiqOtVsi4ki += energiq;
                }
                if (i % 2 == 1 && chasoveTrenirovka % 2 == 1)
                {
                    energiq = 30 * broiTanciori;
                    energiqOtVsi4ki += energiq;
                }
            }
            int ob6taEnergiq = broiTanciori * broitrenirovu4niDni * 100;
            int neizhabenaEnergiq = ob6taEnergiq - energiqOtVsi4ki;
            decimal neizhabenaEnergiqOtTancNaDen = (decimal)neizhabenaEnergiq / broitrenirovu4niDni / broiTanciori;

            if (energiqOtVsi4ki <= ob6taEnergiq / 2)
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", neizhabenaEnergiqOtTancNaDen);
            }
            if (energiqOtVsi4ki > ob6taEnergiq / 2)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", neizhabenaEnergiqOtTancNaDen);
            }
        }
        /// <summary>
        /// 23 Iuli 2017  Zada4a  2
        /// </summary>
        static void Horeografiq()
        {
            int broiStupki = int.Parse(Console.ReadLine());
            int broiTanciori = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());

            decimal stupkiNaDen = Math.Ceiling(((decimal)broiStupki / (decimal)broiDni) * 100 / (decimal)broiStupki);
            decimal procentStupkiZaVsekiTancior = stupkiNaDen / (decimal)broiTanciori;

            if (stupkiNaDen <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", procentStupkiZaVsekiTancior);
            }
            if (stupkiNaDen > 13)
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day.", procentStupkiZaVsekiTancior);
            }
        }
        /// <summary>
        /// 23 Iuli 2017  Zada4a  1
        /// </summary>
        static void ZalaZaTanci()
        {
            double duljinaZalaM = double.Parse(Console.ReadLine());
            double shirinaZalaM = double.Parse(Console.ReadLine());
            double stranaGarderobM = double.Parse(Console.ReadLine());

            double plo6tZalaSan = (duljinaZalaM * 100) * (shirinaZalaM * 100);
            double plo6tGarderobSan = (stranaGarderobM * 100) * (stranaGarderobM * 100);
            double plo6tPeikasan = plo6tZalaSan / 10;
            double svobodnoProstranstvo = plo6tZalaSan - plo6tGarderobSan - plo6tPeikasan;
            double broiTanciori = Math.Floor(svobodnoProstranstvo / (40 + 7000));
            Console.WriteLine(broiTanciori);
        }
        /// <summary>
        /// 25 Iuni 2017  Zada4a  6
        /// </summary>
        static void SborIliProizvedenie()
        {
            int n = int.Parse(Console.ReadLine());
            bool ima = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int k = 1; k <= 30; k++)
                {
                    for (int l = 1; l <= 30; l++)
                    {
                        if (i < k && k < l)
                        {

                            if (i + k + l == n)
                            {
                                ima = true;
                                Console.WriteLine("{0} + {1} + {2} = {3}", i, k, l, n);
                            }
                        }
                        if (i > k && k > l)
                        {

                            if (i * k * l == n)
                            {
                                ima = true;
                                Console.WriteLine("{0} * {1} * {2} = {3}", i, k, l, n);
                            }
                        }

                    }
                }

            }
            if (ima == false)
            {
                Console.WriteLine("No!");
            }
        }
        /// <summary>
        /// 25 Iuni 2017  Zada4a  4
        /// </summary>
        static void Pari4naNagrada()
        {
            int broi4asti = int.Parse(Console.ReadLine());
            decimal pariZaEdnaTo4ka = decimal.Parse(Console.ReadLine());

            double ob6tBroiTo4ki = 0;

            for (int i = 1; i <= broi4asti; i++)
            {
                int brTo4kiNaEdna4ast = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    brTo4kiNaEdna4ast = brTo4kiNaEdna4ast * 2;
                }
                ob6tBroiTo4ki += brTo4kiNaEdna4ast;
            }
            decimal pariOb6to = (decimal)ob6tBroiTo4ki * pariZaEdnaTo4ka;
            Console.WriteLine("The project prize was {0:f2} lv.", pariOb6to);
        }
        /// <summary>
        /// 25 Iuni 2017  Zada4a  2
        /// </summary>
        static void SvetovenRekordPoPluvane()
        {
            double rekordSekundi = double.Parse(Console.ReadLine());
            double razstoqnieMetri = double.Parse(Console.ReadLine());
            double vremeVSekZa1Merur = double.Parse(Console.ReadLine());

            double vremeZaPluvane = razstoqnieMetri * vremeVSekZa1Merur;
            double zabavqne = Math.Floor((razstoqnieMetri / 15d)) * 12.5d;
            double vremeNaIvan4o = vremeZaPluvane + zabavqne;

            if (vremeNaIvan4o < rekordSekundi)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", vremeNaIvan4o);
            }
            if (vremeNaIvan4o >= rekordSekundi)
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", vremeNaIvan4o - rekordSekundi);
            }
        }
        /// <summary>
        /// 25 Iuni 2017  Zada4a  1
        /// </summary>
        static void BlagotvoritelnaKampaniq()
        {
            int broiDni = int.Parse(Console.ReadLine());
            int broiSladkari = int.Parse(Console.ReadLine());
            int broiTorti = int.Parse(Console.ReadLine());
            int broiGofreti = int.Parse(Console.ReadLine());
            int broiPala4inki = int.Parse(Console.ReadLine());

            decimal pariTorti = (decimal)broiTorti * 45m;
            decimal pariGofreti = (decimal)broiGofreti * 5.80m;
            decimal pariPala4inki = (decimal)broiPala4inki * 3.20m;
            decimal ob6taSuma = ((pariTorti + pariGofreti + pariPala4inki) * broiSladkari) * broiDni;
            decimal crainaSuma = ob6taSuma - 1 / 8m * ob6taSuma;

            Console.WriteLine("{0:f2}", crainaSuma);
        }
        /// <summary>
        /// 7 Mai 2017   Zada4a   6
        /// </summary>
        static void GeneratorNa4isla()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int spacialno4islo = int.Parse(Console.ReadLine());
            int kontrolno4islo = int.Parse(Console.ReadLine());

            bool vqrno = false;
            bool kontr = false;

            for (int i = n; i >= 1 && !kontr; i--)
            {
                for (int k = m; k >= 1 && !kontr; k--)
                {
                    for (int r = l; r >= 1; r--)
                    {
                        vqrno = false;
                        if (spacialno4islo >= kontrolno4islo)
                        {
                            Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", spacialno4islo);
                            kontr = true;
                            break;
                        }
                        if ((i + k + r) % 3 == 0)
                        {
                            spacialno4islo += 5;
                            vqrno = true;
                        }
                        if (r == 5 && vqrno != true)
                        {
                            spacialno4islo -= 2;
                            vqrno = true;
                        }
                        if ((r % 2 == 0) && vqrno != true)
                        {
                            spacialno4islo = spacialno4islo * 2;
                        }
                    }
                }
            }
            if (kontr != true)
            {
                Console.WriteLine("No! {0} is the last reached special number.", spacialno4islo);
            }
        }
        /// <summary>
        /// 7 Mai 2017   Zada4a   4
        /// </summary>
        static void FutbolenTurnir()
        {
            int kapacitetNaStadiona = int.Parse(Console.ReadLine());
            int broiFenove = int.Parse(Console.ReadLine());


            int sA = 0;
            int sB = 0;
            int sV = 0;
            int sG = 0;


            for (int i = 1; i <= broiFenove; i++)
            {
                char sektor = char.Parse(Console.ReadLine());
                if (sektor == 'A')
                {
                    sA++;
                }
                if (sektor == 'B')
                {
                    sB++;
                }
                if (sektor == 'V')
                {
                    sV++;
                }
                if (sektor == 'G')
                {
                    sG++;
                }
            }
            Console.WriteLine("{0:f2}%", (double)sA * 100d / (double)broiFenove);
            Console.WriteLine("{0:f2}%", (double)sB * 100d / (double)broiFenove);
            Console.WriteLine("{0:f2}%", (double)sV * 100d / (double)broiFenove);
            Console.WriteLine("{0:f2}%", (double)sG * 100d / (double)broiFenove);
            Console.WriteLine("{0:f2}%", (double)broiFenove * 100d / (double)kapacitetNaStadiona);
        }
        /// <summary>
        /// 7 Mai 2017   Zada4a   2
        /// </summary>
        static void MagazinZadetskiigra4ki()
        {
            decimal cenaEkskurziq = decimal.Parse(Console.ReadLine());
            int broiPuzeli = int.Parse(Console.ReadLine());
            int broiKukli = int.Parse(Console.ReadLine());
            int broiMe4eta = int.Parse(Console.ReadLine());
            int broiMinioni = int.Parse(Console.ReadLine());
            int broikamioni = int.Parse(Console.ReadLine());

            int ob6tBroiIgra4ki = broiPuzeli + broiKukli + broiMe4eta + broiMinioni + broikamioni;
            decimal ob6taCena = (decimal)broiPuzeli * 2.60m + (decimal)broiKukli * 3m + (decimal)broiMe4eta * 4.10m + (decimal)broiMinioni * 8.20m + (decimal)broikamioni * 2m;
            decimal krainaCena = 0;

            if (ob6tBroiIgra4ki >= 50)
            {
                ob6taCena = ob6taCena - 0.25m * ob6taCena;
                krainaCena = ob6taCena - 0.10m * ob6taCena;
            }
            else
            {
                krainaCena = ob6taCena - 0.10m * ob6taCena;
            }
            if (krainaCena >= cenaEkskurziq)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", krainaCena - cenaEkskurziq);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:f2} lv needed.", cenaEkskurziq - krainaCena);
            }
        }
        /// <summary>
        /// 7 Mai 2017   Zada4a   1
        /// </summary>
        static void AlkoholnaBorsa()
        {
            decimal cenaUiski = decimal.Parse(Console.ReadLine());
            double litriBira = double.Parse(Console.ReadLine());
            double litriVino = double.Parse(Console.ReadLine());
            double litriRakiq = double.Parse(Console.ReadLine());
            double litriUiski = double.Parse(Console.ReadLine());

            decimal cenaRakiq = (decimal)cenaUiski / 2m;
            decimal cenaVino = cenaRakiq - 0.4m * cenaRakiq;
            decimal cenaBira = cenaRakiq - 0.8m * cenaRakiq;

            decimal cenaOb6to = (decimal)litriUiski * cenaUiski + (decimal)litriRakiq * cenaRakiq + (decimal)litriVino * cenaVino + (decimal)litriBira * cenaBira;
            Console.WriteLine("{0:f2}", cenaOb6to);
        }
        /// <summary>
        /// 19 March 2017 Ve4er Zada4a  6
        /// </summary>
        static void Kontrolno4islo()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int kontrolno4islo = int.Parse(Console.ReadLine());

            int suma = 0;
            int ob6taSuma = 0;
            int brKombinacii = 0;
            bool ravni = false;

            for (int i = 1; i <= n; i++)
            {
                for (int k = m; k >= 1; k--)
                {
                    brKombinacii++;
                    suma = i * 2 + k * 3;
                    ob6taSuma += suma;
                    if (ob6taSuma >= kontrolno4islo)
                    {
                        Console.WriteLine("{0} moves", brKombinacii);
                        Console.WriteLine("Score: {0} >= {1}", ob6taSuma, kontrolno4islo);
                        ravni = true;
                        break;
                    }
                }
                if (ravni == true)
                {
                    break;
                }
            }
            if (ravni != true)
            {
                Console.WriteLine("{0} moves", brKombinacii);
            }
        }
        /// <summary>
        /// 19 March 2017 Ve4er Zada4a  4
        /// </summary>
        static void Mese4niRazhodi()
        {
            int broiMeseci = int.Parse(Console.ReadLine());

            decimal tokOb6to = 0;
            decimal vodaOb6to = 0;
            decimal internetOb6to = 0;
            decimal drugiob6to = 0;

            for (int i = 1; i <= broiMeseci; i++)
            {
                decimal cenaTok = decimal.Parse(Console.ReadLine());

                tokOb6to += cenaTok;
                vodaOb6to += 20;
                internetOb6to += 15;
                drugiob6to += (cenaTok + 20 + 15) + 0.2m * (cenaTok + 20 + 15);
            }
            Console.WriteLine("Electricity: {0:f2} lv", tokOb6to);
            Console.WriteLine("Water: {0:f2} lv", vodaOb6to);
            Console.WriteLine("Internet: {0:f2} lv", internetOb6to);
            Console.WriteLine("Other: {0:f2} lv", drugiob6to);
            Console.WriteLine("Average: {0:f2} lv", (tokOb6to + vodaOb6to + internetOb6to + drugiob6to) / broiMeseci);
        }
        /// <summary>
        /// 19 March 2017 Ve4er Zada4a  2
        /// </summary>
        static void Stiropor()
        {
            decimal biudjet = decimal.Parse(Console.ReadLine());
            double plo6tKu6ta = double.Parse(Console.ReadLine());
            int broiProzorci = int.Parse(Console.ReadLine());
            double kvMstiroporVPaket = double.Parse(Console.ReadLine());
            decimal cenaPaketStiropor = decimal.Parse(Console.ReadLine());

            double plo6tKu6taBezProzorci = plo6tKu6ta - (double)broiProzorci * 2.4d;
            double kvMStiropor = plo6tKu6taBezProzorci + 0.1d * plo6tKu6taBezProzorci;
            double nujniPaketi = Math.Ceiling(kvMStiropor / kvMstiroporVPaket);
            decimal cenaPaketi = (decimal)nujniPaketi * cenaPaketStiropor;

            if (cenaPaketi <= biudjet)
            {
                Console.WriteLine("Spent: {0:f2}", cenaPaketi);
                Console.WriteLine("Left: {0:f2}", biudjet - cenaPaketi);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", cenaPaketi - biudjet);
            }
        }
        /// <summary>
        /// 19 March 2017 Ve4er Zada4a  1
        /// </summary>
        static void GrozdeIRakiq()
        {
            double plo6tGrozde = double.Parse(Console.ReadLine());
            double kgGrozdeNaKvm = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double ob6toKgGrozde = plo6tGrozde * kgGrozdeNaKvm - brak;
            double litraRakiq = (0.45 * ob6toKgGrozde) / 7.5;
            decimal prihodRakiq = (decimal)litraRakiq * 9.8m;

            decimal prihodGrozde = 0.55m * (decimal)ob6toKgGrozde * 1.5m;

            Console.WriteLine("{0:f2}", prihodRakiq);
            Console.WriteLine("{0:f2}", prihodGrozde);
        }
        /// <summary>
        /// 19 March 2017 - Morning Zada4a  6
        /// </summary>
        static void TwoNumbersSum()
        {
            int purvo4islo = int.Parse(Console.ReadLine());
            int vtoro4islo = int.Parse(Console.ReadLine());
            int magi4asko4islo = int.Parse(Console.ReadLine());

            int broiKombinacii = 0;
            int magi4eskakombinaciq = 0;
            bool ima = false;

            for (int i = purvo4islo; i >= vtoro4islo && !ima; i--)
            {
                for (int k = purvo4islo; k >= vtoro4islo && !ima; k--)
                {
                    broiKombinacii++;
                    if (i + k == magi4asko4islo)
                    {
                        magi4eskakombinaciq = broiKombinacii;
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", magi4eskakombinaciq, i, k, i + k);
                        ima = true;
                    }
                }
            }

            if (!ima)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", broiKombinacii, magi4asko4islo);
            }
        }
        /// <summary>
        /// 19 March 2017 - Morning Zada4a  4
        /// </summary>
        static void LektorskiZaplati()
        {
            int broiLekcii = int.Parse(Console.ReadLine());
            decimal biudjet = decimal.Parse(Console.ReadLine());

            int roYal = 0;
            int jelev = 0;
            int roli = 0;
            int trofon = 0;
            int sino = 0;
            int other = 0;

            decimal zaplataNa4ovek = biudjet / (decimal)broiLekcii;

            for (int i = 1; i <= broiLekcii; i++)
            {
                string imeLektor = Console.ReadLine();

                if (imeLektor == "Jelev")
                {
                    jelev++;
                }
                if (imeLektor == "RoYaL")
                {
                    roYal++;
                }
                if (imeLektor == "Roli")
                {
                    roli++;
                }
                if (imeLektor == "Trofon")
                {
                    trofon++;
                }
                if (imeLektor == "Sino")
                {
                    sino++;
                }
                if (imeLektor != "Sino" && imeLektor != "Trofon" && imeLektor != "Roli" && imeLektor != "RoYaL" && imeLektor != "Jelev")
                {
                    other++;
                }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", (decimal)jelev * zaplataNa4ovek);
            Console.WriteLine("RoYaL salary: {0:f2} lv", (decimal)roYal * zaplataNa4ovek);
            Console.WriteLine("Roli salary: {0:f2} lv", (decimal)roli * zaplataNa4ovek);
            Console.WriteLine("Trofon salary: {0:f2} lv", (decimal)trofon * zaplataNa4ovek);
            Console.WriteLine("Sino salary: {0:f2} lv", (decimal)sino * zaplataNa4ovek);
            Console.WriteLine("Others salary: {0:f2} lv", (decimal)other * zaplataNa4ovek);
        }
        /// <summary>
        /// 19 March 2017 - Morning Zada4a  2
        /// </summary>
        static void Cha6i()
        {
            int planuvanBroi4a6i = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());
            int broiRabotniDni = int.Parse(Console.ReadLine());

            int izraboteni4asove = broiRabotnici * broiRabotniDni * 8;
            double Izraboteni4a6i = Math.Floor((double)izraboteni4asove / 5d);

            if (Izraboteni4a6i < planuvanBroi4a6i)
            {

                Console.WriteLine("Losses: {0:f2}", (planuvanBroi4a6i - Izraboteni4a6i) * 4.2);
            }
            if (Izraboteni4a6i >= planuvanBroi4a6i)
            {

                Console.WriteLine("{0:f2} extra money", (Izraboteni4a6i - planuvanBroi4a6i) * 4.2);
            }
        }
        /// <summary>
        /// 19 March 2017 - Morning Zada4a  1
        /// </summary>
        static void BoqdisvaneNaKu6ta()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double strani4niSteni = 2 * (x * y - 1.5 * 1.5);
            double prednaiZadnaSteni = 2 * x * x - 2 * 1.2;
            double osnova = strani4niSteni + prednaiZadnaSteni;

            double pokriv = 2 * (x * y) + 2 * (x * h / 2);

            double litriZelenaBoq = osnova / 3.4;
            double Litri4ervenaBoq = pokriv / 4.3;

            Console.WriteLine("{0:f2}", litriZelenaBoq);
            Console.WriteLine("{0:f2}", Litri4ervenaBoq);
        }
        /// <summary>
        /// 18 Mart2017   Zada4a  6
        /// </summary>
        static void SumaOtDve4isla()
        {
            int purvo4islo = int.Parse(Console.ReadLine());
            int vtoro4islo = int.Parse(Console.ReadLine());
            int magi4esko4islo = int.Parse(Console.ReadLine());

            int nomerCombinaciq = 0;
            int nomerNaMagKombinaciq = 0;
            bool vqrno = false;

            for (int i = purvo4islo; i <= vtoro4islo; i++)
            {
                for (int k = purvo4islo; k <= vtoro4islo; k++)
                {
                    nomerCombinaciq++;
                    if (i + k == magi4esko4islo)
                    {
                        nomerNaMagKombinaciq = nomerCombinaciq;
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", nomerNaMagKombinaciq, i, k, magi4esko4islo);
                        vqrno = true;
                        break;
                    }
                    if (vqrno == true)
                    {
                        break;
                    }
                }
                if (vqrno == true)
                {
                    break;
                }
            }
            if (vqrno != true)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", nomerCombinaciq, magi4esko4islo);
            }

        }
        /// <summary>
        /// 18 Mart2017   Zada4a  4
        /// </summary>
        static void IgraNaIntervali()
        {
            int broiHodove = int.Parse(Console.ReadLine());
            double broiTo4ki = 0;
            double kraenRezultat = 0;
            double ot0do9 = 0;
            double ot10do19 = 0;
            double ot20do29 = 0;
            double ot30do39 = 0;
            double ot40do49 = 0;
            double neValidno = 0;


            for (int i = 1; i <= broiHodove; i++)
            {
                double chislo = double.Parse(Console.ReadLine());

                if (chislo < 0 || chislo > 50)
                {
                    neValidno++;
                    kraenRezultat = kraenRezultat / 2;
                    broiTo4ki = 0;
                }
                if (chislo >= 0 && chislo < 10)
                {
                    ot0do9++;
                    broiTo4ki = 0.2d * chislo;
                }
                if (chislo >= 10 && chislo < 20)
                {
                    ot10do19++;
                    broiTo4ki = 0.3 * chislo;
                }
                if (chislo >= 20 && chislo < 30)
                {
                    ot20do29++;
                    broiTo4ki = 0.4 * chislo;
                }
                if (chislo >= 30 && chislo < 40)
                {
                    ot30do39++;
                    broiTo4ki = 50;
                }
                if (chislo >= 40 && chislo <= 50)
                {
                    ot40do49++;
                    broiTo4ki = 100;
                }
                kraenRezultat += broiTo4ki;
            }
            Console.WriteLine("{0:f2}", (double)kraenRezultat);
            Console.WriteLine("From 0 to 9: {0:f2}%", ot0do9 * 100 / broiHodove);
            Console.WriteLine("From 10 to 19: {0:f2}%", ot10do19 * 100 / broiHodove);
            Console.WriteLine("From 20 to 29: {0:f2}%", ot20do29 * 100 / broiHodove);
            Console.WriteLine("From 30 to 39: {0:f2}%", ot30do39 * 100 / broiHodove);
            Console.WriteLine("From 40 to 50: {0:f2}%", ot40do49 * 100 / broiHodove);
            Console.WriteLine("Invalid numbers: {0:f2}%", neValidno * 100 / broiHodove);
        }
        /// <summary>
        /// 18 Mart2017   Zada4a  2
        /// </summary>
        static void Rabotni4asove()
        {
            int neobhodimi4asove = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());
            int rabotniDni = int.Parse(Console.ReadLine());

            int rabotni4asove = broiRabotnici * rabotniDni * 8;
            if (rabotni4asove > neobhodimi4asove)
            {
                Console.WriteLine("{0} hours left", rabotni4asove - neobhodimi4asove);
            }
            if (neobhodimi4asove > rabotni4asove)
            {
                Console.WriteLine("{0} overtime", neobhodimi4asove - rabotni4asove);
                Console.WriteLine("Penalties: {0}", (neobhodimi4asove - rabotni4asove) * rabotniDni);
            }
        }
        /// <summary>
        /// 18 Mart2017   Zada4a  1
        /// </summary>
        static void Ku6ti4kaZaKu4e()
        {
            double duljinaNaStranicata = double.Parse(Console.ReadLine());
            double viso4inaKu6ta = double.Parse(Console.ReadLine());

            double plo6tNaStranici = 2 * (duljinaNaStranicata * duljinaNaStranicata / 2);
            double plo6tZadnastena = duljinaNaStranicata / 2 * duljinaNaStranicata / 2 + ((duljinaNaStranicata / 2 * (viso4inaKu6ta - duljinaNaStranicata / 2)) / 2);
            double plo6tPrednaStena = plo6tZadnastena - duljinaNaStranicata / 5 * duljinaNaStranicata / 5;
            double plo6tOsnova = plo6tNaStranici + plo6tZadnastena + plo6tPrednaStena;

            double plo6tPokriv = 2 * (duljinaNaStranicata * duljinaNaStranicata / 2);
            double boqzaPokriv = plo6tPokriv / 5;
            double boqOsnova = plo6tOsnova / 3;
            Console.WriteLine("{0:f2}", boqOsnova);
            Console.WriteLine("{0:f2}", boqzaPokriv);
        }
        /// <summary>
        /// 18 Dekemvri 2016  Zada4a   6
        /// </summary>
        static void KombinaciiOtBukvi()
        {
            char purvaBukva = char.Parse(Console.ReadLine());
            char vtoraBukva = char.Parse(Console.ReadLine());
            char prezko4iBukva = char.Parse(Console.ReadLine());

            int broiKombinacii = 0;

            for (char i = purvaBukva; i <= vtoraBukva; i++)
            {
                if (i == prezko4iBukva)
                {
                    continue;
                }
                for (char k = purvaBukva; k <= vtoraBukva; k++)
                {
                    if (k == prezko4iBukva)
                    {
                        continue;
                    }
                    for (char l = purvaBukva; l <= vtoraBukva; l++)
                    {
                        if (l == prezko4iBukva)
                        {
                            continue;
                        }
                        broiKombinacii++;
                        Console.Write("{0}{1}{2} ", i, k, l);
                    }
                }
            }
            Console.WriteLine(broiKombinacii);
        }
        /// <summary>
        /// 18 Dekemvri 2016  Zada4a   4
        /// </summary>
        static void Ocenki()
        {
            int broiStudenti = int.Parse(Console.ReadLine());

            double ndOcenka = 0;
            int bro2 = 0;
            int bro3i4 = 0;
            int bro4i5 = 0;
            int bro5i6 = 0;

            for (int i = 1; i <= broiStudenti; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka < 3)
                {
                    bro2++;
                }
                if (ocenka >= 3 && ocenka < 4)
                {
                    bro3i4++;
                }
                if (ocenka >= 4 && ocenka < 5)
                {
                    bro4i5++;
                }
                if (ocenka >= 5)
                {
                    bro5i6++;
                }
                ndOcenka += ocenka;
            }
            Console.WriteLine("Top students: {0:f2}%", bro5i6 * 100d / broiStudenti);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", bro4i5 * 100d / broiStudenti);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", bro3i4 * 100d / broiStudenti);
            Console.WriteLine("Fail: {0:f2}%", bro2 * 100d / broiStudenti);
            Console.WriteLine("Average: {0:f2}", ndOcenka / (double)broiStudenti);

        }
        /// <summary>
        /// 18 Dekemvri 2016  Zada4a   2
        /// </summary>
        static void SmqnaNaPlo4ki()
        {
            decimal subraniPari = decimal.Parse(Console.ReadLine());
            double shirinaPod = double.Parse(Console.ReadLine());
            double duljinaPod = double.Parse(Console.ReadLine());
            double stranaTriugulnik = double.Parse(Console.ReadLine());
            double viso4inaTriugulnik = double.Parse(Console.ReadLine());
            decimal cenaPlo4ka = decimal.Parse(Console.ReadLine());
            decimal cenaZaMaistor = decimal.Parse(Console.ReadLine());

            double plo6tNaPoda = shirinaPod * duljinaPod;
            double plo6tPlo4ka = stranaTriugulnik * viso4inaTriugulnik / 2d;
            double neubhodimBroiPlo4ki = Math.Ceiling(plo6tNaPoda / plo6tPlo4ka + 5d);
            decimal ob6taSuma = (decimal)neubhodimBroiPlo4ki * cenaPlo4ka + cenaZaMaistor;

            if (ob6taSuma <= subraniPari)
            {
                Console.WriteLine("{0:f2} lv left.", subraniPari - ob6taSuma);
            }
            if (subraniPari < ob6taSuma)
            {
                Console.WriteLine("You'll need {0:f2} lv more.", ob6taSuma - subraniPari);
            }
        }
        /// <summary>
        /// 18 Dekemvri 2016  Zada4a   1
        /// </summary>
        static void Razstoqnie()
        {
            int purvona4alnaSkorost = int.Parse(Console.ReadLine());
            int purvoVremeVMinuti = int.Parse(Console.ReadLine());
            int vtoroVremeVMinuti = int.Parse(Console.ReadLine());
            int tretoVremeVMinuti = int.Parse(Console.ReadLine());

            double vtoraSkorost = (double)purvona4alnaSkorost + 0.1d * (double)purvona4alnaSkorost;
            double tretaSkorost = vtoraSkorost - 0.05d * vtoraSkorost;

            double purvoVreme4asove = (double)purvoVremeVMinuti / 60;
            double vtoroVreme4asove = (double)vtoroVremeVMinuti / 60;
            double tretoVreme4asove = (double)tretoVremeVMinuti / 60;

            double razstoqnie = purvoVreme4asove * purvona4alnaSkorost + vtoroVreme4asove * vtoraSkorost + tretoVreme4asove * tretaSkorost;
            Console.WriteLine("{0:f2}", razstoqnie);
        }
        /// <summary>
        /// 20 Noemvri 2016 - Evening  Zada4a   6
        /// </summary>
        static void MksimalenBroiKombinacii()
        {
            int purvoChislo = int.Parse(Console.ReadLine());
            int vtoroChislo = int.Parse(Console.ReadLine());
            int broiKombinacii = int.Parse(Console.ReadLine());

            int kombinacii = 0;

            for (int i = purvoChislo; i <= vtoroChislo; i++)
            {
                for (int k = purvoChislo; k <= vtoroChislo; k++)
                {
                    Console.Write("<{0}-{1}>", i, k);
                    kombinacii++;
                    if (kombinacii == broiKombinacii)
                    {
                        break;
                    }
                }
                if (kombinacii == broiKombinacii)
                {
                    break;
                }
            }
        }
        /// <summary>
        /// 20 Noemvri 2016 - Evening  Zada4a   4
        /// </summary>
        static void Logistika()
        {
            int broitovari = int.Parse(Console.ReadLine());

            decimal broiTonove = 0;
            decimal cenaZaPrevoz = 0;
            decimal cenaMikrobus = 0;
            decimal cenaKamion = 0;
            decimal cenaVlak = 0;
            decimal tonavKamion = 0;
            decimal tonaMikrobus = 0;
            decimal tonaVlak = 0;

            for (int i = 1; i <= broitovari; i++)
            {
                int tonajNaTovar = int.Parse(Console.ReadLine());

                if (tonajNaTovar <= 3)
                {
                    cenaZaPrevoz = tonajNaTovar * 200;
                    cenaMikrobus += cenaZaPrevoz;
                    tonaMikrobus += tonajNaTovar;
                }
                if (tonajNaTovar >= 4 && tonajNaTovar <= 11)
                {
                    cenaZaPrevoz = tonajNaTovar * 175;
                    cenaKamion += cenaZaPrevoz;
                    tonavKamion += tonajNaTovar;
                }
                if (tonajNaTovar >= 12)
                {
                    cenaZaPrevoz = tonajNaTovar * 120;
                    cenaVlak += cenaZaPrevoz;
                    tonaVlak += tonajNaTovar;
                }
                broiTonove += tonajNaTovar;
            }
            decimal ob6toCena = cenaMikrobus + cenaKamion + cenaVlak;
            Console.WriteLine("{0:f2}", ob6toCena / broiTonove);
            Console.WriteLine("{0:f2}%", tonaMikrobus * 100 / broiTonove);
            Console.WriteLine("{0:f2}%", tonavKamion * 100 / broiTonove);
            Console.WriteLine("{0:f2}%", tonaVlak * 100 / broiTonove);
        }
        /// <summary>
        /// 20 Noemvri 2016 - Evening  Zada4a   2
        /// </summary>
        static void MagazinZaCvetq()
        {
            int broiMagnolii = int.Parse(Console.ReadLine());
            int broiZiumbiuli = int.Parse(Console.ReadLine());
            int broiRozi = int.Parse(Console.ReadLine());
            int broiKaktusi = int.Parse(Console.ReadLine());
            decimal cenaNaPodaruk = decimal.Parse(Console.ReadLine());

            decimal ob6taSuma = (broiMagnolii * 3.25m + broiZiumbiuli * 4m + broiRozi * 3.50m + broiKaktusi * 8m);
            decimal krainaSuma = (ob6taSuma - 0.05m * ob6taSuma);
            if (krainaSuma >= cenaNaPodaruk)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(krainaSuma - cenaNaPodaruk));
            }
            if (krainaSuma < cenaNaPodaruk)
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(cenaNaPodaruk - krainaSuma));
            }
        }
        /// <summary>
        /// 20 Noemvri 2016 - Evening  Zada4a   1
        /// </summary>
        static void CenaNaJili6te()
        {
            double naiMalkaStaq = double.Parse(Console.ReadLine());
            double plo6tKuhnq = double.Parse(Console.ReadLine());
            decimal cenaNaKvM = decimal.Parse(Console.ReadLine());

            double banq = naiMalkaStaq / 2;
            double vtoraStaq = naiMalkaStaq + 0.1 * naiMalkaStaq;
            double tretaStaq = vtoraStaq + 0.1 * vtoraStaq;
            double ob6taPlo6t = plo6tKuhnq + banq + naiMalkaStaq + vtoraStaq + tretaStaq;
            double sKoridor = ob6taPlo6t + 0.05 * ob6taPlo6t;
            decimal cenaVsi4ko = (decimal)sKoridor * cenaNaKvM;
            Console.WriteLine("{0:f2}", cenaVsi4ko);
        }
        /// <summary>
        /// 20 Noemvri2016 Morning Zada4a   6
        /// </summary>
        static void Bitki()
        {
            int broiPokemoni1 = int.Parse(Console.ReadLine());
            int broiPokemoni2 = int.Parse(Console.ReadLine());
            int maksimalenBroiBitki = int.Parse(Console.ReadLine());

            int broiBitki = 0;

            for (int i = 1; i <= broiPokemoni1; i++)
            {
                for (int k = 1; k <= broiPokemoni2; k++)
                {

                    broiBitki++;
                    if (broiBitki > maksimalenBroiBitki)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", i, k);
                }
            }
        }
        /// <summary>
        /// 20 Noemvri2016 Morning Zada4a   4
        /// </summary>
        static void SoftUniKemp()
        {
            int broiGrupi = int.Parse(Console.ReadLine());
            int kola = 0;
            int mikrobus = 0;
            int malukAvtobus = 0;
            int golqmAvtobus = 0;
            int vlak = 0;
            int broiStudenti = 0;
            for (int i = 1; i <= broiGrupi; i++)
            {
                int broiHoravGrupa = int.Parse(Console.ReadLine());

                broiStudenti += broiHoravGrupa;
                if (broiHoravGrupa <= 5)
                {
                    kola += broiHoravGrupa;
                }
                if (broiHoravGrupa >= 6 && broiHoravGrupa <= 12)
                {
                    mikrobus += broiHoravGrupa;
                }
                if (broiHoravGrupa >= 13 && broiHoravGrupa <= 25)
                {
                    malukAvtobus += broiHoravGrupa;
                }
                if (broiHoravGrupa >= 26 && broiHoravGrupa <= 40)
                {
                    golqmAvtobus += broiHoravGrupa;
                }
                if (broiHoravGrupa >= 41)
                {
                    vlak += broiHoravGrupa;
                }
            }
            Console.WriteLine("{0:f2}%", (double)kola * 100d / broiStudenti);
            Console.WriteLine("{0:f2}%", (double)mikrobus * 100d / broiStudenti);
            Console.WriteLine("{0:f2}%", (double)malukAvtobus * 100d / broiStudenti);
            Console.WriteLine("{0:f2}%", (double)golqmAvtobus * 100d / broiStudenti);
            Console.WriteLine("{0:f2}%", (double)vlak * 100d / broiStudenti);
        }
        /// <summary>
        /// 20 Noemvri2016 Morning Zada4a   2
        /// </summary>
        static void Doma6niLiubimci()
        {
            int broiDni = int.Parse(Console.ReadLine());
            int hranaVKg = int.Parse(Console.ReadLine());
            double hranaKu4eKG = double.Parse(Console.ReadLine());
            double hranaKotkaKG = double.Parse(Console.ReadLine());
            double hranaKOstenurkaGR = double.Parse(Console.ReadLine());

            double hranaKostenurkaKG = hranaKOstenurkaGR / 1000;
            double ostavenaHrana = Math.Ceiling(broiDni * (hranaKu4eKG + hranaKotkaKG + hranaKostenurkaKG));
            if (ostavenaHrana <= hranaVKg)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Ceiling(hranaVKg - ostavenaHrana));
            }
            if (ostavenaHrana > hranaVKg)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(ostavenaHrana - hranaVKg));
            }
        }
        /// <summary>
        /// 20 Noemvri2016 Morning Zada4a   1
        /// </summary>
        static void RibnaBorsa()
        {
            decimal skumriq = decimal.Parse(Console.ReadLine());
            decimal caca = decimal.Parse(Console.ReadLine());
            decimal kgPalamud = decimal.Parse(Console.ReadLine());
            decimal kgSafrid = decimal.Parse(Console.ReadLine());
            decimal kgMidi = decimal.Parse(Console.ReadLine());

            decimal cenaPalamud = skumriq + 0.6m * skumriq;
            decimal cenaSafrid = caca + 0.8m * caca;
            decimal cenaMidi = 7.5m;

            Console.WriteLine("{0:f2}", kgPalamud * cenaPalamud + kgSafrid * cenaSafrid + kgMidi * cenaMidi);
        }
        /// <summary>
        /// 28 Avgust 2016  Zada4a   6
        /// </summary>
        static void Cifri()
        {
            int chislo = int.Parse(Console.ReadLine());
            int redove = chislo / 100 + (chislo / 10 % 10);
            int koloni = chislo / 100 + chislo % 10;

            int delenoNa5 = chislo / 100;
            int delenoNa3 = chislo / 10 % 10;
            int ina4e = chislo % 10;

            for (int row = 1; row <= redove; row++)
            {
                for (int col = 1; col <= koloni; col++)
                {
                    if (chislo % 5 == 0)
                    {
                        chislo = chislo - delenoNa5;

                    }
                    else if (chislo % 3 == 0)
                    {
                        chislo = chislo - delenoNa3;

                    }
                    else
                    {
                        chislo = chislo + ina4e;

                    }
                    Console.Write("{0} ", chislo);
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// 28 Avgust 2016  Zada4a   4
        /// </summary>
        static void Bolnica()
        {
            int period = int.Parse(Console.ReadLine());

            int brPregledani = 0;
            int brNePregledani = 0;
            int brLekari = 7;
            int brOb6toPregledani = 0;
            int brOb6toNepregledani = 0;

            for (int den = 1; den <= period; den++)
            {
                int broiPacienti = int.Parse(Console.ReadLine());
                if (den % 3 == 0 && brOb6toNepregledani > brOb6toPregledani)
                {
                    brLekari++;
                }
                if (broiPacienti <= brLekari)
                {
                    brPregledani = broiPacienti;
                    brNePregledani = 0;
                }
                if (broiPacienti > brLekari)
                {
                    brPregledani = brLekari;
                    brNePregledani = broiPacienti - brLekari;
                }
                brOb6toPregledani += brPregledani;
                brOb6toNepregledani += brNePregledani;

            }
            Console.WriteLine("Treated patients: {0}.", brOb6toPregledani);
            Console.WriteLine("Untreated patients: {0}.", brOb6toNepregledani);
        }
        /// <summary>
        /// 28 Avgust 2016  Zada4a   2
        /// </summary>
        static void Firma()
        {
            int neobhodimi4asove = int.Parse(Console.ReadLine());
            int broiDni = int.Parse(Console.ReadLine());
            int slujiteli = int.Parse(Console.ReadLine());
            double chasoveZaRabota = ((double)broiDni - 0.1 * (double)broiDni) * 8;
            double chasoveIzvunr = (double)slujiteli * 2 * (double)broiDni;
            double ob6to4asove = Math.Floor(chasoveIzvunr + chasoveZaRabota);

            if (ob6to4asove >= neobhodimi4asove)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(ob6to4asove - neobhodimi4asove));
            }
            if (ob6to4asove < neobhodimi4asove)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(neobhodimi4asove - ob6to4asove));
            }
        }
        /// <summary>
        /// 28 Avgust 2016  Zada4a   1
        /// </summary>
        static void DnevnaPe4alba()
        {
            int rabotniDni = int.Parse(Console.ReadLine());
            decimal pariNaDen = decimal.Parse(Console.ReadLine());
            decimal kursNaDolara = decimal.Parse(Console.ReadLine());

            decimal zaplataNaMesec = (decimal)rabotniDni * pariNaDen;
            decimal godi6naZaplata = zaplataNaMesec * 12m + 2.5m * zaplataNaMesec;
            decimal danuk = 0.25m * godi6naZaplata;
            decimal godi6no4istaZaplata = godi6naZaplata - danuk;
            decimal zaplataVLeva = godi6no4istaZaplata * kursNaDolara;
            decimal pe4albaNaDen = zaplataVLeva / 365m;
            Console.WriteLine("{0:f2}", pe4albaNaDen);
        }
        /// <summary>
        /// 17 Iuli 2016  Zada4a 6
        /// </summary>
        static void Stopira6to4islo()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }
        /// <summary>
        /// 17 Iuli 2016  Zada4a 4
        /// </summary>
        static void Zavru6taneVMinaloto()
        {
            decimal pari = decimal.Parse(Console.ReadLine());
            int godinaJivot = int.Parse(Console.ReadLine());

            decimal pari4etnaGodina = 0;
            decimal pariNe4etnaGodina = 0;
            int godiniIvan4o = 17;

            for (int godina = 1800; godina <= godinaJivot; godina++)
            {
                godiniIvan4o++;
                if (godina % 2 == 0)
                {
                    pari4etnaGodina += 12000;
                }
                if (godina % 2 == 1)
                {
                    pariNe4etnaGodina += 12000 + 50 * godiniIvan4o;
                }
            }
            decimal pariOb6to = pari4etnaGodina + pariNe4etnaGodina;
            if (pari >= pariOb6to)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", pari - pariOb6to);
            }
            if (pari < pariOb6to)
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", pariOb6to - pari);
            }
        }
        /// <summary>
        /// 17 Iuli 2016  Zada4a 2
        /// </summary>
        static void Rekolta()
        {
            int kvMGrozde = int.Parse(Console.ReadLine());
            double grozdeZaEdinKvM = double.Parse(Console.ReadLine());
            int nujniLitriVino = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());

            double ob6toGrozde = (double)kvMGrozde * grozdeZaEdinKvM;
            double grozdeZaVino = 0.4 * ob6toGrozde;
            double litriVino = grozdeZaVino / 2.5;
            if (nujniLitriVino > litriVino)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(nujniLitriVino - litriVino));

            }
            if (nujniLitriVino <= litriVino)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litriVino));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(litriVino - nujniLitriVino), Math.Ceiling((litriVino - nujniLitriVino) / broiRabotnici));
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    11
        /// </summary>
        static void EdnakviDvoiki()
        {
            int n = int.Parse(Console.ReadLine());

            int previous = 0;
            bool ravni = true;

            int bestDiff = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int purvo = int.Parse(Console.ReadLine());
                int vtoro = int.Parse(Console.ReadLine());

                int current = purvo + vtoro;

                if (current != previous && i != 1)
                {
                    ravni = false;
                }

                if (Math.Abs(current - previous) > bestDiff && i != 1)
                {
                    bestDiff = Math.Abs(current - previous);
                }

                previous = current;
            }
            if (ravni)
            {
                Console.WriteLine($"Yes, value={previous}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={bestDiff}");
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    10
        /// </summary>
        static void ChetniNe4etniPozicii()
        {
            int n = int.Parse(Console.ReadLine());
            double sum4etni = 0;
            double chetniMin = double.MaxValue;
            double chetniMax = double.MinValue;
            double sumNe4etni = 0;
            double ne4etniMin = double.MaxValue;
            double ne4etniMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double chislo = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sumNe4etni = sumNe4etni + chislo;
                    if (chislo > ne4etniMax)
                    {
                        ne4etniMax = chislo;
                    }
                    if (chislo < ne4etniMin)
                    {
                        ne4etniMin = chislo;
                    }
                }
                if (i % 2 == 0)
                {
                    sum4etni = sum4etni + chislo;
                    if (chislo > chetniMax)
                    {
                        chetniMax = chislo;
                    }
                    if (chislo < chetniMin)
                    {
                        chetniMin = chislo;
                    }
                }
            }
            if (n <= 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin No");
                Console.WriteLine("OddMax No");
            }
            else
            {
                Console.WriteLine("OddSum={0}", sumNe4etni);
                Console.WriteLine("OddMin={0}", ne4etniMin);
                Console.WriteLine("OddMax={0}", ne4etniMax);
            }

            if (n <= 1)
            {
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin No");
                Console.WriteLine("EvenMax No");
            }
            else
            {
                Console.WriteLine("EvenSum={0}", sum4etni);
                Console.WriteLine("EvenMin={0}", chetniMin);
                Console.WriteLine("EvenMax={0}", chetniMax);
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    9
        /// </summary>
        static void ElementRavenNasumataNaOstanalite()
        {
            int n = int.Parse(Console.ReadLine());
            int naiGolqmo4islo = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo > naiGolqmo4islo)
                {
                    naiGolqmo4islo = chislo;
                }
                sum = sum + chislo;
            }
            if (sum - naiGolqmo4islo == naiGolqmo4islo)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", naiGolqmo4islo);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(naiGolqmo4islo - (sum - naiGolqmo4islo)));
            }
        }
        /// <summary>
        /// Povtoreniq cikli   Zada4a    9
        /// </summary>
        static void SumiraneNaGlasniteBukvi()
        {
            string input = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
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

                if (plod == "banana")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 2.7m);
                }
                else if (plod == "apple")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 1.25m);
                }
                else if (plod == "orange")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 0.9m);
                }
                else if (plod == "grapefruit")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 1.6m);
                }
                else if (plod == "kiwi")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 3m);
                }
                else if (plod == "pineapple")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 5.6m);
                }
                else if (plod == "grapes")
                {
                    Console.WriteLine("{0:f2}", koli4estvo * 4.2m);
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        /// <summary>
        /// Po-slojni logi4eski proverki   Zada4a   7
        /// </summary>
        static void To4kaNaStranaNaPravougulnik()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x <= x2 && x >= x1 && y == y1) || (x <= x2 && x >= x1 && y == y2)
                || (y <= y2 && y >= y1 && x == x1) || (y <= y2 && y >= y1 && x == x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }

        /// <summary>
        /// Po-slojno logi4eski Proverki Zada4a   6
        /// </summary>
        static void Nevalidno4islo()
        {
            int a = int.Parse(Console.ReadLine());
            if ((a >= 100 && a <= 200) || a == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        /// <summary>
        /// Po slojni logi4eski proverki zada4a   5
        /// </summary>
        static void PLOdIliZelen4uk()
        {
            string plodIliZelen4uk = Console.ReadLine();

            if (plodIliZelen4uk == "banana" || plodIliZelen4uk == "apple" || plodIliZelen4uk == "kiwi" ||
                plodIliZelen4uk == "cherry" || plodIliZelen4uk == "lemon" || plodIliZelen4uk == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (plodIliZelen4uk == "tomato" || plodIliZelen4uk == "cucumber" || plodIliZelen4uk == "pepper" ||
                plodIliZelen4uk == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }

        /// <summary>
        /// To4ka v Pravougulnik   Zada4a   4
        /// </summary>
        static void POSlojniLogi4eskiProverki()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x <= x2 && x >= x1 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void DeleneBezOstatukk()
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
    }
}