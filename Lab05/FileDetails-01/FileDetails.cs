using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDetails_01
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            FileStream stream = new FileStream(fileName, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int size = (int)stream.Length;
            char[] contents = new char[size];
            for (int i = 0; i<size; i++)
            {
                contents[i] = (char)reader.Read();
            }
            foreach (char ch in contents)
            {
                Console.Write(ch);
            }

        }
        static void Summarize(char[] contents)
        {
            int vowels = 0;
            int consonants = 0;
            int lines = 0;
            foreach (char symbol in contents)
            {
                if (Char.IsLetter(symbol))
                {
                    if ("AEIOUaeiou".IndexOf(symbol) != -1)
                    {
                        vowels++;
                    } else
                    {
                        consonants++;
                    }
                } else if (symbol == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total no of characters: {0}", contents.Length);

            Console.WriteLine("Total no of vowels : {0}", vowels);

            Console.WriteLine("Total no of consonants: {0}", consonants);

            Console.WriteLine("Total no of lines : {0}", lines);

        }
    }
}
