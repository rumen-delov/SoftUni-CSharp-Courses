using System;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
        }
    }
}

using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendSir = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(appendSir);
        }
    }
}

  
using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> findMin = x => x.Min();

            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(findMin(array));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine();

            List<int> result = new List<int>();

            Enumerable.Range(input[0], input[1] - input[0] + 1)
                .Where(x => condition == "even" ? isEven(x) : !isEven(x))
                .ToList()
                .ForEach(result.Add);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;

            Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => y - 1).ToList();
            Func<List<int>, string> stringify = x => String.Join(" ", x);

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        list = add(list);
                        break;
                    case "multiply":
                        list = multiply(list);
                        break;
                    case "subtract":
                        list = subtract(list);
                        break;
                    case "print":
                        Console.WriteLine(stringify(list));
                        break;
                }
            }
        }
    }
}

  
using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse);

            int number = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % number != 0;
            Func<int, bool> filterFunc = x => filter(x);

            array = array
                .Where(filterFunc);

            Console.WriteLine(String.Join(" ", array.Reverse()));
        }
    }
}

using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Predicate<string> filterByLength = x => x.Length <= length;

            Console.ReadLine()
                .Split()
                .Where(s => filterByLength(s))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}

using System;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> comparer = (x, y) =>
            Math.Abs(x % 2) == Math.Abs(y % 2) ? (x == y ? 0 : (x < y ? -1 : 1)) : (Math.Abs(x % 2) == 0 ? -1 : 1);

            Array.Sort(array, (x, y) => comparer(x, y));

            Console.WriteLine(String.Join(" ", array));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split()
                .Distinct()
                .Select(int.Parse)
                .ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            dividers.ForEach(d => predicates.Add(x => x % d == 0));
            List<int> result = new List<int>();

            for (int i = 1; i <= endRange; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            Func<List<string>, List<string>, List<string>> doublePeople = (a, b) =>
            {
                foreach (string doubled in b)
                {
                    for (int i = 0; i < a.Count * 2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == doubled)
                            {
                                a.Insert(i, doubled);
                                i++;
                            }
                        }
                    }
                }

                return a;
            };

            var filtered = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                var commandArgs = command.Split();
                switch (commandArgs[1])
                {
                    case "StartsWith":
                        filtered = people
                            .Where(p => startsWith(p, commandArgs[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "EndsWith":
                        filtered = people
                            .Where(p => endsWith(p, commandArgs[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        filtered = people
                            .Where(p => checkLength(p, int.Parse(commandArgs[2])))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Remove":
                        people = people
                            .Where(p => !filtered.Contains(p))
                            .ToList();
                        break;
                    case "Double":
                        people = doublePeople(people, filtered);
                        break;
                }
            }

            if (people.Count > 0)
            {
                Console.WriteLine($"{String.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initial = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> checkLength = (a, b) => a.Length == b;

            List<string> result = new List<string>(initial);
            List<string> filtered = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "Print")
            {
                string[] commandArgs = command.Split(';');
                switch (commandArgs[1])
                {
                    case "Starts with":
                        filtered = initial
                            .Where(i => startsWith(i, commandArgs[2]))
                            .ToList();
                        break;
                    case "Ends with":
                        filtered = initial
                            .Where(i => endsWith(i, commandArgs[2]))
                            .ToList();
                        break;
                    case "Length":
                        filtered = initial
                            .Where(i => checkLength(i, int.Parse(commandArgs[2])))
                            .ToList();
                        break;
                    case "Contains":
                        filtered = initial
                            .Where(i => contains(i, commandArgs[2]))
                            .ToList();
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Add filter":
                        result
                            .RemoveAll(r => filtered.Contains(r));
                        break;
                    case "Remove filter":
                        result.AddRange(filtered);
                        result = result.Distinct().ToList();
                        break;
                }
            }

            initial.RemoveAll(i => !result.Contains(i));
            Console.WriteLine(String.Join(" ", initial));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isGreater = (a, b) => a.Sum(c => c) >= b;

            Func<Func<string, int, bool>, List<string>, string> returnFirst = (a, b) => b.FirstOrDefault(s => a(s, sum));

            string result = returnFirst(isGreater, names);

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(String.Empty);
            }
        }
    }
}