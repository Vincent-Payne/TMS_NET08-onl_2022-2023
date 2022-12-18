using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace _05_14._12._2022_Homework
{
/*1. Создать класс для описания компьютера, в этом классе должны быть поля: стоимость, модель(строковый тип), RAM и HDD.
Для полей RAM и HDD следует создать свои собственные классы.Классы для RAM и HDD должны иметь конструктор по умолчанию и конструктор со всеми параметрами. 
Класс RAM имеет поля "название" и "объем". 
Класс HDD имеет поля "название", "объем" и "тип" (внешний или внутренний). 
Класс Computer должен иметь два конструктора: 
- первый - с параметрами стоимость и модель, 
- второй - со всеми полями.
При создании объекта "компьютер" с помощью первого конструктора должны создаваться поля RAM и HDD с помощью конструкторов по умолчанию.
В каждом из классов предусмотреть методы для вывода полной информации(вывод всех полей и всех значений). 
Тестовый сценарий для проверки: 
создать объект "компьютер 1" с помощью первого конструктора и вывести информацию на экран; 
создать объект "компьютер 2" с помощью второго конструктора и вывести информацию на экран.

2. Создать класс, описывающий банкомат.
Набор купюр, находящихся в банкомате, должен задаваться тремя
свойствами: 
количеством купюр номиналом 20, 50 и 100. 
Сделать метод для добавления денег в банкомат.
Сделать функцию, снимающую деньги, которая принимает сумму денег, а возвращает булевое значение - успешность выполнения операции.
При снятии денег функция должна распечатывать каким количеством купюр какого номинала выдаётся сумма.
Создать конструктор с тремя параметрами - количеством купюр каждого номинала.

3.Создать программу для имитации работы клиники. 
Пусть в клинике будет три врача: хирург, терапевт и дантист.
Каждый врач имеет метод «лечить», но каждый врач лечит по-своему.
Так же предусмотреть класс «Пациент» и класс «План лечения». Создать объект класса «Пациент» и добавить пациенту план лечения.
Так же создать метод, который будет назначать врача пациенту согласно плану лечения. 
Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить. 
Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить. 
Если план лечения имеет любой другой код – назначить терапевта и выполнить метод лечить.*/
    internal class Program
    {
        class Computer
        {
            public HDD hdd;
            public RAM ram;
            public decimal price;
            public string model;




            public Computer(string model, decimal price)
            {
                this.model = model;
                this.price = price;
                hdd = new HDD();
                ram = new RAM();
            }

            public Computer(string model, decimal price, HDD hdd, RAM ram)
            {
                this.model = model;
                this.price = price;
                this.hdd = hdd;
                this.ram = ram;
            }

            public void DisplayFullInfo()
            {
                // Setting up currency format
                CultureInfo usa = new CultureInfo("en-US");
                usa.NumberFormat.CurrencyPositivePattern = 3;
                usa.NumberFormat.CurrencyNegativePattern = 8;
                Console.WriteLine($"PC model: {model}, price {this.price.ToString("C2", usa)}");
                hdd.DisplayInfoHDD();
                ram.DisplayInfoRAM();


            }
        }

        class HDD
        {
            public string model_hdd;
            public int capacity_hdd;
            public string type;

            public HDD()
            {
                model_hdd = "Unknown";
                capacity_hdd = 0;
                type = "Unknown";
            }

            public HDD (string model_hdd, int capacity_hdd, string type)
            {
                this.model_hdd = model_hdd;
                this.capacity_hdd = capacity_hdd;
                this.type = type;
            }

            public void DisplayInfoHDD()
            {
                Console.WriteLine($"HDD: {model_hdd}, {capacity_hdd} TB, {type}");
            }
        }

        class RAM
        {
            public string model_ram;
            public int capacity_ram;

            public RAM()
            {
                model_ram = "Unknown";
                capacity_ram = 0;
            }

            public RAM (string model_ram, int capacity_ram)
            {
                this.model_ram = model_ram;
                this.capacity_ram = capacity_ram;
            }
            public void DisplayInfoRAM()
            {
                Console.WriteLine($"RAM: {model_ram}, {capacity_ram} GB");
            }
        }

        class ATM
        {
            public uint banknote_20, banknote_50, banknote_100;
            public uint give_banknote_20, give_banknote_50, give_banknote_100;


            public ATM()
            {
                banknote_20 = 500;
                banknote_50 = 300;
                banknote_100 = 150;
            }
            public ATM(uint b20, uint b50, uint b100)
            {
                banknote_20 += b20;
                banknote_50 += b50;
                banknote_100 += b100;
            }

            public void ATM_Info()
            {
                Console.WriteLine($"ATM contains:\nBanknotes 20 - {this.banknote_20}\nBanknotes 50 - {this.banknote_50}\nBanknotes 100 - {this.banknote_100}");
            }


            public void AddBanknotes(uint b20, uint b50, uint b100)
            {
                this.banknote_20 += b20;
                this.banknote_50 += b50;
                this.banknote_100 += b100;
            }

            public bool GetBanknotesRequest(uint b20, uint b50, uint b100)
            {
                if ((this.banknote_20 - b20 >= 0) & (this.banknote_50 - b50 >= 0) & (this.banknote_100 - b100 >= 0))
                {
                    this.give_banknote_20 = b20;
                    this.give_banknote_50 = b50;
                    this.give_banknote_100 = b100;
                    return true;
                }
                else 
                {
                    Console.WriteLine("Error: not enought currency in ATM");
                    return false; 
                }
            }

            public void OperationWithdraw(bool b)
            {
                if (b)
                {
                    Console.WriteLine("Operation successful");
                    Console.WriteLine($"Withdrawed: Banknotes 20 * {this.give_banknote_20}\nBanknotes 50 * {give_banknote_50}\nBanknotes 100 * {give_banknote_100}");
                    this.banknote_20 -= give_banknote_20;
                    this.banknote_50 -= give_banknote_50;
                    this.banknote_100 -= give_banknote_100;
                }
                else { Console.WriteLine("Error: not enought currency in ATM"); }
            }




        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Computer pc1 = new Computer("HAFF MAXIMA", 1000);
            pc1.DisplayFullInfo();
            Console.WriteLine();
            Computer pc2 = new Computer("HAFF MAXIMA ULTRA", 2000, new HDD("Western Digital", 1, "internal"), new RAM ("Hynix", 64) );
            pc2.DisplayFullInfo();
            Console.WriteLine();

            Console.WriteLine("Task 2:");
            ATM atm = new ATM();
            ATM atm2 = new ATM(500, 500, 500);
            atm2.ATM_Info();
            atm.OperationWithdraw(atm.GetBanknotesRequest(10, 20, 30));
            atm.ATM_Info();
            atm.AddBanknotes(100, 100, 100);
            atm.ATM_Info();

            Console.WriteLine("Task 3:");


        }
    }
}