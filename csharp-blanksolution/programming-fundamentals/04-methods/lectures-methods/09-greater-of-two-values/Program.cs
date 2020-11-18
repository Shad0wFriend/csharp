using System;

namespace _09_greater_of_two_values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string text = "";

            switch (type)
            {
                case "int": text = "int"; break;
                case "char": text = "char"; break;
                case "string": text = "string"; break;
            }

            string result = BiggerValue(text);

            Console.WriteLine(result);
        }

        public static string BiggerValue(string text)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            if (text == "int")
            {
                return Math.Max(int.Parse(a), int.Parse(b)).ToString();
            }
            else if (text == "char")
            {
                int tmp1 = (int)(char.Parse(a));
                int tmp2 = (int)(char.Parse(b));

                int result = Math.Max(tmp1, tmp2);

                if (result == tmp1)
                {
                    return a.ToString();
                }
                else
                {
                    return b.ToString();
                }
            }
            else if (text == "string")
            {
                int comparison = a.CompareTo(b);
                //1 -> a > b 0 -> a = b -1 -> a < b

                if (comparison > 0)
                {
                    return a;
                }
                else
                {
                    return b;
                }

            }

            return "";
        }
    }
}
