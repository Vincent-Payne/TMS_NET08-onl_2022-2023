using System.Text;

namespace _03_Strings_Practice_07_12_2022
{
    internal class Program
    {
        //Задание
        //    1) Найти короткое/длинное слово в строке
        //    2) Слово с минимальным количеством различных символов
        //    3) Проверить первое слово на полиндром
        //    4) Подублировать каждый буквенный символ в строке.

        //Method to find the longest word in the string
        public static string MaxLenStr(string[] words)
        {
            int maxlen = words[0].Length;
            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > maxlen)
                {
                    maxlen = words[i].Length;
                    index = i;
                }
            }
            return words[index];
        }

        //Method to find the smallest word in the string
        public static string MinLenStr(string[] words)
        {
            int minlen = words[0].Length;
            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < minlen)
                {
                    minlen = words[i].Length;
                    index = i;
                }
            }
            return words[index];
        }

        //Method to check the first word for palindrome
        public static bool Palindrome(string[] words)
        {
            // Using System.Linq to convert string to char array and reverse it 
            string reversed = new string(words[0].ToCharArray().Reverse().ToArray());
            bool answer = false;
            if (words[0] == reversed)
            {
                answer = true;
            }
            return answer;
        }

        //Method to dublicate chars 
        public static string[] DublChars(string[] input)
        {
            StringBuilder str_build = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char[] chars = input[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    // Checking if char is the letter
                    if (Char.IsLetter(chars[j]))
                    {
                        str_build.Append(chars[j]).Append(chars[j]);
                    }
                    else
                    {
                        str_build.Append(chars[j]);
                    }
                }
                // Rewriting oroginal string
                input[i] = str_build.ToString();
                // Cleaning StringBuilder for the next iteration
                str_build.Clear();
            }
            return input;
        }

        // Method to print 1D Arrays
        public static void Print1DArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
        }

        static void Main(string[] args)
        {
            string input_txt = " ";
            Console.WriteLine("Please, enter some text");
            input_txt = Console.ReadLine();

            // Splitting input_txt by words
            string[] words = input_txt.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("The longest word is {0}", MaxLenStr(words));
            Console.WriteLine("The smallest word is {0}", MinLenStr(words));
            Console.WriteLine("The first word is palindrome - {0}", Palindrome(words));
            Console.WriteLine("Doubled chars in the string:");
            Print1DArray((DublChars(words)));
            Console.ReadKey();




        }
    }
}