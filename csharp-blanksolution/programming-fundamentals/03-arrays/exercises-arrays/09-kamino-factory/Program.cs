using System;
using System.Linq;

namespace _09_kamino_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter = 0;
            int subsequence = 0;
            int index = 0;
            int previousIndex = 0;
            int previousSubsequence = 0;
            int sequenceIndexCounter = 1;
            int sequenceIndex = 1;
            int equalIndex = 0;
            int equalSum = 0;

            int[] sequence = new int[length];

            bool isCapsuledSequence = true;
            bool isCapsuledPreviousSubsequence = true;

            while (input != "Clone them!")
            {
                int[] numbers = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int k = i; k < numbers.Length; k++)
                    {
                        if (numbers[i] == numbers[k] && numbers[i] == 1)
                        {
                            counter++;
                            previousIndex = i;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (counter == length)
                    {
                        index = previousIndex;
                        subsequence = counter;
                        counter = 0;
                        break;
                    }

                    if (isCapsuledSequence)
                    {
                        subsequence = counter;
                        index = previousIndex;
                        isCapsuledSequence = false;
                    }

                    if (subsequence < counter)
                    {
                        index = previousIndex;
                        subsequence = counter;
                    }

                    counter = 0;
                }

                int sum = numbers.Sum();

                if (isCapsuledPreviousSubsequence == false)
                {
                    sequenceIndexCounter++;
                    if (previousSubsequence < subsequence)
                    {
                        previousSubsequence = subsequence;
                        sequence = numbers;
                        sequenceIndex = sequenceIndexCounter;
                        equalIndex = index;
                        equalSum = sum;
                    }
                    else if (previousSubsequence == subsequence)
                    {
                        if (equalIndex > index)
                        {
                            sequence = numbers;
                            sequenceIndex = sequenceIndexCounter;
                            equalIndex = index;
                            equalSum = sum;
                        }
                        else if (equalIndex == index)
                        {
                            if (equalSum < sum)
                            {
                                sequence = numbers;
                                equalSum = sum;
                                sequenceIndex = sequenceIndexCounter;
                            }
                        }
                    }
                }

                if (isCapsuledPreviousSubsequence)
                {
                    previousSubsequence = subsequence;
                    sequence = numbers;
                    equalIndex = index;
                    equalSum = sum;
                    isCapsuledPreviousSubsequence = false;
                }

                subsequence = 0;
                index = 0;
                sum = 0;
                isCapsuledSequence = true;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {sequenceIndex} with sum: {equalSum}.");

            Console.WriteLine(string.Join(' ', sequence));
        }
    }
}
