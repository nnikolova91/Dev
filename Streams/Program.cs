using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.RegularExpressions;

namespace Streams
{
    class Program
    {
        static void Main()
        {
            int targetIndex = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> dic = new Dictionary<string, Dictionary<string, string>>();
            string killed = "";
            do
            {
                var vhod = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var command = vhod[0].Split(' ').ToArray();
                if ( command[0]== "Kill")
                {
                    killed = command[1];
                    break;
                }
                if (!dic.ContainsKey(vhod[0]))
                {
                    dic.Add(vhod[0], new Dictionary<string, string>());
                }
                if (dic.ContainsKey(vhod[0]))
                {
                    for (int i = 1; i < vhod.Length; i++)
                    {
                        var danni = vhod[i].Split(':').ToArray();
                        if (!dic[vhod[0]].ContainsKey(danni[0]))
                        {
                            dic[vhod[0]].Add(danni[0], danni[1]);
                        }
                        else if (dic[vhod[0]].ContainsKey(danni[0]))
                        {
                            try
                            {
                                int novoChislo = int.Parse(danni[1]);
                                int predi6noChislo = int.Parse(dic[vhod[0]][danni[0]]);
                                if (novoChislo > predi6noChislo)
                                {
                                    dic[vhod[0]][danni[0]] = novoChislo.ToString();
                                }
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                            
                        }
                    }
                }
            } while (true);
            int totalLength = 0;
            Console.WriteLine($"Info on {killed}:");
            foreach (var k in dic[killed].OrderBy(x=>x.Key))
            {
                totalLength += k.Key.Length + k.Value.Length;
                Console.WriteLine($"---{k.Key}: {k.Value}");
            }
            Console.WriteLine($"Info index: {totalLength}");
            if (totalLength>=targetIndex)
            {
                Console.WriteLine("Proceed");
            }
            if (totalLength < targetIndex)
            {
                Console.WriteLine($"Need {targetIndex-totalLength} more info.");
            }
        }

        private static void ExamZad3()
        {
            string pattern = @"[\[{]{1}[^\d]*([\d\s]{3,})[^\d]*[\]}]{1}";  //@"[\[{]{1}[^]|}\d]*([\d\s]{3,})[^]|}]*[\]}]{1}";
            int n = int.Parse(Console.ReadLine());

            string text = "";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input.Length == 16)
                {
                    text += input;
                }

            }


            Regex r = new Regex(pattern);
            //Match match = r.Match(input);

            MatchCollection matches = r.Matches(text);


            foreach (Match m in matches)
            {
                if (m.Groups[1].Length % 3 == 0)
                {
                    string chislo = m.Groups[1].Value;
                    string tricStr = "";
                    int tricifreno = 0;
                    char cifra = 'a';
                    int brr = 0;
                    for (int i = 0; i < chislo.Length; i++)
                    {
                        if (brr < 3)
                        {
                            cifra = chislo[i];
                            tricStr += cifra;
                            brr++;
                            if (i == chislo.Length - 1)
                            {
                                tricifreno = int.Parse(tricStr) - m.Length;
                                char bukvi4ka = (char)tricifreno;
                                Console.Write(bukvi4ka);
                            }
                        }
                        else
                        {
                            brr = 0;
                            tricifreno = int.Parse(tricStr) - m.Length;
                            char bukvi4ka = (char)tricifreno;
                            Console.Write(bukvi4ka);
                            tricifreno = 0;
                            tricStr = "";

                            cifra = chislo[i];
                            tricStr += cifra;
                            brr++;
                        }


                    }


                }
                //Console.WriteLine(m);
                //sum += int.Parse(m.Groups[2].Value);
            }
        }

