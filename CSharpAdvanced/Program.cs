using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void PredicateParty()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            Func<List<string>, string, List<string>> StartsWith = (List<string> imena, string zapo4vaS) =>
            {
                List<string> list = new List<string>();
                for (int i = 0; i < imena.Count; i++)
                {
                    bool zapo4va = true;
                    string ime = imena[i];
                    if (zapo4vaS.Length <= ime.Length)
                    {
                        for (int k = 0; k < zapo4vaS.Length; k++)
                        {
                            if (ime[k] != zapo4vaS[k])
                            {
                                zapo4va = false;
                            }
                        }
                    }
                    if (zapo4va == true)
                    {
                        list.Add(imena[i]);
                    }
                }
                return list;
            };
            Func<List<string>, string, List<string>> EndsWith = (List<string> imena, string zavur6vaS) =>
            {
                List<string> list = new List<string>();
                for (int i = 0; i < imena.Count; i++)
                {
                    bool zavur6va = true;
                    string ime = imena[i];
                    if (zavur6vaS.Length <= ime.Length)
                    {
                        int r = ime.Length - 1;
                        for (int k = zavur6vaS.Length - 1; k >= 0; k--)
                        {
                            if (ime[r] != zavur6vaS[k])
                            {
                                zavur6va = false;
                            }
                            r--;
                        }
                    }
                    if (zavur6va == true)
                    {
                        list.Add(imena[i]);
                    }
                }
                return list;
            };
            Func<List<string>, int, List<string>> Length = (List<string> list, int n) =>
            {
                List<string> list1 = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Length == n)
                    {
                        list1.Add(list[i]);
                    }
                }
                return list1;
            };

            do
            {
                var vhod = Console.ReadLine();
                if (vhod == "Party!")
                {
                    break;
                }
                var vh = vhod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         .ToList();
                string doubleOrRemove = vh[0];
                string startsEndOrLength = vh[1];
                string startsOrEnd = "";
                int length = 0;
                if (startsEndOrLength == "Length")
                {
                    length = int.Parse(vh[2]);
                }
                else
                {
                    startsOrEnd = vh[2];
                }
                if (doubleOrRemove == "Remove")
                {
                    if (startsEndOrLength == "StartsWith")
                    {
                        List<string> li = StartsWith(input, startsOrEnd);
                        for (int i = 0; i < li.Count; i++)
                        {
                            if (input.Contains(li[i]))
                            {
                                input.Remove(li[i]);
                            }
                        }
                    }
                    if (startsEndOrLength == "EndsWith")
                    {
                        List<string> li = EndsWith(input, startsOrEnd);
                        for (int i = 0; i < li.Count; i++)
                        {
                            if (input.Contains(li[i]))
                            {
                                input.Remove(li[i]);
                            }
                        }
                    }
                    if (startsEndOrLength == "Length")
                    {
                        List<string> li = Length(input, length);
                        for (int i = 0; i < li.Count; i++)
                        {
                            if (input.Contains(li[i]))
                            {
                                input.Remove(li[i]);
                            }
                        }
                    }

                }
                else if (doubleOrRemove == "Double")
                {
                    if (startsEndOrLength == "StartsWith")
                    {
                        List<string> li = StartsWith(input, startsOrEnd);

                        for (int k = 0; k < input.Count; k++)
                        {
                            if (li.Contains(input[k]))
                            {
                                input.Insert(k + 1, input[k]);
                                li.Remove(input[k]);
                            }
                        }
                    }
                    if (startsEndOrLength == "EndsWith")
                    {
                        List<string> li = EndsWith(input, startsOrEnd);

                        for (int k = 0; k < input.Count; k++)
                        {
                            if (li.Contains(input[k]))
                            {
                                input.Insert(k + 1, input[k]);
                                li.Remove(input[k]);
                            }
                        }
                    }
                    if (startsEndOrLength == "Length")
                    {
                        List<string> li = Length(input, length);

                        for (int k = 0; k < input.Count; k++)
                        {
                            if (li.Contains(input[k]))
                            {
                                input.Insert(k + 1, input[k]);
                                li.Remove(input[k]);
                            }
                        }
                    }

                }

            } while (true);
            if (input.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i < input.Count - 1)
                    {
                        Console.Write($"{input[i]}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{input[i]} are going to the party!");
                    }
                }
            }
        }

        private static void ListOfPredicates()
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse).ToArray();
            Func<int, int[], bool> deliLiSe = (int chislo, int[] arr) =>
            {
                bool deliSe = true;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (chislo % arr[i] != 0)
                    {
                        deliSe = false;
                    }
                }
                return deliSe;
            };
            for (int i = 1; i <= n; i++)
            {
                if (deliLiSe(i, input))
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void CustomComparator()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse).ToArray();
            Func<int[], List<int>> chetni = (int[] arr) =>
            {
                List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        list.Add(arr[i]);
                    }
                }
                return list;
            };
            Func<int[], List<int>> neChetni = (int[] arr) =>
            {
                List<int> list = new List<int>();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                    {
                        list.Add(arr[i]);
                    }
                }
                return list;
            };
            foreach (var c in chetni(input).OrderBy(x => x))
            {
                Console.Write($"{c} ");
            }
            foreach (var c in neChetni(input).OrderBy(x => x))
            {
                Console.Write($"{c} ");
            }
        }

        private static void PredicateForNames()
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            Predicate<string> poMaluk = (string duma) => { return duma.Length <= n; };
            foreach (var i in input)
            {
                if (poMaluk(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
        }

        private static void ReverseAndExclude()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> deliLiSe = (int chislo) =>
            {
                if (chislo % n == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            };


            for (int i = input.Count - 1; i >= 0; i--)
            {
                if (deliLiSe(input[i]))
                {
                    input.RemoveAt(i);
                }
                else
                {
                    Console.Write($"{input[i]} ");
                }

            }
            //input.ForEach(x =>Console.Write($"{x} "));
        }

        private static void AppliedArithmetics()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse).ToList();
            Func<int, int> Add = (int i) => i + 1;
            Func<int, int> Multiply = (int i) => i * 2;
            Func<int, int> Subtract = (int i) => i - 1;
            Action<int> Print = (int i) => Console.Write($"{i} ");

            do
            {
                var vhod = Console.ReadLine();
                if (vhod == "end")
                {
                    break;
                }
                if (vhod == "add")
                {
                    input = input.Select(Add).ToList();
                }
                if (vhod == "multiply")
                {
                    input = input.Select(Multiply).ToList();
                }
                if (vhod == "subtract")
                {
                    input = input.Select(Subtract).ToList();
                }
                if (vhod == "print")
                {
                    input.ForEach(Print);
                    Console.WriteLine();
                }

            } while (true);
        }

        private static void FindEvensOrOdds()
        {
            Func<int, string, bool> toPrintOrNot = (int i, string evenOrOdd) =>
            {
                bool isEven = i % 2 == 0;

                if (evenOrOdd == "odd" && !isEven)
                {
                    return true;
                }
                else if (evenOrOdd == "even" && isEven)
                {
                    return true;
                }

                return false;
            };

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var printOddEvenInput = Console.ReadLine();

            List<int> nums = new List<int>();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (toPrintOrNot(i, printOddEvenInput))
                {
                    nums.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        private static void CustomMinFunction()
        {
            Func<int[], int> minNum = (int[] arr) =>
            {
                int min = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }

                return min;
            };

            int[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(minNum(input));
        }

        private static void KnightsOfHonor()
        {
            Action<string> action = (string s) =>
            {
                Console.WriteLine($"Sir {s}");
            };

            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(action);
        }

        private static void ActionPoint()
        {
            Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToList()
                            .ForEach(Console.WriteLine);
        }
    }
}
