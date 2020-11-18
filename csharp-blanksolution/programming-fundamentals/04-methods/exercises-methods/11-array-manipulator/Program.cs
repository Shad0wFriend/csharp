using System;
using System.Linq;

namespace _11_array_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split(' ');

                switch (command[0])
                {
                    case "exchange": Exchange(numbers, int.Parse(command[1])); break;
                    case "max":
                        if (command[1] == "even")
                        {
                            Console.WriteLine(MaxEven(numbers));

                            break;
                        }
                        else
                        {
                            Console.WriteLine(MaxOdd(numbers));

                            break;
                        }
                    case "min":
                        if (command[1] == "even")
                        {
                            if (MinEven(numbers) == -1)
                            {
                                Console.WriteLine("No matches");

                                break;
                            }

                            Console.WriteLine(MinEven(numbers));

                            break;
                        }
                        else
                        {
                            if (MinOdd(numbers) == -1)
                            {
                                Console.WriteLine("No matches");

                                break;
                            }

                            Console.WriteLine(MinOdd(numbers));

                            break;
                        }
                    case "first":
                        if (int.Parse(command[1]) > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");

                            break;
                        }

                        string[] tmp;

                        if (command[2] == "even")
                        {
                            tmp = FirstEven(numbers, int.Parse(command[1])).Split(' ');
                        }
                        else
                        {
                            tmp = FirstOdd(numbers, int.Parse(command[1])).Split(' ');
                        }

                        int counter = 0;

                        for (int i = 0; i < tmp.Length; i++)
                        {
                            if (tmp[i] != "")
                            {
                                counter++;
                            }
                        }

                        string[] result = new string[counter];

                        counter = 0;

                        for (int i = 0; i < tmp.Length; i++)
                        {
                            if (tmp[i] != "")
                            {
                                if (counter < result.Length)
                                {
                                    result[counter] = tmp[i];

                                    counter++;
                                }
                            }
                        }

                        Console.Write('[');

                        for (int i = 0; i < result.Length; i++)
                        {
                            if (i == result.Length - 1)
                            {
                                Console.Write(result[i]);

                                continue;
                            }

                            if (result[i] != "")
                            {
                                Console.Write(result[i] + ", ");
                            }
                        }

                        Console.Write(']');

                        Console.WriteLine();

                        break;
                    case "last":
                        if (int.Parse(command[1]) > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");

                            break;
                        }

                        string[] temp;

                        if (command[2] == "even")
                        {
                            temp = LastEven(numbers, int.Parse(command[1])).Split(' ');
                        }
                        else
                        {
                            temp = LastOdd(numbers, int.Parse(command[1])).Split(' ');
                        }

                        int cntr = 0;

                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] != "")
                            {
                                cntr++;
                            }
                        }

                        string[] res = new string[cntr];

                        counter = 0;

                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i] != "")
                            {
                                if (counter < res.Length)
                                {
                                    res[counter] = temp[i];

                                    counter++;
                                }
                            }
                        }

                        Console.Write('[');

                        for (int i = res.Length - 1; i >= 0; i--)
                        {
                            if (i == 0)
                            {
                                Console.Write(res[i]);

                                continue;
                            }

                            if (res[i] != "")
                            {
                                Console.Write(res[i] + ", ");
                            }
                        }

                        Console.Write(']');

                        Console.WriteLine();

                        break;
                }

                input = Console.ReadLine();
            }

            Console.Write('[');

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.Write(numbers[i]);

                    continue;
                }

                Console.Write(numbers[i] + ", ");
            }

            Console.Write(']');

            Console.WriteLine();
        }

        public static void Exchange(int[] numbers, int rotations)
        {
            if (rotations >= numbers.Length || rotations < 0)
            {
                Console.WriteLine("Invalid index");

                return;
            }

            int lastNumber = numbers[0];

            for (int i = 0; i <= rotations; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (k + 1 >= numbers.Length)
                    {
                        break;
                    }

                    numbers[k] = numbers[k + 1];
                }

                numbers[numbers.Length - 1] = lastNumber;
                lastNumber = numbers[0];
            }
        }

        public static int MaxEven(int[] numbers)
        {
            int biggest = 0;

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    biggest = numbers[i];

                    index = i;

                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (biggest <= numbers[i])
                    {
                        biggest = numbers[i];

                        index = i;
                    }
                }
            }

            return index;
        }

        public static int MaxOdd(int[] numbers)
        {
            int biggest = 0;

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    biggest = numbers[i];

                    index = i;

                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (biggest <= numbers[i])
                    {
                        biggest = numbers[i];

                        index = i;
                    }
                }
            }

            return index;
        }

        public static int MinEven(int[] numbers)
        {
            int smallest = 0;

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    smallest = numbers[i];

                    index = i;

                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (smallest >= numbers[i])
                    {
                        smallest = numbers[i];

                        index = i;
                    }
                }
            }

            return index;
        }

        public static int MinOdd(int[] numbers)
        {
            int smallest = 0;

            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    smallest = numbers[i];

                    index = i;

                    break;
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    if (smallest >= numbers[i])
                    {
                        smallest = numbers[i];

                        index = i;
                    }
                }
            }

            return index;
        }

        public static string FirstEven(int[] numbers, int count)
        {
            string result = "";

            int counter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && counter <= count)
                {
                    result += numbers[i].ToString() + " ";

                    counter++;
                }
            }

            return result;
        }

        public static string FirstOdd(int[] numbers, int count)
        {
            string result = "";

            int counter = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1 && counter <= count)
                {
                    result += numbers[i].ToString() + " ";

                    counter++;
                }
            }

            return result;
        }

        public static string LastEven(int[] numbers, int count)
        {
            string result = "";

            int counter = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 0 && counter <= count)
                {
                    result += numbers[i].ToString() + " ";

                    counter++;
                }
            }

            return result;
        }

        public static string LastOdd(int[] numbers, int count)
        {
            string result = "";

            int counter = 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] % 2 == 1 && counter <= count)
                {
                    result += numbers[i].ToString() + " ";

                    counter++;
                }
            }

            return result;
        }
    }
}