        static void Zad2Ujas()
        {
            Func<char[,], int, int, char, int, int, char[,]> Premestvane = (char[,] prediMestene, int row, int col, char comand, int redNik, int colNik) =>
            {
                char[,] mestene = new char[row, col];

                for (int r = 0; r < row; r++)
                {
                    for (int c = 0; c < col; c++)
                    {
                        if (mestene[r, c] == 'd' && (c != 0 || c != col - 1))
                        {
                            mestene[r, c - 1] = 'd';
                            mestene[r, c] = '.';
                        }
                        else if (mestene[r, c] == 'd' && (c == 0 || c == col - 1))
                        {
                            mestene[r, c] = 'b';
                        }
                        else if (mestene[r, c] == 'b' && (c != 0 || c != col - 1))
                        {
                            mestene[r, c + 1] = 'b';
                            mestene[r, c] = '.';
                        }
                        else if (mestene[r, c] == 'b' && (c == 0 || c == col - 1))
                        {
                            mestene[r, c] = 'd';
                        }
                        else if (mestene[r, c] == 'S')
                        {
                            if (comand == 'U' && r - 1 >= 0)
                            {
                                if (r - 1 == redNik && c == colNik)
                                {
                                    mestene[r - 1, c] = 'Y';
                                    mestene[r, c] = '.';
                                }
                                mestene[r - 1, c] = 'S';
                                mestene[r, c] = '.';
                            }
                            else if (comand == 'D' && r + 1 <= mestene.GetLength(1) - 1)
                            {
                                if (r + 1 == redNik && c == colNik)
                                {
                                    mestene[r + 1, c] = 'Y';
                                    mestene[r, c] = '.';
                                }
                                mestene[r + 1, c] = 'S';
                                mestene[r, c] = '.';
                            }
                            else if (comand == 'L' && c - 1 >= 0)
                            {
                                if (r == redNik && c - 1 == colNik)
                                {
                                    mestene[r, c - 1] = 'Y';
                                    mestene[r, c] = '.';
                                }
                                mestene[r, c - 1] = 'S';
                                mestene[r, c] = '.';
                            }
                            else if (comand == 'R' && c + 1 <= mestene.GetLength(0) - 1)
                            {
                                if (r == redNik && c + 1 == colNik)
                                {
                                    mestene[r, c + 1] = 'Y';
                                    mestene[r, c] = '.';
                                }
                                mestene[r, c + 1] = 'S';
                                mestene[r, c] = '.';
                            }
                            else if (comand == 'W')
                            {

                            }

                        }
                    }
                }

                return mestene;
            };

            int n = int.Parse(Console.ReadLine());
            string redd = Console.ReadLine();
            int coloni = redd.Length;
            char[,] matrix = new char[n, coloni];
            int redN = 0;
            int colN = 0;
            for (int i = 0; i < coloni; i++)
            {
                matrix[0, i] = redd[i];
                if (matrix[0, i] == 'N')
                {
                    redN = 0;
                    colN = i;
                }
            }
            for (int i = 1; i < n; i++)
            {
                string sledva6tRed = Console.ReadLine();
                for (int k = 0; k < sledva6tRed.Length; k++)
                {
                    matrix[i, k] = sledva6tRed[k];
                    if (matrix[i, i] == 'N')
                    {
                        redN = i;
                        colN = k;
                    }
                }
            }
            string command = Console.ReadLine();
            for (int i = 0; i < command.Length; i++)
            {
                //char[,] mestene = new char[row, col];

                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < coloni; c++)
                    {
                        if (matrix[r, c] == 'd' && (c != 0 || c != coloni - 1))
                        {
                            matrix[r, c - 1] = 'd';
                            matrix[r, c] = '.';
                            c--;
                        }
                        else if (matrix[r, c] == 'd' && (c == 0 || c == coloni - 1))
                        {
                            matrix[r, c] = 'b';
                        }
                        else if (matrix[r, c] == 'b' && (c + 1 > 0 || c + 1 <= coloni - 1))
                        {
                            matrix[r, c + 1] = 'b';
                            matrix[r, c] = '.';
                            c++;
                        }
                        else if (matrix[r, c] == 'b' && (c == 0 || c == coloni - 1))
                        {
                            matrix[r, c] = 'd';
                        }
                        else if (matrix[r, c] == 'S')
                        {
                            if (command[i] == 'U' && r - 1 >= 0)
                            {
                                if (r - 1 == redN && c == colN)
                                {
                                    matrix[r - 1, c] = 'Y';
                                    matrix[r, c] = '.';
                                }
                                else
                                {
                                    matrix[r - 1, c] = 'S';
                                    matrix[r, c] = '.';
                                }
                                r--;
                            }
                            else if (command[i] == 'D' && r + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (r + 1 == redN && c == colN)
                                {
                                    matrix[r + 1, c] = 'Y';
                                    matrix[r, c] = '.';
                                }
                                else
                                {
                                    matrix[r + 1, c] = 'S';
                                    matrix[r, c] = '.';
                                }
                                r++;
                            }
                            else if (command[i] == 'L' && c - 1 >= 0)
                            {
                                if (r == redN && c - 1 == colN)
                                {
                                    matrix[r, c - 1] = 'Y';
                                    matrix[r, c] = '.';
                                }
                                else
                                {
                                    matrix[r, c - 1] = 'S';
                                    matrix[r, c] = '.';
                                }
                                c--;
                            }
                            else if (command[i] == 'R' && c + 1 <= matrix.GetLength(0) - 1)
                            {
                                if (r == redN && c + 1 == colN)
                                {
                                    matrix[r, c + 1] = 'Y';
                                    matrix[r, c] = '.';
                                }
                                else
                                {
                                    matrix[r, c + 1] = 'S';
                                    matrix[r, c] = '.';
                                }
                                c++;

                            }
                            else if (command[i] == 'W')
                            {

                            }

                        }
                    }
                }



