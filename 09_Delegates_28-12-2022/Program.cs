namespace _09_Delegates_28_12_2022
{
    internal class Program
    {
        delegate void FirstDelegate(string s);//* -> place in Heap

        static void Main(string[] args)
        {
            Retailer pub = new Retailer();

            List<INotifyable> listOfCustomers = new List<INotifyable>();
            listOfCustomers.Add(new Customer("Tommy"));
            listOfCustomers.Add(new ForeignCustomer("Jim"));

            foreach (var cust in listOfCustomers)
            {
                pub.OnIphoneAppers += cust.Notify;
            }

            pub.Raise();
        }

    }



    class Retailer
    {
        public event Action OnIphoneAppers;

        public void Raise()
        {
            var day = DateTime.Now;
            while (true)
            {
                Console.WriteLine($"Today is {day}");
                if (day.Day == 25)
                {
                    OnIphoneAppers();
                }

                day = day.AddDays(1);

                Thread.Sleep(500);
            }
        }
    }

    interface INotifyable
    {
        void Notify();
    }

    class Customer : INotifyable
    {
        public string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public void Notify()
        {
            Console.WriteLine($"Notify {name} if IPhone appears");
        }
    }

    class ForeignCustomer : INotifyable
    {
        public string name;

        public ForeignCustomer(string name)
        {
            this.name = name;
        }

        public void Notify()
        {
            Console.WriteLine($"Text to {name} if IPhone appears");
        }
    }
}