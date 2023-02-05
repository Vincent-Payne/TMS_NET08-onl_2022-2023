namespace _02_Strings_Practice_05_12_2022
{
    internal class Program
    {
        // Method to print 2D Arrays
        public static void Print2DArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Method to find the Average
        static double GetAverage(int[,] massiv)
        {
            double sum = 0;
            foreach (var elementMass in massiv)
            {
                sum += elementMass;
            }
            return sum / massiv.Length;
        }

        // Method to find Maximum element of array
        static double GetMax(int[,] mass)
        {
            int max = mass[0, 0];
            foreach (var zeroDem in mass)
            {
                if (max < zeroDem)
                {
                    max = zeroDem;
                }
            }
            return max;
        }

        // Method to find Maximum element in a row
        static void GetMaxInRow(int[,] mass)
        {
            int max = mass[0, 0];
            for (int i = 0; i < 10; i++)
            {
                max = mass[i, 0];
                for (int j = 0; j < 10; j++)
                    if (max <= mass[i, j])
                    {
                        max = mass[i, j];
                    }
                Console.WriteLine("Max element in row {0} is {1}", i + 1, max);
            }
        }



        static void Main(string[] args)
        {
            // Declaring array
            int[,] massiv = new int[10, 10];
            // Creating Random instance
            var rnd_num = new Random();
            // Garbaging computer memmory ¯\_(ツ)_/¯
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) { massiv[i, j] = rnd_num.Next(-1000, 1000); }
            };
            //Print array
            Console.WriteLine("Your array is:");
            Print2DArray(massiv);
            Console.WriteLine();

            var average = GetAverage(massiv);
            var maximum = GetMax(massiv);

            //Output
            Console.WriteLine("The array's max element is " + maximum + "\n");
            Console.WriteLine("The average is " + average + "\n");
            GetMaxInRow(massiv);
            Console.WriteLine();
            //GetMinInColumn(massiv);
            Console.ReadKey();

        }
    }
}