                char[,] matrix1 = new char[n, coloni];
                bool izlez = false;
                Premestvane(matrix, n, coloni, command[i], redN, colN);

                for (int r = 0; r < n; r++)
                {
                    int redS = 0;
                    int colS = 0;
                    for (int c = 0; c < coloni; c++)
                    {
                        if (matrix1[r, c] == 'S')
                        {
                            redS = r;
                            colS = c;
                        }
                    }
                    for (int k = 0; k < coloni; k++)
                    {
                        if (matrix1[r, k] == 'N')
                        {
                            matrix1[r, k] = 'X';
                            Console.WriteLine("Nikoladze killed!");///
                            izlez = true;
                            break;
                        }
                        if (matrix1[r, k] == 'b' && k > colS)
                        {
                            matrix1[r, k] = '.';
                        }
                        else if (matrix1[r, k] == 'b' && k < colS)
                        {
                            matrix[redS, colS] = 'X';
                            Console.WriteLine($"Sam died at {redS}, {colS}");
                            izlez = true;
                            break;
                        }
                        if (matrix1[r, k] == 'd' && k < colS)
                        {
                            matrix[r, k] = '.';
                        }
                        else if (matrix1[r, k] == 'd' && k > colS)
                        {
                            matrix[redS, colS] = 'X';
                            Console.WriteLine($"Sam died at {redS}, {colS}");
                            izlez = true;
                            break;
                        }
                    }
                    if (izlez == true)
                    {
                        break;
                    }
                }
                if (izlez == true)
                {
                    for (int r = 0; r < n; r++)
                    {
                        for (int c = 0; c < coloni; c++)
                        {
                            Console.Write($"{matrix1[r, c]} ");
                        }
                        Console.WriteLine();
                    }
                }
                matrix = matrix1;
            }
        }

        static void Zad1Izp()
        {
            int cenaKur6um = int.Parse(Console.ReadLine());
            int razmerNaPistoleta = int.Parse(Console.ReadLine());
            var bulets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var kliu4alki = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int cenaRazuznavane = int.Parse(Console.ReadLine());

            //List<int> kur6umi = new Stack<int>(bulets);
            //Queue<int> kliu4alki = new Queue<int>(kliu4alkii);
            int brIzrazhodvaniKur6umi = razmerNaPistoleta;
            do
            {
                if (bulets[bulets.Count - 1] <= kliu4alki[0])
                {

                    kliu4alki.RemoveAt(0);
                    Console.WriteLine("Bang!");
                    bulets.RemoveAt(bulets.Count - 1);
                    cenaRazuznavane -= cenaKur6um;
                    brIzrazhodvaniKur6umi--;
                }
                else if (bulets[bulets.Count - 1] > kliu4alki[0])
                {
                    Console.WriteLine("Ping!");
                    bulets.RemoveAt(bulets.Count - 1);
                    cenaRazuznavane -= cenaKur6um;
                    brIzrazhodvaniKur6umi--;
                }
                if (brIzrazhodvaniKur6umi == 0 && cenaRazuznavane >= cenaKur6um * razmerNaPistoleta && (bulets.Count != 0))
                {
                    Console.WriteLine("Reloading!");
                    brIzrazhodvaniKur6umi = razmerNaPistoleta;
                }
                if (kliu4alki.Count == 0)
                {
                    Console.WriteLine($"{brIzrazhodvaniKur6umi} bullets left. Earned ${cenaRazuznavane}");
                    break;
                }
                if (bulets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {kliu4alki.Count}");
                    break;
                }
            } while (true);
        }
        /// <summary>
        /// Izpit 3 septemnber 2017 Zad  1
        /// </summary>
        static void DangerousFloor()
        {
            string[,] matrix = new string[8, 8];
            for (int r = 0; r < 8; r++)
            {
                var vhod = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int c = 0; c < 8; c++)
                {
                    matrix[r, c] = vhod[c];
                }
            }
            do
            {
                var vh = Console.ReadLine();

                if (vh == "END")
                {
                    break;
                }

                string figurka = vh[0].ToString();
                int redFig = int.Parse(vh[1].ToString());
                int colFig = int.Parse(vh[2].ToString());
                int tursenRed = int.Parse(vh[4].ToString());
                int tursenaCil = int.Parse(vh[5].ToString());



                if (matrix[redFig, colFig] == figurka)
                {
                    bool vlizaVQ = false;
                    if (figurka == "K")
                    {
                        if ((tursenRed == redFig - 1 && tursenaCil >= colFig - 1 && tursenaCil <= colFig + 1) ||
                                (tursenRed == redFig - 1 && tursenaCil >= colFig - 1 && tursenaCil <= colFig + 1) ||
                                (tursenaCil == colFig - 1 && tursenRed >= redFig - 1 && tursenRed <= redFig + 1) ||
                                (tursenaCil == colFig + 1 && tursenRed >= redFig - 1 && tursenRed <= redFig + 1))
                        {
                            try
                            {
                                matrix[tursenRed, tursenaCil] = "K";
                                matrix[redFig, colFig] = "x";

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Move go out of board!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid move!");
                        }
                    }
                    else if (figurka == "R" || figurka == "Q")
                    {
                        if ((redFig == tursenRed && tursenaCil >= 0 && tursenaCil < 8)
                            || (colFig == tursenaCil && tursenRed >= 0 && tursenRed < 8))
                        {
                            if (figurka == "Q")
                            {
                                vlizaVQ = true;
                            }
                            else
                            {
                                matrix[tursenRed, tursenaCil] = "R";
                                matrix[redFig, colFig] = "x";
                            }

                        }
                        else if ((tursenaCil >= 8 || tursenaCil < 0 || tursenRed >= 8 || tursenRed < 0) && figurka != "Q")
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                        else
                        {
                            if (figurka != "Q")
                            {
                                Console.WriteLine("Invalid move!");
                            }

                        }
                    }

                    if (figurka == "B" || figurka == "Q")
                    {
                        if ((figurka == "Q" && vlizaVQ == false) || figurka == "B")
                        {
                            bool vliza = false;

                            int c = colFig;
                            int r = redFig;
                            //gore i dqsno
                            do
                            {
                                if (tursenRed == r && tursenaCil == c)
                                {
                                    vliza = true;
                                    vlizaVQ = true;
                                }
                                r--;
                                c++;
                            } while (r >= 0 || c < 8);

                            if (vliza == false)
                            {

                                c = colFig;
                                r = redFig;
                                //gore i dqsno
                                do
                                {
                                    if (tursenRed == r && tursenaCil == c)
                                    {
                                        vliza = true;
                                        vlizaVQ = true;
                                    }
                                    r--;
                                    c--;
                                } while (r >= 0 || c >= -1);
                            }
                            if (vliza == false)
                            {

                                c = colFig;
                                r = redFig;
                                //dolu i dqsno
                                do
                                {
                                    if (tursenRed == r && tursenaCil == c)
                                    {
                                        vliza = true;
                                        vlizaVQ = true;
                                    }
                                    r++;
                                    c++;
                                } while (r < 8 || c < 8);
                            }
                            if (vliza == false)
                            {

                                c = colFig;
                                r = redFig;
                                //dolu i lqvo
                                do
                                {
                                    if (tursenRed == r && tursenaCil == c)
                                    {
                                        vliza = true;
                                        vlizaVQ = true;
                                    }
                                    r++;
                                    c--;
                                } while (r < 8 || c >= 0);
                            }
                            if (figurka != "Q")
                            {
                                if (vliza == true)
                                {
                                    matrix[tursenRed, tursenaCil] = figurka;
                                    matrix[redFig, colFig] = "x";
                                }
                                else if (tursenRed < 0 || tursenRed > 7 || tursenaCil < 0 || tursenaCil > 7)
                                {
                                    Console.WriteLine("Move go out of board!");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid move!");
                                }
                            }

                        }


                    }
                    if (figurka == "Q")
                    {
                        if (vlizaVQ == true)
                        {
                            matrix[tursenRed, tursenaCil] = figurka;
                            matrix[redFig, colFig] = "x";
                        }
                        else if (tursenRed < 0 || tursenRed > 7 || tursenaCil < 0 || tursenaCil > 7)
                        {
                            Console.WriteLine("Move go out of board!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid move!");
                        }
                    }
                    if (figurka == "P")
                    {
                        if (tursenaCil == colFig && tursenRed == redFig - 1 && tursenRed >= 0)
                        {
                            matrix[tursenRed, tursenaCil] = figurka;
                            matrix[redFig, colFig] = "x";
                        }
                        else if (tursenRed < 0 || tursenRed > 7 || tursenaCil < 0 || tursenaCil > 7)
                        {
                            Console.WriteLine("Move go out of board!");

                        }
                        else
                        {
                            Console.WriteLine("Invalid move!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("There is no such a piece!");
                }
            } while (true);
        }

        /// <summary>
        /// 3 September 1017 CryptoMaster Zad 2
        /// </summary>
        static void CryptoMaster()
        {
            var vhod = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int broi = 1;
            int maxBroi = 1;
            for (int i = 0; i < vhod.Length; i++)
            {

                for (int k = 1; k < vhod.Length; k++)
                {
                    int r = i;
                    do
                    {

                        if (r + k > vhod.Length - 1)
                        {
                            if ((r + k) - vhod.Length != i)
                            {
                                if (vhod[r] < vhod[(r + k) - vhod.Length])
                                {
                                    broi++;
                                    r = (r + k) - vhod.Length;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (r + k < vhod.Length)
                        {
                            if (vhod[r] < vhod[r + k])
                            {
                                broi++;
                                r += k;
                            }
                            else
                            {
                                break;
                            }
                        }

                    } while (true);



                    if (broi > maxBroi)
                    {
                        maxBroi = broi;

                    }
                    if (maxBroi > vhod.Length - 1)
                    {
                        break;
                    }
                    broi = 1;
                }
            }
            Console.WriteLine(maxBroi);
        }

        static void CubRub()
        {
            int n = int.Parse(Console.ReadLine());
            long liceNaKub = n * n * n;
            long broiTo4ki = 0;
            int broiRedove = 0;
            int[,] matrix = new int[3, 1000];

            do
            {
                var vhod = Console.ReadLine();
                if (vhod == "Analyze")
                {
                    break;
                }

                var vh = vhod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                if ((vh[0] >= 0 && vh[0] <= n) && (vh[1] > 0 && vh[1] < n) && (vh[2] > 0 && vh[2] < n) ||
                    (vh[0] > 0 && vh[0] < n) && (vh[1] > 0 && vh[1] < n) && (vh[2] >= 0 && vh[2] <= n) ||
                    (vh[0] > 0 && vh[0] < n) && (vh[1] >= 0 && vh[1] <= n) && (vh[2] > 0 && vh[2] < n))

                //if (vh[0]>=0 && vh[0]<=n && vh[1]>=0 && vh[1]<=n && vh[2]>=0 && vh[2]<=n)
                {
                    bool imaTakavaTo4ka = false;

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[0, col] == vh[0] && matrix[1, col] == vh[1] && matrix[2, col] == vh[2])
                        {
                            imaTakavaTo4ka = true;
                            break;
                        }
                    }
                    if (imaTakavaTo4ka == false)
                    {
                        liceNaKub--;
                        broiTo4ki += vh[3];

                        matrix[0, broiRedove] = vh[0];
                        matrix[1, broiRedove] = vh[1];
                        matrix[2, broiRedove] = vh[2];
                        broiRedove++;
                    }

                }

            } while (true);

            Console.WriteLine(broiTo4ki);
            Console.WriteLine(liceNaKub);
        }

        static void ShahSKoneIzpit()
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            //4etene na konete ot konzolata
            for (int i = 0; i < n; i++)
            {
                var red = Console.ReadLine();
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = red[k].ToString();
                }
            }
            int broiPremahvaniKone = 0;
            do
            {
                int red = 0;
                int colona = 0;
                int maxBroiZasegnatiKonq = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {

                        int broiZasegnatiKonq = 0;

                        if (matrix[row, col] == "K")
                        {
                            if (row + 2 <= matrix.GetLength(0) - 1 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 2, col + 1] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }

                            }
                            if (row + 2 <= matrix.GetLength(0) - 1 && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row - 2 >= 0 && col + 1 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 2, col + 1] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row + 1 <= matrix.GetLength(0) - 1 && col + 2 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row + 1, col + 2] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row - 1 >= 0 && col + 2 <= matrix.GetLength(1) - 1)
                            {
                                if (matrix[row - 1, col + 2] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row + 1 <= matrix.GetLength(0) - 1 && col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == "K")
                                {
                                    broiZasegnatiKonq++;
                                }
                            }
                            if (broiZasegnatiKonq > maxBroiZasegnatiKonq)
                            {
                                maxBroiZasegnatiKonq = broiZasegnatiKonq;
                                red = row;
                                colona = col;
                            }
                        }
                    }
                }

                if (maxBroiZasegnatiKonq > 0)
                {
                    matrix[red, colona] = "0";
                    broiPremahvaniKone++;
                }
                else
                {
                    break;
                }
            } while (true);

            Console.WriteLine(broiPremahvaniKone);
        }

        static void PredicateParty()
        {
            var hora = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            do
            {
                var comandi = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                if (comandi[0] == "Party!")
                {
                    break;
                }

                string bukvi = comandi[2];
                bool ednakviSa = true;

                if (comandi[0] == "Remove")
                {
                    if (comandi[1] == "StartsWith")
                    {
                        for (int k = 0; k < hora.Count; k++)
                        {
                            ednakviSa = true;
                            string chovec = hora[k];
                            for (int i = 0; i < bukvi.Length; i++)
                            {
                                if (bukvi[i] != chovec[i])
                                {
                                    ednakviSa = false;
                                }
                            }
                            if (ednakviSa == true)
                            {
                                hora.RemoveAt(k);
                            }
                        }

                    }
                    else if (comandi[1] == "EndsWith")
                    {
                        for (int k = 0; k < hora.Count; k++)
                        {
                            ednakviSa = true;
                            string chovec = hora[k];
                            for (int i = bukvi.Length - 1, r = chovec.Length - 1; i >= 0; i--, r--)
                            {
                                if (bukvi[i] != chovec[i])
                                {
                                    ednakviSa = false;
                                }
                            }
                            if (ednakviSa == true)
                            {
                                hora.RemoveAt(k);
                            }
                        }
                    }
                    else if (comandi[1] == "Length")
                    {
                        int chislo = int.Parse(bukvi);
                        for (int i = 0; i < hora.Count; i++)
                        {
                            if (hora[i].Length == chislo)
                            {
                                hora.RemoveAt(i);

                                i--;
                            }
                        }
                    }
                }

                else if (comandi[0] == "Double")
                {
                    if (comandi[1] == "StartsWith")
                    {
                        for (int k = 0; k < hora.Count; k++)
                        {
                            ednakviSa = true;
                            string chovec = hora[k];
                            for (int i = 0; i < bukvi.Length; i++)
                            {
                                if (bukvi[i] != chovec[i])
                                {
                                    ednakviSa = false;
                                }
                            }
                            if (ednakviSa == true)
                            {
                                hora.Insert(0, hora[k]);
                                k++;
                            }
                        }

                    }
                    else if (comandi[1] == "EndsWith")
                    {
                        for (int k = 0; k < hora.Count; k++)
                        {
                            ednakviSa = true;
                            string chovec = hora[k];
                            for (int i = bukvi.Length - 1, r = chovec.Length - 1; i >= 0; i--, r--)
                            {
                                if (bukvi[i] != chovec[r])
                                {
                                    ednakviSa = false;
                                }
                            }
                            if (ednakviSa == true)
                            {
                                hora.Insert(0, hora[k]);
                                k++;
                            }
                        }
                    }
                    else if (comandi[1] == "Length")
                    {
                        int chislo = int.Parse(bukvi);
                        for (int i = 0; i < hora.Count; i++)
                        {
                            if (hora[i].Length == chislo)
                            {
                                hora.Insert(0, hora[i]);
                                i++;
                            }
                        }
                    }
                }
            } while (true);
            if (hora.Count > 0)
            {
                for (int i = 0; i < hora.Count; i++)
                {
                    if (i != hora.Count - 1)
                    {
                        Console.Write($"{hora[i]}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{hora[i]} are going to the party!");
                    }

                }
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static void StreamsZad()
        {
            int parts = int.Parse(Console.ReadLine());
            string file = "sliceMe.mp4";

            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            SliceGZip(file, destinationDirectory, parts);
            AssembleGzip(
                Directory.EnumerateFiles(destinationDirectory).ToList(),
                string.Empty);
        }

        static void SlicingFile_Zad_5()
        {
            int parts = int.Parse(Console.ReadLine());
            string purvona4File = "sliceMe.mp4";
            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            Slice(purvona4File, destinationDirectory, parts);

            var files = Directory.EnumerateFiles(destinationDirectory).ToList();

            Assemble(files, "");
        }

        static void SliceGZip(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream fsSourse = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    int size = (int)(fsSourse.Length / parts);
                    if (i == parts - 1)
                    {
                        size += (int)(fsSourse.Length % parts);
                    }

                    byte[] bytes = new byte[size];
                    int numBytesToRead = size;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSourse.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, $"Part -{i}.gz"), FileMode.Create, FileAccess.Write))
                    {
                        using (var gzipStream = new GZipStream(fsNew, CompressionMode.Compress))
                        {
                            gzipStream.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
        }

        static void AssembleGzip(List<string> files, string destinationDirectory)
        {
            using (FileStream decompressedFileStream = new FileStream(Path.Combine(destinationDirectory, "assembledDecompressed.avi"), FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (FileStream fsSourceCompressed = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    using (GZipStream decompressionStream = new GZipStream(fsSourceCompressed, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream fsSourse = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    int size = (int)(fsSourse.Length / parts);
                    if (i == parts - 1)
                    {
                        size += (int)(fsSourse.Length % parts);
                    }

                    byte[] bytes = new byte[size];
                    int numBytesToRead = size;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSourse.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, $"Part -{i}.avi"), FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, "assembled.avi"), FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (FileStream fsSource = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    {
                        // Read the source file into a byte array.
                        byte[] bytes = new byte[fsSource.Length];
                        int numBytesToRead = (int)fsSource.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            // Read may return anything from 0 to numBytesToRead.
                            int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                            // Break when the end of the file is reached.
                            if (n == 0)
                                break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }
                        numBytesToRead = bytes.Length;

                        // Write the byte array to the other FileStream.
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
        }

        private static void Streams_Zad_4()
        {
            string fsr = "copyme.png";
            string fsw = "copied.png";

            using (FileStream fsSource = new FileStream(fsr, FileMode.Open, FileAccess.Read))
            {
                // Read the source file into a byte array.
                byte[] bytes = new byte[fsSource.Length];
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                // Write the byte array to the other FileStream.
                using (FileStream fsNew = new FileStream(fsw, FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }
            }
        }

        private static void Streams_Zad_3()
        {
            var dic = new Dictionary<string, int>();
            using (var sr = new StreamReader("words.txt"))
            using (var sw = new StreamReader("text.txt"))
            {
                var dumiVTekst = sw.ReadToEnd().ToLower().Split(new char[] { ' ', ',', '-', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var duma = sr.ReadLine().ToLower();
                while (duma != null)
                {
                    int broi = dumiVTekst.Count(x => x == duma);
                    dic.Add(duma, broi);

                    duma = sr.ReadLine();
                }

                using (var writer = new StreamWriter("results.txt"))
                {
                    foreach (var d in dic.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{d.Key} - {d.Value}");
                    }
                }
            }
        }

        private static void LineNumbers_Zad_2()
        {
            using (var sr = new StreamReader("text.txt"))
            using (var sw = new StreamWriter("textNew.txt"))
            {
                int lineCounter = 1;
                string line = sr.ReadLine();

                while (line != null)
                {
                    sw.WriteLine($"Line {lineCounter}: {line}");

                    line = sr.ReadLine();
                    lineCounter++;
                }
            }
        }

        private static void OddLines_Zad_1()
        {
            using (var sr = new StreamReader("text.txt"))
            {
                int counter = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    line = sr.ReadLine();
                    counter++;
                }
            }
        }
    }
}
