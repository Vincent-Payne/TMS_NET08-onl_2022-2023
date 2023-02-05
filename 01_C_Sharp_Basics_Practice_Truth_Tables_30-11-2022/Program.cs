namespace _01_C_Sharp_Basics_Practice_Truth_Tables_30_11_2022
{
    internal class Program
    {
        static bool Implication(bool x, bool y)
        {
            bool rezult;
            rezult = !x || y;
            return (rezult);
        }
        static bool Converse(bool x, bool y)
        {
            bool rezult;
            rezult = x || !y;
            return (rezult);
        }
        static bool Sheffer_stroke(bool x, bool y)
        {
            bool rezult;
            rezult = !x || !y;
            return (rezult);
        }
        static bool Peirce_arrow(bool x, bool y)
        {
            bool rezult;
            rezult = !x && !y;
            return (rezult);
        }

        static void Main(string[] args)
        {
            bool x, y;
            Console.WriteLine("Введите значения true или false для логических переменных x и y");
            x = bool.Parse(Console.ReadLine());
            y = bool.Parse(Console.ReadLine());
            Console.WriteLine("Импликация: " + Implication(x, y));
            Console.WriteLine("Обратная Импликация: " + Converse(x, y));
            Console.WriteLine("Штрих Шеффера: " + Sheffer_stroke(x, y));
            Console.WriteLine("Стрелка Пирса: " + Peirce_arrow(x, y));
            Console.ReadLine();
        }
    }
}