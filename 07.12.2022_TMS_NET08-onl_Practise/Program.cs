using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_07._12._2022_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = " ";
            int maxlen, minlen, index;
            Console.WriteLine("Please, enter string");
            text = Console.ReadLine();

            // Splitting our text by words
            string[] words = text.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            
            // Assigning values
            maxlen = words[0].Length;
            index = 0;
            
            // Searching for the longest string
            for (int i = 0; i < words.Length; i++) 
            {
                if (words[i].Length > maxlen)
                {
                    maxlen = words[i].Length;
                    index = i;
                }
            }
            Console.WriteLine("The longest word is {0}", words[index]);

            // Assigning values
            minlen = words[0].Length;
            index = 0;

            // Searching for the smallest string
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < minlen)
                {
                    minlen = words[i].Length;
                    index = i;
                }
            }

            Console.WriteLine("The smallest word is {0}", words[index]);
            Console.ReadKey();



        }
    }
}
