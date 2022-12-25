namespace _07_Strategy_Pattern_Practice_21_12_2022
{
    internal class Program
    {
        /*Описать систему старотовой установки которая запускает вас в полёт на каком-то объекте.
        В процессе полёта необходимо вывести сообщение "Я лечу на {название_объекта}"
        Объекты в стартовую установку передать в конструкторе*/
        public interface ILaunchStation
        {
            string Launch();
        }
        public class Broomstick : ILaunchStation
        {
            public string Launch()
            {
                return "Broomstick";
            }
        }
        public class Wings : ILaunchStation
        {
           public string Launch()
            {
                return "Wings";
            }
                
        }
        public class MagicCarpet : ILaunchStation
        {
            public string Launch() 
            {
                return "Magic Carpet";
            }

        }

        class LaunchStation
        {
            public ILaunchStation ilaunch_station;
            public LaunchStation(ILaunchStation ils)
            {
                ilaunch_station = ils;
            }
            public string BeginFlight() 
            {
                return ilaunch_station.Launch();
            }
        }

        static void Main(string[] args)
        {

            Broomstick broomstick = new Broomstick();
            MagicCarpet magic_carpet = new MagicCarpet();
            Wings wings = new Wings();
            LaunchStation launchStation = new LaunchStation(broomstick);
            LaunchStation launchStation1 = new LaunchStation(magic_carpet);
            LaunchStation launchStation2 = new LaunchStation(wings);

            Console.WriteLine($"I'm flying on {launchStation.BeginFlight()}");
            Console.WriteLine($"I'm flying on {launchStation1.BeginFlight()}");
            Console.WriteLine($"I'm flying on {launchStation2.BeginFlight()}");
        }
    }
}