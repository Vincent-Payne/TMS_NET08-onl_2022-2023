namespace _04_OOP_Basics_Homework_12_12_2022
{
    //Создайте класс Phone, который содержит переменные number, model и weight. +
    //Создайте три экземпляра этого класса. +
    //Выведите на консоль значения их переменных для каждого экземпляра.+
    //Добавить в класс Phone методы: 
    //  receiveCall, имеет один параметр – имя звонящего. Выводит на консоль сообщение “Звонит { name}”.  +
    //  getNumber – возвращает номер телефона. +
    //Вызвать эти методы для каждого из объектов. +
    //Добавьте перегруженный метод receiveCall, который принимает два параметра - имя звонящего и номер телефона звонящего.Вызвать этот метод. +
    //Создать метод sendMessage с аргументами переменной длины.Данный метод принимает на вход номера телефонов,
    //которым будет отправлено сообщение. Метод выводит на консоль номера этих телефонов. +

    internal class Program
    {
        class Phone
        {
            public string number, model, weight;

            public void PrintFullInfo()
            {
                Console.WriteLine("Model: {0}", model);
                Console.WriteLine("Weight: {0}", weight);
                Console.WriteLine("Phone Number: {0}", number);
                Console.WriteLine();
            }

            public string GetNumber()
            {
                return number;
            }

            public void ReceiveCall(string name)
            {
                Console.WriteLine("{0} is calling", name);
            }

            public void ReceiveCall(string name, string phone_number)
            {
                Console.WriteLine("Incoming call: \n{0}\n{1}", name, phone_number);
            }

            public void SendMessage(params string[] phone_numbers)
            {
                foreach (var phone in phone_numbers)
                {
                    Console.WriteLine(phone);
                }
            }

        }

        static void Main(string[] args)
        {
            Phone alcatel = new Phone();
            Phone htc = new Phone();
            Phone benq = new Phone();

            alcatel.number = "+375(25)555-55-55";
            htc.number = "+375(29)999-99-99";
            benq.number = "+375(44)444-44-44";

            alcatel.model = "Alcatel OT-311";
            htc.model = "HTC Wildfire";
            benq.model = "BenQ-Siemens E71";

            alcatel.weight = "99";
            htc.weight = "118";
            benq.weight = "80";

            alcatel.PrintFullInfo();
            htc.PrintFullInfo();
            benq.PrintFullInfo();

            alcatel.ReceiveCall("Mihal Palych Terentev");
            htc.ReceiveCall("Gabe Newell");
            benq.ReceiveCall("Mother");

            Console.WriteLine(); // For better reading experience   

            Console.WriteLine("Alcatel phone number is: {0}", alcatel.GetNumber());
            Console.WriteLine("HTC phone number is: {0}", htc.GetNumber());
            Console.WriteLine("BenQ phone number is: {0}", benq.GetNumber());

            Console.WriteLine(); // For better reading experience

            alcatel.ReceiveCall("Mihal Palych Terentev", "+375(17)22505");
            Console.WriteLine(); // For better reading experience
            htc.ReceiveCall("Gabe Newell", "+375(29)202-03-27");
            Console.WriteLine(); // For better reading experience
            benq.ReceiveCall("Mother", "911");

            Console.WriteLine(); // For better reading experience

            alcatel.SendMessage("+375(17)000-00-00", "+375(25)123-456-789", "105", "103");


        }
    }
}