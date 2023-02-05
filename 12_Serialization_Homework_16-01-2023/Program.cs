using System.Text.Json;
using System.Xml;
using System.Windows.Forms;

namespace _12_Serialization_Homework_16_01_2022
{
    /* Написать программу для парсинга JSON документа.Программа на вход получает строку к папке, где находится документ.
    Распарсить нужно только один документа - соответственно, предусмотреть различные проверки, например на то, 
    что в папке нет файлов, или в папке несколько документов формата JSON и другие возможные проверки.
    Необходимо распарсить JSON документ в объект Squad, а затем сохранить в виде xml 
    Название файла для записи должно состоять из значений тегов и имеет вид: <squadName>.xml*/

    //Объяснение по шагам.
    /*Создаете класс Squad
    Создаете объект этого класса
    Сериализуете в json, записываете в файл с расширением.json
    Далее тянете этот файл
    достаете из файла строку
    Парсите используя свой алгоритм парсинга, который напишете
    Полученный новый объект сериализуете в Xml*/

    public class Program
    {
        [Serializable]
        public class Squad
        {
            public string SquadId { get; set; }
            public string SquadName { get; set; }
            public string SquadCommander { get; set; }
            public byte SquadQuantity { get; set; }

            public void CreateSquad(string squad_id, string squad_name, string squad_commander, byte squad_quantity)
            {
                SquadId = squad_id;
                SquadName = squad_name;
                SquadCommander = squad_commander;
                SquadQuantity = squad_quantity;
            }
            public string GetSquad()
            {
                return ($"Squad ID: {SquadId}\nSquad Name: {SquadName}\nSquad Commander: {SquadCommander}\nSquad Quantity: {SquadQuantity}");
            }

        }

        [STAThread]
        static void Main(string[] args)
        {
            /*Выбор папки для записи файла
             * 
            Требует строк в 12_Serialization_Homework_16-01-2022.csproj
            <TargetFramework>net6.0-windows</TargetFramework>
            <UseWindowsForms> true </UseWindowsForms>*/
            FolderBrowserDialog folder_path = new FolderBrowserDialog();
            folder_path.ShowDialog();

            Squad squad = new Squad();
            Squad squad2 = new Squad();
            squad.CreateSquad("1", "N7", "Commander Shepard", 12);

            //Сериализация в json
            string fileName = "Squad.json";
            string jsonString = JsonSerializer.Serialize(squad);
            File.WriteAllText(folder_path.SelectedPath + fileName, jsonString);

            //Выбор файла для десериализации
            OpenFileDialog file_path_dialog = new OpenFileDialog();
            file_path_dialog.Title = "Choose file to deserialize";
            file_path_dialog.Filter = "JSON|*.json";
            file_path_dialog.ShowDialog();


            
            try
            {
                //Десериализация
                fileName = file_path_dialog.FileName;
                jsonString = File.ReadAllText(fileName);
                squad2 = JsonSerializer.Deserialize<Squad>(jsonString)!;
                //squad2.GetSquad();

                //Сериализация в XML
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Squad));
                System.IO.FileStream file = System.IO.File.Create(folder_path.SelectedPath + $"{squad2.SquadName}.xml");
                writer.Serialize(file, squad2);
                file.Close();
            }
            catch (Exception warning_msg) { Console.WriteLine(warning_msg.Message); }


        }
    }
}