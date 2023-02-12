using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apartments
{
/*Реализовать компонент View в ваших самостоятельных работах при помощи делегатов + 
Используя событийную модель реализовать подпись на событие:
1. Автосалон - пустой автосалон(закончились автомобили)
2. Больница - переполнение(количество больных больше 15)
3. Салон связи - нет модели(удалили последний телефон бренда)
4.Риэлторская фирма - поступление новой квартиры
5.Магазин одежды - переполнение склада(больше 20 элементов одежды)
Реализовать подписку минимум 2 разных классов на событие(функционал реализации - на ваше усмотрение)*/

    internal class Program
    {
        delegate void View(string message);
        static void ConsoleOutput(string output)
        {
            Console.WriteLine(output);
        }

        public interface INotification
        {
            string Notification(string notification);
        }

        public class Customer: INotification
        {
            public string customerData;
            public Customer(string data) 
            { 
                this.customerData = data; 
            }
            public string Notification(string str)
            {
                return $"Hi {customerData}. {str}";
            }
        }

        public class Employee: INotification
        {
            public string employeeData;
            public Employee(string data)
            {
                this.employeeData = data;
            }
            public string Notification(string str)
            {
                return $"Hi {employeeData}, {str}";
            }

        }

        static void SubscriptionForCustomers(DataBase db)
        {
            List<INotification> customersList = new List<INotification>();
            customersList.Add(new Customer("Gabe Newell"));
            customersList.Add(new Customer("Bill Gates"));
            foreach (var customerItem in customersList)
            {
                db.NotifyAddFlat += str => Console.WriteLine(customerItem.Notification(str));
                db.NotifyDeleteFlat += str => Console.WriteLine(customerItem.Notification(str));

            }
        }
        static void SubscriptionForEmployees(DataBase db)
        {
            List<INotification> employeesList = new List<INotification>();
            employeesList.Add(new Employee("Pavel Dyachuk"));
            employeesList.Add(new Employee("Vincent van Gogh"));
            foreach (var employeeItem in employeesList)
            {
                db.NotifyAddFlat += str => Console.WriteLine(employeeItem.Notification(str));
                db.NotifyDeleteFlat += str => Console.WriteLine(employeeItem.Notification(str));
                db.NotifyUpdatePrice += str => Console.WriteLine(employeeItem.Notification(str));
                db.NotifyUpdateAddress += str => Console.WriteLine(employeeItem.Notification(str));

            }
        }

        internal class DataBase
        {
            public event Action<string>? NotifyAddFlat;
            public event Action<string>? NotifyDeleteFlat;
            public event Action<string>? NotifyUpdatePrice;
            public event Action<string>? NotifyUpdateAddress;

            List<Flat> database = new List<Flat>();
            public uint GetLastElementId => database.Count == 0 ? 0 : database.Last().id;
            public void AddFlat(Flat flat)
            {
                database.Add(flat);
                NotifyAddFlat?.Invoke($"Flat was added");
            }
            public void DeleteFlat(int id)
            {
                Flat temp = database.Find(item => item.id == id);
                database.Remove(temp);
                NotifyDeleteFlat?.Invoke($"Flat with id:{temp.id} was deleted");
            }

            public void UpdatePrice(int id, float price)
            {
                Flat temp = database.Find(item => item.id == id);
                temp.price = price;
                NotifyUpdatePrice.Invoke($"Flat's Price with id:{temp.id} was updated");
            }

            public void UpdateAdress(int id, string address)
            {
                Flat temp = database.Find(item => item.id == id);
                temp.address = address;
                NotifyUpdateAddress.Invoke($"Flat's Address with id:{temp.id} updated");
            }

            public float GetAverage()
            {
                float average = 0;
                foreach (Flat item in database)
                {
                    average += item.price;
                }
                return average /= database.Count;
            }

            public string GetFullInfo()
            {
                StringBuilder sb = new StringBuilder();
                foreach (var flat in database)
                {
                    sb.Append("ID: ").AppendLine(flat.id.ToString());
                    sb.Append("Rooms: ").AppendLine(flat.rooms.ToString());
                    sb.Append("Price: ").AppendLine(flat.price.ToString());
                    sb.Append("Address: ").AppendLine(flat.address);
                    sb.AppendLine();
                }
                return sb.ToString();
            }

        }

        internal class Flat
        {
            public uint id;
            public byte rooms;
            public float price;
            public string address;

            public Flat(uint id, byte rooms, float price, string address)
            {
                this.id = id;
                this.rooms = rooms;
                this.price = price;
                this.address = address;
            }
        }

        static void Main(string[] args)
        {

            View view = ConsoleOutput;

            DataBase data = new DataBase();
            SubscriptionForEmployees(data);
            SubscriptionForCustomers(data);
            //data.NotifyAddFlat += str => Console.WriteLine(str);
            //data.NotifyDeleteFlat += str => Console.WriteLine(str);
            //data.NotifyUpdatePrice += str => Console.WriteLine(str);
            //data.NotifyUpdateAddress += str => Console.WriteLine(str);

            data.AddFlat(new Flat(data.GetLastElementId + 1, 1, 12, "Hrodna, Sovetskaya 25-1"));
            data.AddFlat(new Flat(data.GetLastElementId + 1, 2, 15, "Vitebsk, Oktyabrskaya 53-5"));
            data.AddFlat(new Flat(data.GetLastElementId + 1, 3, 16, "Gomel, Krasnaarmeyskaya 24-1"));
            data.AddFlat(new Flat(data.GetLastElementId + 1, 4, 17, "Minsk, Gvardeyskaya 14-51"));
            data.AddFlat(new Flat(data.GetLastElementId + 1, 5, 18, "Brest, Lenina 1-34"));
            data.AddFlat(new Flat(data.GetLastElementId + 1, 6, 19, "derevnya Vasuki, Pobeda 1-1"));

            data.UpdatePrice(2, 5000);
            data.UpdateAdress(1, "Lida, Fursenko 5-1");
            data.DeleteFlat(3);

            view(data.GetFullInfo());
        }

        //private static void Data_NotifyAddFlat(string obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}