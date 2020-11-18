using System;

namespace _16_decrypting_messages
{
    class Program
    {
        static void Main(string[] args)
        {
            //plain text -> key -> encryption -> cypher text -> key -> decryption -> plain text


            int key = int.Parse(Console.ReadLine());
            int countOfLines = int.Parse(Console.ReadLine());

            int counter = 1;
            char symbol = ' ';
            string cypherText = "";

            while (counter <= countOfLines)
            {
                symbol = char.Parse(Console.ReadLine());

                char encryptedSymbol = (char)(symbol + key);

                cypherText += encryptedSymbol.ToString();

                counter++;
            }

            Console.WriteLine(cypherText);
        }
    }
}
