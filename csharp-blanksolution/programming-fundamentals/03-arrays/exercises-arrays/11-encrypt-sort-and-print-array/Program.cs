using System;

namespace _11_encrypt_sort_and_print_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] result = new int[countOfLines];

            int counter = 0;

            int sum = 0;

            int total = 0;

            while (counter < countOfLines)
            {
                string input = Console.ReadLine();

                int length = input.Length;

                foreach (char symbol in input)
                {
                    sum = 0;

                    switch (symbol)
                    {
                        //vowels
                        case 'a': sum += 'a'; sum *= length; break;
                        case 'e': sum += 'e'; sum *= length; break;
                        case 'u': sum += 'u'; sum *= length; break;
                        case 'i': sum += 'i'; sum *= length; break;
                        case 'o': sum += 'o'; sum *= length; break;
                        case 'A': sum += 'A'; sum *= length; break;
                        case 'E': sum += 'E'; sum *= length; break;
                        case 'U': sum += 'U'; sum *= length; break;
                        case 'O': sum += 'O'; sum *= length; break;
                        case 'I': sum += 'I'; sum *= length; break;
                        //consonants
                        case 'b': sum += 'b'; sum /= length; break;
                        case 'c': sum += 'c'; sum /= length; break;
                        case 'd': sum += 'd'; sum /= length; break;
                        case 'f': sum += 'f'; sum /= length; break;
                        case 'g': sum += 'g'; sum /= length; break;
                        case 'h': sum += 'h'; sum /= length; break;
                        case 'j': sum += 'j'; sum /= length; break;
                        case 'k': sum += 'k'; sum /= length; break;
                        case 'l': sum += 'l'; sum /= length; break;
                        case 'm': sum += 'm'; sum /= length; break;
                        case 'n': sum += 'n'; sum /= length; break;
                        case 'p': sum += 'p'; sum /= length; break;
                        case 'q': sum += 'q'; sum /= length; break;
                        case 'r': sum += 'r'; sum /= length; break;
                        case 's': sum += 's'; sum /= length; break;
                        case 't': sum += 't'; sum /= length; break;
                        case 'v': sum += 'v'; sum /= length; break;
                        case 'w': sum += 'w'; sum /= length; break;
                        case 'x': sum += 'x'; sum /= length; break;
                        case 'y': sum += 'y'; sum /= length; break;
                        case 'z': sum += 'z'; sum /= length; break;
                        case 'B': sum += 'B'; sum /= length; break;
                        case 'C': sum += 'C'; sum /= length; break;
                        case 'D': sum += 'D'; sum /= length; break;
                        case 'F': sum += 'F'; sum /= length; break;
                        case 'G': sum += 'G'; sum /= length; break;
                        case 'H': sum += 'H'; sum /= length; break;
                        case 'J': sum += 'J'; sum /= length; break;
                        case 'K': sum += 'K'; sum /= length; break;
                        case 'L': sum += 'L'; sum /= length; break;
                        case 'M': sum += 'M'; sum /= length; break;
                        case 'N': sum += 'N'; sum /= length; break;
                        case 'P': sum += 'P'; sum /= length; break;
                        case 'Q': sum += 'Q'; sum /= length; break;
                        case 'R': sum += 'R'; sum /= length; break;
                        case 'S': sum += 'S'; sum /= length; break;
                        case 'T': sum += 'T'; sum /= length; break;
                        case 'V': sum += 'V'; sum /= length; break;
                        case 'W': sum += 'W'; sum /= length; break;
                        case 'X': sum += 'X'; sum /= length; break;
                        case 'Y': sum += 'Y'; sum /= length; break;
                        case 'Z': sum += 'Z'; sum /= length; break;
                        default: sum += symbol; sum /= length; break;
                    }

                    total += sum;
                }

                result[counter] = total;

                total = 0;

                counter++;
            }

            int temp;

            for (int i = 0; i < counter; i++)
            {
                for (int k = i + 1; k < counter; k++)
                {
                    if (result[i] > result[k])
                    {
                        temp = result[i];
                        result[i] = result[k];
                        result[k] = temp;
                    }
                }
            }

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
