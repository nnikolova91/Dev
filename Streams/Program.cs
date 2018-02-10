using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapacitet = int.Parse(Console.ReadLine());
            int broiBunceri = 0;
            Queue<string> bunceri = new Queue<string>();
            Queue<int> orujiq = new Queue<int>();
            Dictionary<string, Queue<int>> dic = new Dictionary<string, Queue<int>>();
            int sumOrujiq = 0;
            do
            {
                var vh = Console.ReadLine();
                if (vh == "Bunker Revision")
                {
                    break;
                }
                var vhod = vh.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                for (int i = 0; i < vhod.Length; i++)
                {
                    try
                    {
                        int orujie = int.Parse(vhod[i]);
                        if (sumOrujiq<kapacitet && sumOrujiq+orujie<=kapacitet)
                        {
                            orujiq.Enqueue(orujie);
                            sumOrujiq += orujie;
                        }
                        else if (orujie>kapacitet && dic.Count>1)
                        {
                            Console.WriteLine($"{bunceri.Dequeue()} -> Empty");
                        }
                        else if (orujie<= kapacitet && sumOrujiq+orujie>kapacitet )
                        {
                            if (sumOrujiq< kapacitet || (sumOrujiq==kapacitet && dic.Count ==1))
                            {
                                do
                                {
                                    int or = orujiq.ElementAt(0);
                                    orujiq.Dequeue();
                                    sumOrujiq -= or;
                                    if (orujiq.Sum() + orujie <= kapacitet)
                                    {
                                        orujiq.Enqueue(orujie);
                                        sumOrujiq += orujie;
                                        break;
                                    }
                                } while (true);
                            }
                            else if (sumOrujiq == kapacitet && dic.Count>1)
                            {
                                string bun = bunceri.Dequeue();
                                dic[bun] = orujiq;
                                for (int k = 0; k < dic[bun].Count; k++)
                                {
                                    if (k< dic[bun].Count-1)
                                    {
                                        Console.Write($"{dic[bun].ElementAt(k)}, ");
                                    }
                                    else
                                    {
                                        Console.Write($"{dic[bun].ElementAt(k)}");
                                    }
                                }
                                dic.Remove(bun);
                                bunceri.Dequeue();
                                orujiq.Clear();
                                orujiq.Enqueue(orujie);
                            }
                        }

                    }
                    catch (Exception)
                    {

                        string buncer = vhod[i];
                        bunceri.Enqueue(buncer);
                        dic.Add(vhod[i], new Queue<int>());
                    }
                    
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
            string purvona4File = "sliceMe.mp4";
            //string failNa4asti = "slicePart.mp4";
            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            Slice(purvona4File, destinationDirectory, parts);
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
                    using (FileStream fsNew = new FileStream($"{destinationDirectory}/Part-{i}.avi", FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
        }

        private static void StreamsZad4()
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

        private static void StreamsZad3()
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

        private static void LineNumbers()
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

        private static void OddLines()
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
