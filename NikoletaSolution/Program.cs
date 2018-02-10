using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace NikoletaSolution
{
    class Program
    {
        static void Main()
        {
            var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse).ToArray();
            var rows = vhod[0];
            var columns = vhod[1];

            List<List<int>> jagged = new List<List<int>>();

            int broi = 1;
            for (int r = 0; r < rows; r++)
            {
                jagged.Add(new List<int>());

                for (long c = 0; c < columns; c++)
                {
                    jagged[r].Add(broi++);
                }
            }

            do
            {
                var v = Console.ReadLine().ToLower();
                if (v == "nuke it from orbit")
                {
                    break;
                }
                var vh = v.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                long row = vh[0];
                long col = vh[1];
                long radius = vh[2];

                if (radius >= 0)
                {
                    //bomb row
                    if (row >= 0 && jagged.Count > row)
                    {
                        for (long i = col - radius; i <= col + radius; i++)
                        {
                            if (i >= 0 && jagged.Count > row && jagged[(int)row].Count > i)
                            {
                                jagged[(int)row][(int)i] = 0;
                            }
                        }
                    }

                    //bomb col
                    if (col >= 0)
                    {
                        for (long i = row - radius; i <= row + radius; i++)
                        {
                            if (i >= 0 && jagged.Count > i && jagged[(int)i].Count > col)
                            {
                                jagged[(int)i][(int)col] = 0;
                            }
                        }
                    }

                    for (int i = 0; i < jagged.Count; i++)
                    {
                        jagged[i] = jagged[i].Where(num => num != 0).ToList();
                    }

                    jagged = jagged.Where(list => list.Count > 0).ToList();
                }
            } while (true);

            foreach (var list in jagged.Where(row => row.Count > 0))
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }
        
        /// <summary>
        /// Multidimentional Array Exercice    Zad10
        /// </summary>
        static void MultidimentionalArrayExerciceZad10()
        {
            double demage = double.Parse(Console.ReadLine());
            int to4kiIgra4 = 18500;
            double to4kiHeigan = 3000000;
            int[] moetoMqsto = new int[2] { 7, 7 };

            bool udyr = false;
            do
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int redNaUdar = int.Parse(vhod[1]);
                int colNaUdar = int.Parse(vhod[2]);
                string imeUdyr = vhod[0];

                int na4Red = redNaUdar - 1;
                int kraiRed = redNaUdar + 1;
                int na4Col = colNaUdar - 1;
                int kraiCol = colNaUdar + 1;

                if (na4Red < 0)
                {
                    na4Red = 0;
                }
                if (na4Col < 0)
                {
                    na4Col = 0;
                }
                if (kraiRed > 14)
                {
                    kraiRed = 14;
                }
                if (kraiCol > 14)
                {
                    kraiCol = 14;
                }

                for (int r = na4Red; r < kraiRed; r++)
                {
                    for (int c = na4Col; c < kraiCol; c++)
                    {
                        if (r == moetoMqsto[0] && c == moetoMqsto[1])
                        {

                        }
                    }
                }
                //int na4Red = redNaUdar - 1;
                //int kraiRed = redNaUdar + 1;
                //int na4Col = colNaUdar - 1;
                //int kraiCol = colNaUdar + 1;
                //if (redNaUdar >= 0 && redNaUdar <= 14 && colNaUdar >= 0 && colNaUdar <= 14)
                //{
                //    if (na4Red < 0)
                //    {
                //        na4Red = 0;
                //    }
                //    if (na4Col < 0)
                //    {
                //        na4Col = 0;
                //    }
                //    if (kraiRed > 14)
                //    {
                //        kraiRed = 14;
                //    }
                //    if (kraiCol > 14)
                //    {
                //        kraiCol = 14;
                //    }
                //    ///
                //
                //    if (redNaUdar == moetoMqsto[0] && colNaUdar == moetoMqsto[1])
                //    {
                //
                //
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //            imeUdyr = "Plague Cloud";
                //            udyr = false;
                //        }
                //
                //        if (imeUdyr == "Eruption")
                //        {
                //            to4kiIgra4 -= 6000;
                //        }
                //        else
                //        {
                //            to4kiIgra4 -= 3500;
                //            udyr = true;
                //        }
                //
                //    }
                //    else if (moetoMqsto[0] == na4Red && moetoMqsto[1] >= na4Col && moetoMqsto[1] <= kraiCol)
                //    {
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //        }
                //        if (moetoMqsto[0] - 1 >= 0)
                //        {
                //            moetoMqsto[0] = moetoMqsto[0] - 1;
                //        }
                //
                //        else
                //        {
                //
                //            if (imeUdyr == "Cloud")
                //            {
                //                to4kiIgra4 -= 3500;
                //                imeUdyr = "Plague Cloud";
                //                udyr = false;
                //            }
                //            else if (imeUdyr == "Eruption")
                //            {
                //                to4kiIgra4 -= 6000;
                //            }
                //
                //        }
                //
                //    }
                //    else if (moetoMqsto[1] == kraiCol && moetoMqsto[0] >= na4Red && moetoMqsto[0] <= kraiRed)
                //    {
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //        }
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //            udyr = false;
                //        }
                //        if (moetoMqsto[1] + 1 <= 14)
                //        {
                //            moetoMqsto[1] = moetoMqsto[1] + 1;
                //        }
                //        else
                //        {
                //            if (imeUdyr == "Cloud")
                //            {
                //                to4kiIgra4 -= 3500;
                //                imeUdyr = "Plague Cloud";
                //                udyr = false;
                //            }
                //            else if (imeUdyr == "Eruption")
                //            {
                //                to4kiIgra4 -= 6000;
                //            }
                //        }
                //    }
                //    else if (moetoMqsto[0] == kraiRed && moetoMqsto[1] >= na4Col && moetoMqsto[1] <= kraiCol)
                //    {
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //        }
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //            udyr = false;
                //        }
                //        if (moetoMqsto[0] + 1 <= 14)
                //        {
                //            moetoMqsto[0] = moetoMqsto[0] + 1;
                //        }
                //        else
                //        {
                //            if (imeUdyr == "Cloud")
                //            {
                //                to4kiIgra4 -= 3500;
                //                imeUdyr = "Plague Cloud";
                //                udyr = false;
                //            }
                //            else if (imeUdyr == "Eruption")
                //            {
                //                to4kiIgra4 -= 6000;
                //            }
                //        }
                //    }
                //    else if (moetoMqsto[1] == na4Col && moetoMqsto[0] >= na4Red && moetoMqsto[0] <= kraiRed)
                //    {
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //        }
                //        if (udyr == true)
                //        {
                //            to4kiIgra4 -= 3500;
                //            udyr = false;
                //        }
                //        if (moetoMqsto[1] - 1 >= 0)
                //        {
                //            moetoMqsto[1] = moetoMqsto[1] - 1;
                //        }
                //        else
                //        {
                //            if (imeUdyr == "Cloud")
                //            {
                //                to4kiIgra4 -= 3500;
                //                imeUdyr = "Plague Cloud";
                //                udyr = false;
                //            }
                //            else if (imeUdyr == "Eruption")
                //            {
                //                to4kiIgra4 -= 6000;
                //            }
                //        }
                //    }
                //}

                to4kiHeigan -= demage;
                if (to4kiIgra4 <= 0)
                {
                    Console.WriteLine($"Heigan: {to4kiHeigan:f2}");
                    Console.WriteLine($"Player: Killed by {imeUdyr}");
                    Console.WriteLine($"Final position: {moetoMqsto[0]}, {moetoMqsto[1]}");
                    break;
                }
                else if (to4kiHeigan <= 0)
                {
                    Console.WriteLine($"Heigan: Defeated!");
                    Console.WriteLine($"Player: {to4kiIgra4}");
                    Console.WriteLine($"Final position: {moetoMqsto[0]}, {moetoMqsto[1]}");
                    break;
                }


            } while (true);
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad9
        /// </summary>
        static void MultidimentionalArrayExerciceZad9()
        {
            var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rows = vhod[0];
            var columns = vhod[1];

            int[,] matrix = new int[rows, columns];
            int broi = 1;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = broi;
                    broi++;
                }
            }

            do
            {
                var v = Console.ReadLine();
                if (v == "Nuke it from orbit")
                {
                    break;
                }
                var vh = v.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                int row = vh[0];
                int col = vh[1];
                int radius = vh[2];

                //naGore
                if (row - radius < 0)
                {
                    radius = row;
                }
                for (int r = row; r >= row - radius; r--)
                {
                    matrix[r, col] = ' ';
                }
                radius = vh[2];

                //naDolu
                if (row + radius > rows - 1)
                {
                    radius = rows - 1 - row;
                }
                for (int r = row; r <= row + radius; r++)
                {
                    matrix[r, col] = ' ';
                }
                radius = vh[2];

                //naDqsno
                if (col + radius > columns - 1)
                {
                    radius = columns - 1 - col;
                }
                for (int c = col; c <= col + radius; c++)
                {
                    matrix[row, c] = ' ';
                }
                radius = vh[2];

                //naLqvo
                if (col - radius < 0)
                {
                    radius = col;
                }
                for (int c = col; c >= col - radius; c--)
                {
                    matrix[row, c] = ' ';
                }
                //////////////////////////
                int[,] matrix1 = new int[rows, columns];

                for (int r = 0; r < rows; r++)
                {
                    int iterM1 = 0;
                    for (int c = 0; c < columns; c++)
                    {
                        if (matrix[r, c] != ' ')
                        {
                            matrix1[r, iterM1] = matrix[r, c];
                            iterM1++;
                        }
                    }
                }
                matrix = matrix1;
            } while (true);

            int[][] jagArr = new int[rows][];

            var list = new List<int>();

            for (int r = 0; r < rows; r++)
            {
                //int indexJag = 0;
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] != 0)
                    {
                        list.Add(matrix[r, c]);
                        //jagArr[r][indexJag] = matrix[r, c];
                        //indexJag++;
                    }

                }
                jagArr[r] = list.ToArray();
                list.Clear();
            }

            //Print
            for (int r = 0; r < jagArr.GetLength(0); r++)
            {
                for (int c = 0; c < jagArr[r].Length; c++)
                {
                    Console.Write($"{jagArr[r][c]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad7
        /// </summary>
        static void MultidimentionalArrayExerciceZad7()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagArr1 = new int[n][];
            int[][] jagArr2 = new int[n][];

            int broi = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                if (i < n)
                {
                    jagArr1[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                }
                else
                {
                    jagArr2[broi] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    broi++;
                }
            }
            ///
            int sumOfCels1 = 0;
            for (int i = 0; i < n; i++)
            {
                sumOfCels1 += jagArr1[i].Length;
            }
            int sumOfCels2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumOfCels2 += jagArr2[i].Length;
            }

            ///
            int duljinaPurviRed = jagArr1[0].Length - 1 + jagArr2[0].Length;
            bool suvpadat = true;

            for (int i = 0; i < n; i++)
            {
                if ((jagArr1[i].Length - 1 + jagArr2[i].Length) != duljinaPurviRed)
                {
                    suvpadat = false;
                }
            }
            int[,] matrix = new int[n, duljinaPurviRed + 1];
            if (suvpadat == true)
            {

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < jagArr1[row].Length; col++)
                    {
                        matrix[row, col] = jagArr1[row][col];
                    }
                    for (int col1 = jagArr2[row].Length; col1 > 0; col1--)
                    {

                        matrix[row, duljinaPurviRed + 1 - col1] = jagArr2[row][col1 - 1];
                    }
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {sumOfCels1 + sumOfCels2}");
            }
            if (suvpadat == true)
            {
                for (int r = 0; r < n; r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        Console.Write($"{matrix[r, c]} ");
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private static void PoisonousPlants()
        {
            int numPlants = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();

            Stack<int> stackPlants = new Stack<int>(plants);

            bool plantDied = false;
            int days = 0;

            do
            {
                plantDied = false;
                Stack<int> nextDayPlants = new Stack<int>();

                while (stackPlants.Count > 0)
                {
                    int last = stackPlants.Pop();
                    if (stackPlants.Count > 0 && stackPlants.Peek() < last)
                    {
                        plantDied = true;
                    }
                    else
                    {
                        nextDayPlants.Push(last);
                    }
                }
                //6 5 8 4 7 10 9
                stackPlants = new Stack<int>(nextDayPlants);

                if (plantDied)
                {
                    days++;
                }

            } while (plantDied);

            Console.WriteLine(days);
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad5
        /// </summary>
        static void MultidimentionalArrayExerciceZad5()
        {
            var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToArray();
            int rols = vhod[0];
            int columns = vhod[1];

            int broiOperacii = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rols, columns];

            int iter = 1;
            for (int r = 0; r < rols; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = iter++;
                }
            }

            for (int i = 0; i < broiOperacii; i++)
            {
                var vh = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string command = vh[1];

                ///
                if (command == "up" || command == "down")
                {
                    int izmestvane = int.Parse(vh[2]) % columns;
                    int colona = int.Parse(vh[0]);
                    if (command == "up")
                    {
                        for (int k = 0; k < izmestvane; k++)
                        {
                            int posledenRed = matrix[0, colona];
                            for (int row = 0; row < rols - 1; row++)
                            {
                                matrix[row, colona] = matrix[row + 1, colona];
                            }
                            matrix[matrix.GetLength(0) - 1, colona] = posledenRed;
                        }

                    }
                    else if (command == "down")
                    {
                        for (int k = 0; k < izmestvane; k++)
                        {
                            int purviRed = matrix[rols - 1, colona];
                            for (int row = rols - 1; row > 0; row--)
                            {
                                matrix[row, colona] = matrix[row - 1, colona];
                            }
                            matrix[0, colona] = purviRed;
                        }

                    }
                }
                else if (command == "left" || command == "right")
                {
                    int izmestvane = int.Parse(vh[2]) % rols;
                    int red = int.Parse(vh[0]);

                    if (command == "left")
                    {
                        for (int k = 0; k < izmestvane; k++)
                        {
                            int poslednaColona = matrix[red, 0];
                            for (int col = 0; col < columns - 1; col++)
                            {
                                matrix[red, col] = matrix[red, col + 1];
                            }
                            matrix[red, columns - 1] = poslednaColona;
                        }

                    }
                    else if (command == "right")
                    {
                        for (int k = 0; k < izmestvane; k++)
                        {
                            int purvaColona = matrix[red, columns - 1];
                            for (int col = columns - 1; col > 0; col--)
                            {
                                matrix[red, col] = matrix[red, col - 1];
                            }
                            matrix[red, 0] = purvaColona;
                        }

                    }
                }
                ///

            }


            int broi = 1;
            for (int row = 0; row < rols; row++)
            {
                for (int col = 0; col < columns; col++)
                {

                    if (matrix[row, col] == broi)
                    {
                        Console.WriteLine("No swap required");

                    }
                    else
                    {
                        for (int i = row; i < rols; i++)
                        {
                            for (int k = 0; k < columns; k++)
                            {
                                if (matrix[i, k] == broi)
                                {
                                    int dopulnitelna = matrix[i, k];
                                    matrix[i, k] = matrix[row, col];
                                    matrix[row, col] = dopulnitelna;

                                    Console.WriteLine($"Swap ({row}, {col}) with ({i}, {k})");

                                }
                            }
                        }
                    }
                    broi++;
                }
            }
        }

        private static void RollRow()
        {
            throw new NotImplementedException();
        }

        private static void RollColumn()
        {

        }


        /// <summary>
        /// Fibuna4i zad7,8
        /// </summary>
        /// 
        static long[] numbers;
        static void Fib()
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = Fib(n);
            Console.WriteLine(result);
        }
        private static long Fib(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = Fib(n - 1) + Fib(n - 2);

            }
            return numbers[n];
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad6
        /// </summary>
        static void MultidimentionalArrayExerciceZad6()
        {
            int[] dimentions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int rows = dimentions[0];
            int columns = dimentions[1];

            string snake = Console.ReadLine();

            int[] shot = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            char[,] stairs = FillMatrix(snake, rows, columns);

            stairs = FireShot(shot, stairs);
            stairs = Gravity(stairs);

            PrintMatrix(stairs);
        }

        private static void PrintMatrix(char[,] stairs)
        {
            var sb = new StringBuilder();

            for (int row = 0; row < stairs.GetLength(0); row++)
            {
                for (int col = 0; col < stairs.GetLength(1); col++)
                {
                    sb.Append(stairs[row, col]);

                }
                sb.AppendLine();
            }
            string result = sb.ToString().TrimEnd();
            Console.WriteLine(result);
        }

        private static char[,] Gravity(char[,] stairs)
        {

            for (int col = 0; col < stairs.GetLength(1); col++)
            {
                int emptyRows = 0;
                for (int row = 0; row < stairs.GetLength(0); row++)
                {
                    if (stairs[row, col] == ' ' && row != 0)
                    {
                        for (int i = row; i > 0; i--)
                        {
                            stairs[i, col] = stairs[i - 1, col];
                            stairs[i - 1, col] = ' ';
                        }
                        stairs[0, col] = ' ';
                    }
                    //if (stairs[row, col] == ' ')
                    //{
                    //    emptyRows++;
                    //}
                    //else if(emptyRows > 0)
                    //{
                    //    stairs[row + emptyRows, col] = stairs[row, col];
                    //    stairs[row, col] = ' ';
                    //}
                }

            }
            return stairs;
        }

        private static char[,] FireShot(int[] shot, char[,] stairs)
        {
            int row = shot[0];
            int column = shot[1];
            int radius = shot[2];

            for (int r = 0; r < stairs.GetLength(0); r++)
            {
                for (int c = 0; c < stairs.GetLength(1); c++)
                {
                    int a = row - r;
                    int b = column - c;
                    double distance = Math.Sqrt(a * a + b * b);

                    if (distance <= radius)
                    {
                        stairs[r, c] = ' ';
                    }

                }
            }
            return stairs;
        }

        private static char[,] FillMatrix(string snake, int rows, int columns)
        {
            var matrix = new char[rows, columns];
            bool isGoingLeft = true;

            int snakeIndex = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                int index = isGoingLeft ? matrix.GetLength(1) - 1 : 0;
                int increment = isGoingLeft ? -1 : 1;

                for (int i = 0; i < columns; i++)
                {
                    matrix[row, index] = snake[snakeIndex++];

                    if (snakeIndex >= snake.Length)
                    {
                        snakeIndex = 0;
                    }
                    index += increment;
                }
                isGoingLeft = !isGoingLeft;
            }
            return matrix;
        }



        /// <summary>
        /// Multidimentional Array Exercice    Zad6
        /// </summary>
        static void Ujaaas()
        {
            var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int row = vhod[0];
            int col = vhod[1];

            var text = Console.ReadLine();//.ToArray();

            var index = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();



            //char[,] matrix = ReadMatrix(row, col, text);

            int r = index[0];
            int c = index[1];
            int radius = index[2];

            //matrix[r, c] = ' ';

            //FindRadiusRecursiv1(matrix, r, c, radius);
            //FindRadiusRecursiv2(matrix, r, c, radius);
            //FindRadiusRecursiv3(matrix, r, c, radius);
            //FindRadiusRecursiv4(matrix, r, c, radius);

            //for (int i = 0; i < row; i++)
            //{
            //    for (int k = 0; k < col; k++)
            //    {
            //        Console.Write($"{matrix[i, k]} ");
            //    }
            //    Console.WriteLine();
            //}
        }
        //static char[,] ReadMatrix(int row, int col, string text)
        //{
        //
        //    string cqlTekst = "";
        //    do
        //    {
        //        for (int i = 0; i < text.Length; i++)
        //        {
        //            cqlTekst += text[i];
        //            if (cqlTekst.Length == row * col)
        //            {
        //                break;
        //            }
        //        }
        //
        //    } while (cqlTekst.Length != row * col);
        //
        //    char[,] matrix = new char[row, col];
        //
        //    int broiOperacii = row * col;
        //
        //    for (int i = 0; i < row; i++)
        //    {
        //        if (row == 0 || row % 2 == 0)
        //        {
        //            for (int k = col - 1; k >= 0; k--)
        //            {
        //                matrix[i, k] = cqlTekst[broiOperacii];
        //                broiOperacii--;
        //            }
        //        }
        //        if (row % 2 == 1)
        //        {
        //            for (int k = 0; k < col; k++)
        //            {
        //                matrix[i, k] = cqlTekst[broiOperacii - 1];
        //                broiOperacii--;
        //            }
        //        }
        //    }
        //    return matrix;
        //}
        //
        //static char[,] FindRadiusRecursiv1(char[,] matrix, int r, int c, int radius)
        //{
        //    int m = radius;
        //    //int redove = r + radius;
        //    int coloni = c + radius;
        //
        //    if ( c < coloni)
        //    {
        //        matrix[r, c] = ' ';
        //        matrix[r, c + 1] = ' ';
        //        matrix[r, c - 1] = ' ';
        //        matrix[r + 1, c] = ' ';
        //        matrix[r - 1, c] = ' ';
        //        c++;
        //        radius --;
        //        FindRadiusRecursiv1(matrix, r, c, radius);
        //        
        //    }  
        //    return matrix;
        //}
        //static char[,] FindRadiusRecursiv2(char[,] matrix, int r, int c, int radius)
        //{
        //    int m = radius;
        //    //int redove = r + radius;
        //    int coloni = c - radius;
        //
        //    if (radius != 0 && c > coloni)
        //    {
        //        matrix[r, c] = ' ';
        //        FindRadiusRecursiv2(matrix, r, c--, radius--);
        //
        //    }
        //    return matrix;
        //}
        //static char[,] FindRadiusRecursiv3(char[,] matrix, int r, int c, int radius)
        //{
        //    int m = radius;
        //    int redove = r + radius;
        //    //int coloni = c + radius;
        //
        //    if (radius != 0 && r < redove)
        //    {
        //        matrix[r, c] = ' ';
        //        FindRadiusRecursiv3(matrix, r++, c, radius--);
        //
        //    }
        //    return matrix;
        //}
        //static char[,] FindRadiusRecursiv4(char[,] matrix, int r, int c, int radius)
        //{
        //    int m = radius;
        //    int redove = r - radius;
        //    //int coloni = c - radius;
        //
        //    if (radius != 0 && r > redove)
        //    {
        //        matrix[r, c] = ' ';
        //        FindRadiusRecursiv4(matrix, r--, c, radius--);
        //
        //    }
        //    return matrix;
        //}

        /// <summary>
        /// Multidimentional Array Exercice    Zad4
        /// </summary>
        static void MultidimentionalArrayExerciceZad4()
        {
            var rowIcol = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = rowIcol[0];
            int col = rowIcol[1];
            int[,] matrix = new int[rowIcol[0], rowIcol[1]];

            for (int i = 0; i < row; i++)
            {
                var redove = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int k = 0; k < col; k++)
                {
                    matrix[i, k] = redove[k];
                }
            }

            int sum = int.MinValue;
            int maxSum = int.MinValue;
            int[] index = new int[2];
            for (int i = 0; i < row - 2; i++)
            {
                for (int k = 0; k < col - 2; k++)
                {
                    sum = matrix[i, k] + matrix[i, k + 1] + matrix[i, k + 2]
                     + matrix[i + 1, k] + matrix[i + 1, k + 1] + matrix[i + 1, k + 2]
                      + matrix[i + 2, k] + matrix[i + 2, k + 1] + matrix[i + 2, k + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        index[0] = i;
                        index[1] = k;
                    }
                    sum = int.MinValue;
                }


            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[index[0], index[1]]} {matrix[index[0], index[1] + 1]} {matrix[index[0], index[1] + 2]}");
            Console.WriteLine($"{matrix[index[0] + 1, index[1]]} {matrix[index[0] + 1, index[1] + 1]} {matrix[index[0] + 1, index[1] + 2]}");
            Console.WriteLine($"{matrix[index[0] + 2, index[1]]} {matrix[index[0] + 2, index[1] + 1]} {matrix[index[0] + 2, index[1] + 2]}");

        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad3
        /// </summary>
        static void MultidimentionalArrayExerciceZad3()
        {
            var rowIcol = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = rowIcol[0];
            int col = rowIcol[1];
            if (row < 2 || col < 2)
            {
                Console.WriteLine(0);
                return;
            }

            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                var red = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int k = 0; k < col; k++)
                {
                    matrix[i, k] = red[k];
                }
            }
            int broi = 0;
            for (int i = 0; i < row - 1; i++)
            {
                for (int k = 0; k < col - 1; k++)
                {
                    if (matrix[i, k] == matrix[i, k + 1] && matrix[i, k] == matrix[i + 1, k] && matrix[i, k] == matrix[i + 1, k + 1])
                    {
                        broi++;
                    }
                }
            }
            Console.WriteLine(broi);
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad2
        /// </summary>
        static void MultidimentionalArrayExerciceZad2()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrics = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var red = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrics[row, col] = red[col];
                }
            }
            int sumPurviDiag = 0;
            int sumVtoriDiagonal = 0;

            for (int i = 0, k = n - 1; i < n && k >= 0; i++, k--)
            {
                sumPurviDiag += matrics[i, i];
                sumVtoriDiagonal += matrics[i, k];
            }
            if (sumPurviDiag > sumVtoriDiagonal)
            {
                Console.WriteLine(sumPurviDiag - sumVtoriDiagonal);
            }
            else if (sumVtoriDiagonal > sumPurviDiag)
            {
                Console.WriteLine(sumVtoriDiagonal - sumPurviDiag);
            }
            else if (sumVtoriDiagonal == sumPurviDiag)
            {
                Console.WriteLine(0);
            }
        }

        /// <summary>
        /// Multidimentional Array Exercice    Zad1
        /// </summary>
        static void MultidimentionalArrayExerciceZad1()
        {
            var rowIcol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = rowIcol[0];
            int col = rowIcol[1];

            string[,] matrics = new string[row, col];

            string bukvi = "";
            char sledva6taBukva = 'a';
            for (char i = 'a'; i < row + 97; i++)
            {
                for (char k = sledva6taBukva; k < col + sledva6taBukva; k++)
                {
                    bukvi += i;
                    bukvi += k;
                    bukvi += i;
                    matrics[i - 97, k - sledva6taBukva] = bukvi;
                    bukvi = "";
                }
                sledva6taBukva++;
            }
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < col; k++)
                {
                    Console.Write($"{matrics[i, k]} ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Stack And Queue Exercice      Zad10
        /// </summary>
        static void StackAndQueueExerciceZad10()
        {
            int comandsCount = int.Parse(Console.ReadLine());
            var oldVersions = new Stack<string>();
            oldVersions.Push("");

            var text = new StringBuilder();
            for (int i = 0; i < comandsCount; i++)
            {
                string[] comandInput = Console.ReadLine().Split();
                int command = int.Parse(comandInput[0]);

                switch (command)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        string newStr = comandInput[1];
                        text.Append(newStr);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        int length = int.Parse(comandInput[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        int index = int.Parse(comandInput[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                    default:
                        break;
                }

            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad7
        /// </summary>
        static void StackAndQueueExerciceZad7()
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            char[] opening = new[] { '(', '[', '{' };
            char[] closing = new[] { ')', ']', '}' };

            var stack = new Stack<char>();
            foreach (var element in input)
            {
                if (opening.Contains(element))
                {
                    stack.Push(element);
                }
                else if (closing.Contains(element))
                {
                    var lastElement = stack.Pop();
                    int openingIndex = Array.IndexOf(opening, lastElement);

                    int closeIndex = Array.IndexOf(closing, element);

                    if (openingIndex != closeIndex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad6
        /// </summary>
        static void StackAndQueueExerciceZad6()
        {
            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pump);
            }
            for (int currentStart = 0; currentStart < n - 1; currentStart++)
            {
                int fuel = 0;
                bool isSolution = true;
                for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
                {
                    var currentPump = queue.Dequeue();
                    var pumpFuel = currentPump[0];
                    int nextPumpDistans = currentPump[1];

                    queue.Enqueue(currentPump);

                    fuel += pumpFuel - nextPumpDistans;
                    if (fuel < 0)
                    {
                        currentStart += pumpsPassed;
                        isSolution = false;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    Environment.Exit(0);
                }

            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad5
        /// </summary>
        static void StackAndQueueExerciceZad5()
        {
            long n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            var arr = new List<long>();
            for (int i = 0; i < 17; i++)
            {
                if (i != 16)
                {
                    if (i == 0)
                    {
                        arr.Add(n);
                        queue.Enqueue(n);
                    }

                    arr.Add(n + 1);
                    arr.Add(2 * n + 1);
                    arr.Add(n + 2);

                    queue.Enqueue(n + 1);
                    queue.Enqueue(2 * n + 1);
                    queue.Enqueue(n + 2);
                    if (i == 0)
                    {
                        queue.Dequeue();
                    }
                    n = queue.Dequeue();
                }
                else
                {
                    //arr.Add(n);
                    arr.Add(n + 1);
                    queue.Enqueue(n);
                    //queue.Enqueue(n + 1);
                }
            }
            foreach (var ar in arr)
            {
                Console.Write($"{ar} ");
            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad4
        /// </summary>
        static void StackAndQueueExerciceZad4()
        {
            var vh = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>(chisla);

            int brElementiVSteka = vh[0];
            int broiPremahvaniElementi = vh[1];
            int tursenElement = vh[2];

            if (broiPremahvaniElementi >= brElementiVSteka)
            {
                queue.Clear();
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < broiPremahvaniElementi; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(tursenElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad3         75/100
        /// </summary>
        static void StackAndQueueExerciceZad3()
        {
            int comandCount = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);
            for (int i = 0; i < comandCount; i++)
            {
                var comand = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (comand[0])
                {
                    case 1:
                        var element = comand[1];
                        stack.Push(element);
                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var poppedElement = stack.Pop();
                        if (maxStack.Peek() == poppedElement)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = maxStack.Peek();
                        Console.WriteLine(maxElement);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad2
        /// </summary>
        static void StackAndQueueExerciceZad2()
        {
            var vh = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(chisla);

            int brElementiVSteka = vh[0];
            int broiPremahvaniElementi = vh[1];
            int tursenElement = vh[2];

            if (broiPremahvaniElementi >= brElementiVSteka)
            {
                stack.Clear();
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < broiPremahvaniElementi; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(tursenElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"{stack.Min()}");
            }
        }

        /// <summary>
        /// Stack And Queue Exercice      Zad1
        /// </summary>
        static void StackAndQueueExerciceZad1()
        {
            var input = Console.ReadLine();

            if (input.Length > 0)
            {
                var inp = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var stack = new Stack<int>(inp);
                foreach (var s in stack)
                {
                    Console.Write($"{s} ");
                }
            }
            else
            {
                return;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Stacks And Queues Lab    Zad6
        /// </summary>
        static void StacksAndQueuesLabZad6()
        {
            var carsPergreenLight = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();
            var carsQueue = new Queue<string>();
            int carThatPassedTotal = 0;
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsThatCanPass = Math.Min(carsQueue.Count, carsPergreenLight);
                    for (int counter = 0; counter < carsThatCanPass; counter++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carThatPassedTotal++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{carThatPassedTotal} cars passed the crossroads.");
        }

        /// <summary>
        /// Stacks And Queues Lab    Zad5
        /// </summary>
        static void StacksAndQueuesLabZad5()
        {
            var children = Console.ReadLine().Split(' ');
            var tossLimit = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);
            while (queue.Count != 1)
            {
                for (int tossCounter = 1; tossCounter < tossLimit; tossCounter++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        /// <summary>
        /// Stacks And Queues Lab    Zad4
        /// </summary>
        static void StacksAndQueuesLabZad4()
        {
            var input = Console.ReadLine();
            var stackOpenBracketIndexes = new Stack<int>();
            for (int counter = 0; counter < input.Length; counter++)
            {
                if (input[counter] == '(')
                {
                    stackOpenBracketIndexes.Push(counter);
                }
                if (input[counter] == ')')
                {
                    var openBracketIndex = stackOpenBracketIndexes.Pop();
                    var length = counter - openBracketIndex + 1;
                    Console.WriteLine(input.Substring(openBracketIndex, length));
                }
            }
        }

        /// <summary>
        /// Strukturi Ot Danni List and DS Complexity-Exercises  Zada4a  3      100/100
        /// </summary>
        static void StrukturiOtDanniLec3Zad3()
        {
            var chisla = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            bool ima = false;
            int broi = 1;
            int maxBroi = 0;
            int chislo = chisla[0];
            for (int i = 0; i < chisla.Length - 1; i++)
            {
                if (chisla[i] == chisla[i + 1])
                {
                    broi++;
                    if (broi > maxBroi)
                    {
                        maxBroi = broi;
                        chislo = chisla[i];

                    }
                    ima = true;
                }
                else
                {
                    broi = 1;
                }
            }
            if (ima == false)
            {
                Console.WriteLine(chislo);
            }
            for (int i = 0; i < maxBroi; i++)
            {
                Console.Write($"{chislo} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Strukturi Ot Danni List and DS Complexity-Exercises  Zada4a  1      100/100
        /// </summary>
        static void StrukturiOtDanniLec3Zad1()
        {
            var chisla = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();
            int sum = 0;
            if (chisla.Length == 0)
            {
                Console.WriteLine($"Sum=0; Average=0.00");
            }
            else
            {
                for (int i = 0; i < chisla.Length; i++)
                {
                    sum += chisla[i];
                }
                Console.WriteLine($"Sum={sum}; Average={(decimal)sum / (decimal)chisla.Length:f2}");
            }
        }

        /// <summary>
        /// EXTENDED Dictionary Zad 1         90/100
        /// </summary>
        static void Zada4a1DictionaryEXTENDED()
        {
            Dictionary<string, Dictionary<string, long>> reserv = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> dic = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> kraino = new Dictionary<string, Dictionary<string, long>>();
            do
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (vhod.Length == 1 && vhod[0] == "thetinggoesskrra")
                {
                    break;
                }
                if (vhod.Length == 1)
                {
                    if (!dic.ContainsKey(vhod[0]))
                    {
                        dic.Add(vhod[0], new Dictionary<string, long>());
                    }
                }
                else if (vhod.Length > 1)
                {
                    if (!reserv.ContainsKey(vhod[2]))
                    {
                        reserv.Add(vhod[2], new Dictionary<string, long>());
                    }
                    if (reserv.ContainsKey(vhod[2]))
                    {
                        reserv[vhod[2]].Add(vhod[0], long.Parse(vhod[1]));
                    }

                }

            } while (true);

            foreach (var d in dic.Keys)
            {
                foreach (var r in reserv)
                {
                    if (d == r.Key)
                    {
                        kraino.Add(d, r.Value);
                        //dic[d] = r.Value;
                    }
                }
            }

            long sum = 0;
            long maxSum = 0;
            string maxKliu4 = "";

            foreach (var d in kraino)
            {
                foreach (var di in d.Value)
                {
                    sum += di.Value;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxKliu4 = d.Key;
                    sum = 0;
                }
            }
            Console.WriteLine($"Data Set: {maxKliu4}, Total Size: {maxSum}");
            foreach (var vv in kraino)
            {
                if (vv.Key == maxKliu4)
                {
                    foreach (var i in vv.Value)
                    {
                        Console.WriteLine($"$.{i.Key}");
                    }
                }

            }

        }

        /// <summary>
        /// EXTENDED ARR i Lists Zad 4         100/100
        /// </summary>
        static void Zad4ArrayAndListsEXTENDED()
        {
            var p4eli = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(long.Parse)
               .ToList();

            var hornet = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();


            //for (int k = 0; k < hornet.Count; k++)
            //{


            for (int i = 0; i < p4eli.Count; i++)
            {
                long powerOfHornet = hornet.Sum(x => x);
                if (p4eli[i] < powerOfHornet)
                {
                    p4eli.RemoveAt(i);
                    i--;
                }
                else
                {
                    p4eli[i] = p4eli[i] - powerOfHornet;
                    if (p4eli[i] == 0)
                    {
                        p4eli.RemoveAt(i);
                        i--;
                    }
                    if (hornet.Count > 0)
                    {
                        hornet.RemoveAt(0);
                    }


                }
            }
            //}
            if (p4eli.Count > 0)
            {
                foreach (var p in p4eli)
                {
                    Console.Write(p + " ");
                }
            }
            else
            {
                foreach (var h in hornet)
                {
                    Console.Write(h + " ");
                }
            }
        }

        /// <summary>
        /// EXTENDED ARR i Lists Zad 3         70/100
        /// </summary>
        static void Zad3ArrayAndListsEXTENDED()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> list = new List<long>();
            do
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    index = 0;
                    nums[0] = nums[nums.Count - 1];
                    list.Add(nums[index]);
                    if (nums.Count - 1 != 0)
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] > nums[index])
                            {
                                nums[i] = nums[i] - nums[index];
                            }
                            else if (nums[i] <= nums[index])
                            {
                                nums[i] = nums[i] + nums[index];
                            }
                        }
                    }

                }
                else if (index > nums.Count - 1)
                {
                    index = nums.Count - 1;
                    nums[nums.Count - 1] = nums[0];
                    list.Add(nums[index]);
                    if (nums.Count - 1 != 0)
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] > nums[index])
                            {
                                nums[i] = nums[i] - nums[index];
                            }
                            else if (nums[i] <= nums[index])
                            {
                                nums[i] = nums[i] + nums[index];
                            }
                        }
                    }


                }

                else if (index >= 0 && index <= nums.Count - 1)
                {
                    list.Add(nums[index]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (i != index && nums[i] > nums[index])
                        {
                            nums[i] = nums[i] - nums[index];
                        }
                        else if (i != index && nums[i] <= nums[index])
                        {
                            nums[i] = nums[i] + nums[index];
                        }
                    }
                    nums.RemoveAt(index);
                }



            } while (nums.Count != 0);
            long sum = 0;
            foreach (var l in list)
            {
                Console.Write(l + " ");
                sum += l;
            }
            Console.WriteLine(sum);
        }

        /// <summary>
        /// EXTENDED ARR i Lists Zad 2          100/100
        /// </summary>
        static void Zad2ArrayAndListsEXTENDED()
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int poziciq = int.Parse(Console.ReadLine());
            var vhod = Console.ReadLine();

            int power = 1;
            while (vhod != "Supernova")
            {
                var mestene = vhod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string posoka = mestene[0];
                int broiStupki = int.Parse(mestene[1]);



                if (posoka == "left")
                {
                    for (int i = 1; i <= broiStupki; i++)
                    {
                        poziciq--;
                        if (poziciq < 0)
                        {
                            poziciq = nums.Count - 1;
                            power++;
                        }
                        if (poziciq > nums.Count - 1)
                        {
                            poziciq = 0;
                            power++;
                        }
                        nums[poziciq] = nums[poziciq] - power;


                    }
                }

                if (posoka == "right")
                {
                    for (int i = 1; i <= broiStupki; i++)
                    {
                        poziciq++;
                        if (poziciq < 0)
                        {
                            poziciq = nums.Count - 1;
                            power++;
                        }
                        if (poziciq > nums.Count - 1)
                        {
                            poziciq = 0;
                            power++;
                        }
                        nums[poziciq] = nums[poziciq] - power;


                    }
                }
                vhod = Console.ReadLine();
            }
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }
        }

        /// <summary>
        /// EXTENDED ARR i Lists Zad 1          70/100
        /// </summary>
        static void Zad1ArrayAndListsEXTENDED()
        {
            var dumi = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            do
            {
                bool izlez = false;
                String slivane = "";
                var operaciq = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (operaciq[0] == "3:1")
                {
                    break;
                }
                string margeOrDiv = operaciq[0];
                int purvoChislo = int.Parse(operaciq[1]);
                int vtoroChislo = int.Parse(operaciq[2]);


                if (margeOrDiv == "merge")
                {
                    //if (purvoChislo > dumi.Count - 1)
                    //{
                    //    izlez = true;
                    //}

                    if (purvoChislo < vtoroChislo)
                    {
                        if (vtoroChislo > dumi.Count - 1 || vtoroChislo < 0)
                        {
                            vtoroChislo = dumi.Count - 1;
                        }
                        if (purvoChislo < 0 || purvoChislo > dumi.Count - 1)
                        {
                            purvoChislo = 0;
                        }


                        for (int i = purvoChislo; i <= vtoroChislo; i++)
                        {
                            slivane += dumi[i];
                        }
                        for (int i = 0; i <= vtoroChislo - purvoChislo; i++)
                        {
                            dumi.RemoveAt(purvoChislo);
                        }
                        dumi.Insert(purvoChislo, slivane);
                    }




                }
                if (margeOrDiv == "divide" && dumi.Count > 0)
                {
                    string ne6to = dumi[purvoChislo];
                    int naKolkoDelim = 1;
                    if (vtoroChislo != 0)
                    {
                        naKolkoDelim = vtoroChislo;
                    }

                    if (naKolkoDelim > ne6to.Length)
                    {
                        naKolkoDelim = ne6to.Length;
                    }

                    int broiBukvi = ne6to.Length / naKolkoDelim;

                    string vmukni = "";
                    int m = 0;


                    if (ne6to.Length % naKolkoDelim == 0)
                    {
                        for (int i = 0; i < naKolkoDelim; i++)
                        {
                            for (int k = 0; k < broiBukvi; k++)
                            {
                                vmukni += ne6to[m];
                                m++;
                            }
                            vmukni += " ";
                        }
                    }
                    if (ne6to.Length % naKolkoDelim != 0)
                    {
                        for (int i = 0; i < naKolkoDelim; i++)
                        {
                            for (int k = 0; k < broiBukvi; k++)
                            {
                                vmukni += ne6to[m];
                                m++;
                            }

                            if (i == naKolkoDelim - 1)
                            {
                                int dobavi = ne6to.Length % naKolkoDelim;
                                for (int r = dobavi; r > 0; r--)
                                {
                                    vmukni += ne6to[ne6to.Length - r];
                                }

                            }
                            vmukni += " ";
                        }
                    }
                    dumi.RemoveAt(purvoChislo);
                    dumi.Insert(purvoChislo, vmukni);

                }

            } while (true);

            foreach (var d in dumi)
            {
                Console.Write(d + " ");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        static void DrunDrun()
        {
            string a = null;

            var b = a?.FirstOrDefault();

            Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> dic1 = new Dictionary<string, Dictionary<string, int>>();
            string dateSet = "";
            string dateKey = "";
            int dateSize = 0;
            do
            {

                var vhod = Console.ReadLine()
                .Split(new char[] { ' ', '|', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (vhod[0] == "thetinggoesskrra")
                {
                    break;
                }

                if (vhod.Length == 1)
                {
                    dateSet = vhod[0];
                    if (!dic.ContainsKey(vhod[0]))
                    {
                        dic.Add(vhod[0], new Dictionary<string, int>());

                        //if (dic1.ContainsKey(dateSet))
                        //{
                        //
                        //    dic[dateSet] = dic1[dateSet];
                        //}

                    }
                }

                else if (vhod.Length == 3)
                {
                    dateKey = vhod[0];
                    dateSize = int.Parse(vhod[1]);
                    dateSet = vhod[2];

                    if (!dic.ContainsKey(vhod[2]))
                    {
                        // dic1.Add(vhod[0], new Dictionary<string, int>());
                        //   dic1[vhod[0]].Add(vhod[2], int.Parse(vhod[1]));
                    }
                    else if (dic.ContainsKey(vhod[2]))
                    {
                        dic[vhod[2]].Add(vhod[0], int.Parse(vhod[1]));
                    }

                }
            } while (true);
            foreach (var d in dic1)
            {
                if (dic.ContainsKey(d.Key))
                {
                    foreach (var di in d.Value)
                    {
                        dic[d.Key].Add(di.Key, di.Value);
                    }
                }

            }
            int br = 1;
            int ob6to = 0;
            int brCount = 0;
            int nGBC = 0;
            Dictionary<string, Dictionary<string, int>> p = new Dictionary<string, Dictionary<string, int>>();
            foreach (var d in dic.OrderByDescending(x => x.Value.Count))
            {
                //brCount = d.Key.Count();
                //if (brCount>nGBC)
                //{
                //    p.
                //}
                Console.Write($"Data Set: {d.Key}, Total Size: ");
                foreach (var di in d.Value)
                {
                    ob6to += di.Value;
                }
                Console.WriteLine(ob6to);
                foreach (var dd in d.Value)
                {
                    Console.WriteLine($"$.{dd.Key}");
                }
                //br++;
                //if (br>1)
                //{
                //    break;
                //}
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void IzpitZad2()
        {
            var vhod = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> chastii = new List<string>();
            StringBuilder duma = new StringBuilder();
            List<string> result = new List<string>();
            do
            {
                var vh = Console.ReadLine();
                if (vh == "3:1")
                {
                    break;
                }
                var mOrDivide = vh.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int purviIndex = int.Parse(mOrDivide[1]);
                int vtoriIndex = int.Parse(mOrDivide[2]);

                if (mOrDivide[0] == "merge" && purviIndex < vhod.Count - 1)
                {
                    if (vtoriIndex < purviIndex)
                    {
                        int p = vtoriIndex; ;
                        vtoriIndex = purviIndex;
                        purviIndex = p;
                    }
                    string strMarge = "";
                    if (purviIndex < 0)
                    {
                        purviIndex = 0;
                    }
                    if (vtoriIndex > vhod.Count - 1)
                    {
                        vtoriIndex = vhod.Count - 1;
                    }
                    for (int i = purviIndex; i <= vtoriIndex; i++)
                    {
                        strMarge += vhod[i];
                    }
                    vhod.RemoveRange(purviIndex, vtoriIndex - purviIndex + 1);
                    vhod.Insert(purviIndex, strMarge);
                    result = new List<string>(vhod);
                }
                else if (mOrDivide[0] == "divide")
                {
                    string chasti = "";
                    string dDivide = vhod[purviIndex].ToString();
                    int kolkoElementa = dDivide.Length / vtoriIndex;

                    int brelementi = kolkoElementa;
                    int dL = dDivide.Length - 1;
                    int count = 0;
                    if (dDivide.Length % vtoriIndex == 0)
                    {


                        for (int i = 0; i < dDivide.Length; i++)
                        {
                            chasti += dDivide[i];
                            count++;
                            if (count == brelementi)
                            {
                                chastii.Add(chasti);
                                chasti = "";

                                //kolkoElementa += kolkoElementa;
                                brelementi += kolkoElementa;
                            }
                        }


                    }
                    else if (dDivide.Length % vtoriIndex == 1)
                    {

                        for (int i = 0; i < dDivide.Length; i++)
                        {
                            chasti += dDivide[i];
                            count++;
                            if (count == brelementi)
                            {
                                chastii.Add(chasti);
                                chasti = "";
                                brelementi += kolkoElementa;
                            }
                        }

                        string poslElement = chastii[chastii.Count - 1];
                        poslElement += dDivide[dDivide.Length - 1];
                        chastii.RemoveAt(chastii.Count - 1);
                        chastii.Insert(chastii.Count - 1, poslElement);
                    }
                    vhod.RemoveAt(purviIndex);
                    vhod.InsertRange(purviIndex, chastii);
                    vhod.ToList();
                    result = new List<string>(vhod);
                }

            } while (true);
            foreach (var r in result)
            {
                Console.Write($"{r} ");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        static void IzpitZad1()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte securityk = byte.Parse(Console.ReadLine());
            int securityT = 1;

            List<string> emails = new List<string>();
            decimal totalLoss = 0;

            for (int i = 0; i < n; i++)
            {
                var vhod = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string email = vhod[0];
                long pose6teniq = long.Parse(vhod[1]);
                decimal cena = decimal.Parse(vhod[2]);

                emails.Add(email);

                decimal syteLos = (decimal)pose6teniq * cena;
                totalLoss += syteLos;
            }
            for (int i = 0; i < n; i++)
            {
                securityT *= securityk;
            }

            foreach (var e in emails)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityT}");
        }

        /// <summary>
        /// 
        /// </summary>
        static void Ne6to()
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