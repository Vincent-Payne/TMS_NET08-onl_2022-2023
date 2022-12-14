using System.Security.Cryptography.X509Certificates;

namespace _04_14._12._2022_Practise
{
//Создать класс CreditCard c полями номер счета, текущая сумма на счету.Добавьте метод, который позволяет начислять сумму на кредитную карточку.
//Добавьте метод, который позволяет снимать с карточки некоторую сумму.Добавьте метод, который выводит текущую информацию о карточке. 
//Тестовый сценарий для проверки: 
//Положите деньги на первые две карточки и снимите с третьей. Выведите на экран текущее состояние всех трех карточек.

    internal class Program
    {

        static void Main(string[] args)
        {
            CreditCard mastercard = new CreditCard();
            CreditCard visa = new CreditCard();
            CreditCard visa_electron = new CreditCard();
            mastercard.bankAccount = "1111 1111 1111 1111";
            visa.bankAccount = "2222 2222 2222 2222";
            visa_electron.bankAccount = "3333 3333 3333 3333";

            mastercard.GiveMoney(5000);
            visa.GiveMoney(10000);
            visa_electron.GiveMoney(999999);

            mastercard.DisplayInfo();
            mastercard.GetMoney(500);
            mastercard.DisplayInfo();
            
        }
        public class CreditCard
        {
            public string bankAccount = "";
            double amount = 0;

            public void GetMoney(double amount)
            {
                this.amount -= amount;
            }

            public void GiveMoney(double amount)
            {
                this.amount += amount;
            }

            public void DisplayInfo() 
            {
                Console.WriteLine("Bank Account: {0}", this.bankAccount);
                Console.WriteLine("Available Amount: {0}", this.amount);
            }
        }


    }

}