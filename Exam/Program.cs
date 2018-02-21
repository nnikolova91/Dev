using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {


            int rows = int.Parse(Console.ReadLine());

            string purviRed = Console.ReadLine();
            int cols = purviRed.Length;

            int rowN = 0;
            int colN = 0;

            int rowS = 0;
            int colS = 0;

            bool pobeden = false;

            char[,] matrix = new char[rows, cols];
            for (int c = 0; c < cols; c++)
            {
                matrix[0, c] = purviRed[c];
                if (purviRed[c] == 'N')
                {
                    rowN = 0;
                    colN = c;
                }
                if (purviRed[c] == 'S')
                {
                    rowS = 0;
                    colS = c;
                }
            }
            for (int r = 1; r < rows; r++)
            {
                string vhod = Console.ReadLine();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = vhod[c];
                    if (vhod[c] == 'N')
                    {
                        rowN = r;
                        colN = c;
                    }
                    if (vhod[c] == 'S')
                    {
                        rowS = r;
                        colS = c;
                    }
                }
            }
            string commands = Console.ReadLine();
            


            for (int i = 0; i < commands.Length; i++)
            {
                
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (matrix[r,c] == 'b' && c< cols-1)
                        {
                            matrix[r, c + 1] = 'b';                           
                            matrix[r, c] = '.';
                            c++;
                            if ( c+1 == cols - 1)
                            {
                                matrix[r, c+1] = 'd';
                            }
                        }
                        //else if (matrix[r, c] == 'b' && c == cols - 1)
                        //{
                        //    matrix[r, c ] = 'd';                            
                        //}
                        if (matrix[r, c] == 'd' && c > 0)
                        {
                            matrix[r, c - 1] = 'd';
                            matrix[r, c] = '.';
                            if (c-1 == 0)
                            {
                                matrix[r, c-1] = 'b';
                            }
                        }
                        //else if (matrix[r, c] == 'd' && c == 0)
                        //{
                        //    matrix[r, c] = 'b';
                        //}                       
                    }
                    
                }
                switch (commands[i])
                {
                    case 'U':
                        rowS = rowS - 1;
                        if (rowS == rowN)
                        {
                            matrix[rowN, colN] = 'X';
                            matrix[rowS, colS] = 'S';
                            matrix[rowS+1, colS] = '.';
                            Console.WriteLine($"Nikoladze killed!");
                            pobeden = true;
                            break;
                        }
                        if (matrix[rowS, colS] == 'b' || matrix[rowS, colS] == 'd')
                        {
                            matrix[rowS, colS] = 'S';
                            matrix[rowS+1, colS] = '.';
                        }
                        for (int col = 0; col < cols; col++)
                        {
                            if (matrix[rowS, col] == 'b' && col < colS)
                            {
                                matrix[rowS, colS] = 'X';
                                matrix[rowS + 1, colS] = '.';
                                Console.WriteLine($"Sam died at {rowS}, {colS}");
                                pobeden = true;
                                break;
                            }
                        }

                        break;
                    case 'D':
                        rowS += 1;
                        if (rowS == rowN)
                        {
                            matrix[rowN, colN] = 'X';
                            Console.WriteLine($"Nikoladze killed!");
                            pobeden = true;
                            break;
                        }
                        //if (matrix[rowS, colS] == 'b' || matrix[rowS, colS] == 'd')
                        //{
                        //    matrix[rowS, colS] = 'S';
                        //    matrix[rowS - 1, colS] = '.';
                        //}
                        bool neEZastra6en = true;
                        for (int col = 0; col < cols; col++)
                        {
                            if (matrix[rowS, colS] == 'b' || matrix[rowS, colS] == 'd')
                            {
                                matrix[rowS, colS] = 'S';
                                matrix[rowS - 1, colS] = '.';
                            }
                            else if (matrix[rowS, col] == 'b' && col < colS)
                            {
                                matrix[rowS, colS] = 'X';
                                matrix[rowS-1, colS] = '.';
                                Console.WriteLine($"Sam died at {rowS}, {colS}");
                                pobeden = true;
                                neEZastra6en = false;
                                break;
                            }
                            else if (matrix[rowS, col] == 'd' && col > colS)
                            {
                                matrix[rowS, colS] = 'X';
                                matrix[rowS - 1, colS] = '.';
                                Console.WriteLine($"Sam died at {rowS}, {colS}");
                                pobeden = true;
                                neEZastra6en = false;
                                break;
                            }
                        }
                        if (neEZastra6en == true)
                        {
                            matrix[rowS, colS] = 'S';
                            matrix[rowS - 1, colS] = '.';
                        }
                        break;

                    case 'L':
                        colS -= 1;
                        if (matrix[rowS, colS] == 'b' || matrix[rowS, colS] == 'd')
                        {
                            matrix[rowS, colS] = 'S';
                            matrix[rowS, colS + 1] = '.';
                        }

                        break;
                    case 'R':
                        colS += 1;
                        if (matrix[rowS, colS] == 'b' || matrix[rowS, colS] == 'd')
                        {
                            matrix[rowS, colS] = 'S';
                            matrix[rowS, colS - 1] = '.';
                        }
                        break;
                    case 'W':
                        for (int col = 0; col < cols; col++)
                        {
                            //if (matrix[rowS, col] == 'b' && col < colS)
                            //{
                            //    matrix[rowS, colS] = '.';
                            //    Console.WriteLine($"Sam died at {rowS}, {colS}");
                            //}
                            //else if (matrix[rowS, col] == 'd' && col > colS)
                            //{
                            //    matrix[rowS, colS] = '.';
                            //    Console.WriteLine($"Sam died at {rowS}, {colS}");
                            //}
                        }
                        break;

                }
                if (pobeden == true)
                {
                    break;
                }
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{matrix[r,c]}");
                }
                Console.WriteLine();
            }



        }
    }
}
