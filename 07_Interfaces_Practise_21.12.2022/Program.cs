namespace _07_21._12._2022_Practise
{
    internal class Program
    {
        public interface ILaunchStation
        {
            void Start(string transport)
            {
                Console.WriteLine($"I'm flying on {transport}");
            }
        }
        public class Transport: ILaunchStation
        {
            string transport;

        }
        
        static void Main(string[] args)
        {
            
        }
    }
}