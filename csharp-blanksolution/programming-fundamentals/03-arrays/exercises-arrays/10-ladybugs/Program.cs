using System;
using System.Linq;

namespace _10_ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int[] field = new int[fieldSize];

            FillField(indexes, field);

            while (input != "end")
            {
                string[] data = input.Split(' ');

                int index = int.Parse(data[0]);

                string direction = data[1];

                int length = int.Parse(data[2]);

                if (direction == "left")
                {
                    if (length < 0)
                    {
                        length = length * (-1);

                        RightMovement(field, index, length);
                    }
                    else
                    {
                        LeftMovement(field, index, length);
                    }
                }
                else
                {
                    if (length < 0)
                    {
                        length = length * (-1);

                        LeftMovement(field, index, length);
                    }
                    else
                    {
                        RightMovement(field, index, length);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', field));
        }

        public static void FillField(int[] indexes, int[] field)
        {
            for (int i = 0; i < indexes.Length; i++)
            {
                if (!(indexes[i] >= field.Length || indexes[i] < 0))
                {
                    for (int k = 0; k < field.Length; k++)
                    {
                        if (indexes[i] == k)
                        {
                            field[k] = 1;

                            break;
                        }
                    }
                }
            }
        }

        public static void LeftMovement(int[] field, int index, int length)
        {
            if (index >= field.Length || index < 0)
            {
                return;
            }

            if (field[index] == 0)
            {
                return;
            }

            int startIndex = index;

            int currentPosition = index - length;

            for (int i = field.Length - 1; i >= 0; i--)
            {
                if (currentPosition < 0)
                {
                    field[startIndex] = 0;

                    break;
                }
                else if (field[currentPosition] == 1)
                {
                    currentPosition -= length;
                }
                else if (field[currentPosition] == 0)
                {
                    field[currentPosition] = 1;

                    field[startIndex] = 0;

                    break;
                }
            }
        }

        public static void RightMovement(int[] field, int index, int length)
        {
            if (index >= field.Length || index < 0)
            {
                return;
            }

            if (field[index] == 0)
            {
                return;
            }

            int startIndex = index;

            int currentPosition = index + length;

            for (int i = 0; i < field.Length; i++)
            {
                if (currentPosition >= field.Length)
                {
                    field[startIndex] = 0;

                    break;
                }
                else if (field[currentPosition] == 1)
                {
                    currentPosition += length;
                }
                else if (field[currentPosition] == 0)
                {
                    field[currentPosition] = 1;

                    field[startIndex] = 0;

                    break;
                }
            }
        }
    }
}
