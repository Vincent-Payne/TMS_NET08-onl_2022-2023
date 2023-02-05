using System.Text;

namespace _11_Exceptions_Practise_11_01_2022
{
    /*Для своей предметной области из самостоятельной работы
Дополнить методы класса контейнера таким образом чтобы пробрасывались ошибки в случаях:
1) Если добавляется новый элемент, а достигнут лимит (лимит указываете сами)
2) Если удаляется элемент, а такого элемента в списке нет
3) Если изменяется элемент, а такого элемента в списке нет
Для этих случаев разработать собственные классы с ошибками
Все ошибки обработать блоками try catch в вызывающем методе
*/
    internal class Program
    {
        internal class Flat
        {
            public uint id;
            public byte rooms;
            public float price;
            public string address;

            public Flat(uint id, int rooms, float price, string address)
            {
                this.id = id;
                this.rooms = checked((Byte)rooms);
                this.price = price;
                this.address = address;
            }
        }
        internal class DataBase
        {
            List<Flat> database = new List<Flat>();
            public uint GetLastElementId => database.Count == 0 ? 0 : database.Last().id;
            public void AddFlat(Flat flat)
            {
                database.Add(flat);
            }
            public void DeleteFlat(int id)
            {
                Flat temp = database.Find(item => item.id == id);
                database.Remove(temp);
            }

            public void UpdatePrice(int id, float price)
            {
                Flat temp = database.Find(item => item.id == id);
                temp.price = price;
            }

            public void UpdateAdress(int id, string address)
            {
                Flat temp = database.Find(item => item.id == id);
                temp.address = address;
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

        static void Main(string[] args)
        {
            DataBase data = new DataBase();

            data.AddFlat(new Flat(data.GetLastElementId + 1, 1, 12, "Hrodna, Sovetskaya 25-1"));
            try 
            { 
                data.AddFlat(new Flat(data.GetLastElementId + 1, 5000, 50, "Vitebsk, Oktyabrskaya 53-5")); 
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Vitebsk, Oktyabrskaya 53 - 5. Too many rooms. Please, check rooms quantity");
            }

            try
            {
                data.UpdatePrice(3, 5000);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Wrong id, no such object in database to update price.");
            }

            try
            {
                data.UpdateAdress(3, " ");
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Wrong id, no such object in database to update address.");
            }

            // Не выбрасывает exception, т.к. по дизайну DeleteFlat не может удалить несуществующий объект.
            try
            {
                data.DeleteFlat(10);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Wrong id, no such object in database to delete.");
            }



            //data.AddFlat(new Flat(data.GetLastElementId + 1, 3, 16, "Gomel, Krasnaarmeyskaya 24-1"));
            //data.AddFlat(new Flat(data.GetLastElementId + 1, 4, 17, "Minsk, Gvardeyskaya 14-51"));
            //data.AddFlat(new Flat(data.GetLastElementId + 1, 5, 18, "Brest, Lenina 1-34"));
            //data.AddFlat(new Flat(data.GetLastElementId + 1, 6, 19, "derevnya Vasuki, Pobeda 1-1"));
            //data.UpdateAdress(1, "Lida, Fursenko 5-1");
            Console.WriteLine(data.GetFullInfo());
        }
    }
}