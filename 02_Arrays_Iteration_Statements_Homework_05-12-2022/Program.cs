namespace _02_Strings_Homework_05_12_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining array
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            // Defining input data variable
            int input = 0;
            Console.WriteLine("Please, input number from 1 to 7");
            // Converting input to integer
            input = Convert.ToInt32(Console.ReadLine());
            // Logic processing
            if (input > 0 && input <= 7)
            { Console.WriteLine(weekDays[input - 1]); }
            else
            { Console.WriteLine("Invalid input data"); }
            Console.ReadKey();

        }
    }
}