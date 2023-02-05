namespace Task_2
{
    
/*2. Создать классы "Директор", "Рабочий", "Бухгалтер". 
Реализовать интерфейс с методом, который печатает название должности и имплементировать этот метод в созданные классы.
*/
    internal class Program
    {
        public interface IEmployee
        {
            string GetInfo();
        }

        public class Director : IEmployee
        {
            string jod_title = "Director";
            public string GetInfo()
            {
                return jod_title;
            }
        }

        public class Accountant : IEmployee
        {
            string jod_title = "Accountant";
            public string GetInfo()
            {
                return jod_title;
            }
        }

        public class Worker : IEmployee
        {
            string jod_title = "Worker";
            public string GetInfo()
            {
                return jod_title;
            }
        }

        static void Main(string[] args)
        {
           Director director = new Director();
           Accountant accountant = new Accountant();
           Worker worker = new Worker();
           Console.WriteLine($"{director.GetInfo()} ");
           Console.WriteLine($"{accountant.GetInfo()} ");
           Console.WriteLine($"{worker.GetInfo()} ");
        }
    }
}