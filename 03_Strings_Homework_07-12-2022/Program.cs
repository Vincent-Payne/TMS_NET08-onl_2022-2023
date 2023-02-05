namespace _03_Strings_Homework_07_12_2022
{
    internal class Program
    {
        /*ДЗ по Массивам/циклам
        0. При помощи цикла for вывести на экран нечетные числа от  1 до 99. 
        При решении используйте операцию инкремента(++). 
        1. Необходимо вывести на экран числа от 5 до 1. 
        При решении используйте операцию декремента(--). 
        2. Напишите программу, где пользователь вводит любое целое положительное число.А программа суммирует все числа от 1 до введенного пользователем числа. 
        Для ввода числа воспользуйтесь Console.ReadLine.
        3. Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска задается с консоли (класс Scanner). 
        4. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение. 
        Для генерации случайного числа используйте метод Math.random(). Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли. 
        5. Создайте 2 массива из 5 чисел.
        Выведите массивы на консоль в двух отдельных строках. 
        6. Выведите на экран первые 11 членов последовательности  Фибоначчи.
        7. Создайте массив и заполните массив.
        Выведите массив на экран в строку. 
        Замените каждый элемент с нечётным индексом на ноль. 
        Снова выведете массив на экран на отдельной строке. 
        8. Создайте массив строк.Заполните его произвольными именами людей.
        Отсортируйте массив. 
        Результат выведите на консоль.

        ДЗ по строкам
        Написать программу со следующим функционалом: 
        На вход передать строку (будем считать, что это номер документа). Номер документа имеет формат xxxx-yyy-xxxx-yyy-xyxy, где x — это число, а y — это буква.
        - Вывести на экран в одну строку два первых блока по 4 цифры.
        - Вывести на экран номер документа, но блоки из трех букв заменить на*** (каждая буква заменятся на*). 
        - Вывести на экран только одни буквы из номера документа в формате yyy/yyy/y/y в нижнем регистре.
        - Вывести на экран буквы из номера документа в формате "Letters:yyy/yyy/y/y" в верхнем регистре(реализовать с помощью класса StringBuilder).
        - Проверить содержит ли номер документа последовательность abc и вывети сообщение содержит или нет(причем, abc и ABC считается одинаковой последовательностью). 
        - Проверить начинается ли номер документа с последовательности 555. 
        - Проверить заканчивается ли номер документа на последовательность 1a2b.
        Все эти методы реализовать в отдельном классе в статических методах, которые на вход(входным параметром) будут принимать вводимую на вход программы строку.*/

        public class Scanner
        {
            public int keyboard_input { get; set; }
        }

        public class DocNumber
        {
            public string numberFull;
            public string num1;
            public string str1;
            public string num2;
            public string str2;
            public string numstr;

            public void PrintFull()
            {
                Console.WriteLine($"{num1}-{str1}-{num2}-{str2}-{numstr}");
            }

            public void PrintFirstNumBlocks()
            {
                Console.WriteLine($"{num1}-{num2}");
            }
            public void PrintFullLetterBlocksHide()
            {
                Console.WriteLine($"{num1}-***-{num2}-***-{numstr}");
            }
            public void PrintLettersOnlyLowerCase()
            {
                string str = numstr.ToLower();
                char[] chars = str.ToCharArray();
                Console.WriteLine($"{str1.ToLower()}/{str2.ToLower()}/{chars[1]}/{chars[3]}");
            }

            public void PrintLettersOnlyUpperCase()
            {
                string str = numstr.ToUpper();
                char[] chars = str.ToCharArray();
                Console.WriteLine($"{str1.ToUpper()}/{str2.ToUpper()}/{chars[1]}/{chars[3]}");
            }
            public void PrintIsSequence()
            {
                string sequence = "abc";
                if ((numberFull.IndexOf(sequence) > -1) | ((numberFull.IndexOf(sequence.ToUpper()) > -1))) { Console.WriteLine("Found abc or ABC sequence"); }
                else { Console.WriteLine("Didn't find abc or ABC sequence"); }
            }
            public void Is555()
            {
                // Better to use StartsWith?
                string str = num1;
                char[] chars = str.ToCharArray();
                if (chars[0] == '5' & chars[1] == '5' & chars[2] == '5') { Console.WriteLine("Document number begins with 555"); }
                else { Console.WriteLine($"Document number Does NOT begins with 555"); }
            }

            public void IS1a2b()
            {
                // Better To Use EndsWith?
                if (numstr == "1a2b") { Console.WriteLine("Document number ends with 1a2b"); }
                else { Console.WriteLine($"Document number Does NOT ends with 1a2b"); }
            }

        }

        static void Main(string[] args)
        {
            // 0) Print odd numbers
            Console.WriteLine("Task 0");
            Console.WriteLine("Odd numbers:");
            for (int i = 1; i < 100; i++) { Console.Write("{0} ", i++); };
            Console.WriteLine("");

            // For better reading experience
            Console.WriteLine("");

            // 1) Print numbers from 5 to 1
            Console.WriteLine("Task 1");
            Console.WriteLine("Numbers from 5 to 1:");
            for (int i = 5; i > 0; i--) { Console.Write("{0} ", i); };
            Console.WriteLine("");
            // For better reading experience
            Console.WriteLine("");

            // 2) Summ numbers from 1 to x, where x inputed by user
            Console.WriteLine("Task 2");
            uint pdn;
            uint summa_pdn = 0;
            Console.WriteLine("Enter positive decimal number to find summ from 1 to entered number");
            pdn = uint.Parse(Console.ReadLine());
            summa_pdn = (pdn * (pdn + 1)) / 2;
            Console.WriteLine("Summ from 1 to {0} = {1}", pdn, summa_pdn);
            // For better reading experience
            Console.WriteLine("");

            // 3) Create array of integer. Figure out if inputed number is in array.
            Console.WriteLine("Task 3");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            bool answer = false;
            Scanner input = new Scanner();
            Console.WriteLine("Enter integer number to find out if it is in the array or not");
            input.keyboard_input = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++) { if (array[i] == input.keyboard_input) answer = true; };
            Console.WriteLine("Inputed number is in array - {0}", answer);
            // For better reading experience
            Console.WriteLine("");


            // 4) Create random array. Find and display: max, min, average
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter positive decimal number for array size");
            uint array_size = 0;
            array_size = uint.Parse(Console.ReadLine());
            int[] massiv = new int[array_size];

            // Creating Random instance
            var rnd_num = new Random();

            // Garbaging computer memmory ¯\_(ツ)_/¯
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = rnd_num.Next(-100, 100);
            }
            //Printing array
            Console.WriteLine("Your array:");
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.Write("{0} ", massiv[i]);
            }
            // For better reading experience
            Console.WriteLine("");

            // Finding the Average
            double sum = 0;
            double average = 0;
            foreach (var elementMass in massiv)
            {
                sum += elementMass;
            }
            average = sum / massiv.Length;

            // Finding Maximum element of array
            int max = massiv[0];
            foreach (var elementMass in massiv)
            {
                if (max < elementMass)
                {
                    max = elementMass;
                }
            }

            // Finding Minimum element of array
            int min = massiv[0];
            for (int i = 0; i < massiv.Length; i++)
                if (min >= massiv[i])
                {
                    min = massiv[i];
                }
            // Printing rezults
            Console.WriteLine("Maximum ellement {0}, Minimum ellement {1}, The Average {2:0.00}", max, min, average);
            // For better reading experience
            Console.WriteLine("");

            // 5) Create 2 arrays of 5 numbers. Display each array in a separate row
            Console.WriteLine("Task 5");
            int[] array5 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            int[] array52 = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, -2, -4, -6, -8, -10, -12, -14, -16, -18, -20 };
            Console.WriteLine("Two arrays in separate rows");
            for (int i = 0; i < array5.Length; i++)
            {
                Console.Write("{0} ", array5[i]);
            }
            Console.WriteLine("");
            for (int i = 0; i < array52.Length; i++)
            {
                Console.Write("{0} ", array52[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            // 6) Output first 11 Fibonacci numbers
            Console.WriteLine("Task 6");
            Console.WriteLine("First 11 Fibonacci numbers");
            Console.Write("0, 1, 1");
            int fibn = 1;
            int fibn_plus = 1;
            for (int i = 3; i < 11; i++)
            {
                int fib = fibn + fibn_plus;
                fibn = fibn_plus;
                fibn_plus = fib;
                Console.Write(", {0}", fib);
            }
            // For better reading experience
            Console.WriteLine("");
            Console.WriteLine("");

            // 7) Create array, output, replace odd members by 0 , output
            Console.WriteLine("Task 7");
            int[] massiv7 = new int[11];

            // Creating Random instance
            var rnd_num7 = new Random();

            // Garbaging computer memmory ¯\_(ツ)_/¯
            for (int i = 0; i < massiv7.Length; i++)
            {
                massiv7[i] = rnd_num7.Next(-100, 100);
            }
            //Printing array
            Console.WriteLine("Your array:");
            for (int i = 0; i < massiv7.Length; i++)
            {
                Console.Write("{0} ", massiv7[i]);
            }
            // For better reading experience
            Console.WriteLine("");
            // Output
            Console.WriteLine("Your new array:");
            for (int i = 0; i < massiv7.Length; i++)
            {
                if (i % 2 == 1) { massiv7[i] = 0; }
                Console.Write("{0} ", massiv7[i]);
            }
            // For better reading experience
            Console.WriteLine("");
            Console.WriteLine("");

            // 8) Create array of people names, sort, output
            Console.WriteLine("Task 8");
            string[] massiv8 = new string[] { "Sam", "John", "Pavel", "Andrey", "Alexey", "Victor", "Mihail", "SpongeBob", "Din" };
            Console.WriteLine("Your array:");
            for (int i = 0; i < massiv8.Length; i++)
            {
                Console.Write("{0} ", massiv8[i]);
            }
            // For better reading experience
            Console.WriteLine("");

            Array.Sort(massiv8);
            // For better reading experience
            Console.WriteLine("");
            // Output
            Console.WriteLine("Your new array:");
            for (int i = 0; i < massiv8.Length; i++)
            {
                Console.Write("{0} ", massiv8[i]);
            }
            // For better reading experience
            Console.WriteLine("");


            //Strings Task
            Console.WriteLine("Enter document number xxxx-yyy-xxxx-yyy-xyxy, where x — number, y — letter");
            DocNumber dN = new DocNumber();
            dN.numberFull = "5551-AcB-1234-aBc-1a2b";
            string[] words = dN.numberFull.Split(new char[] { '-' });
            dN.PrintFull();
            dN.num1 = words[0];
            dN.str1 = words[1];
            dN.num2 = words[2];
            dN.str2 = words[3];
            dN.numstr = words[4];
            dN.PrintFirstNumBlocks();
            dN.PrintFullLetterBlocksHide();
            dN.PrintLettersOnlyLowerCase();
            dN.PrintLettersOnlyUpperCase();
            dN.PrintIsSequence();
            dN.Is555();
            dN.IS1a2b();



        }



    }
}