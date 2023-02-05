using System.Globalization;

namespace _05_Classes_Practice_14_12_2022
{
    //Создать класс CreditCard c полями номер счета, текущая сумма на счету.Добавьте метод, который позволяет начислять сумму на кредитную карточку.
    //Добавьте метод, который позволяет снимать с карточки некоторую сумму.Добавьте метод, который выводит текущую информацию о карточке. 
    //Тестовый сценарий для проверки: 
    //Положите деньги на первые две карточки и снимите с третьей. Выведите на экран текущее состояние всех трех карточек.
   
    internal class Program
    {
        public class CreditCard
        {
            public string bankAccount = "";
            decimal amount = 0;

            public void GetMoney(decimal amount)
            {
                this.amount -= amount;
                Console.WriteLine($"Withdrawal {amount} from the card number {this.bankAccount}");
            }

            public void GiveMoney(decimal amount)
            {
                this.amount += amount;
                Console.WriteLine($"Deposit {amount} into the card number {this.bankAccount}");
            }

            public void DisplayInfo()
            {
                // Setting up currency format
                CultureInfo usa = new CultureInfo("en-US");
                usa.NumberFormat.CurrencyPositivePattern = 3;
                usa.NumberFormat.CurrencyNegativePattern = 8;

                // Displaying information
                Console.WriteLine("Bank Account: {0}", this.bankAccount);
                Console.WriteLine("Available Amount: {0}", this.amount.ToString("C2", usa));
            }
        }


        static void Main(string[] args)
        {
            CreditCard mastercard = new CreditCard();
            CreditCard visa = new CreditCard();
            CreditCard visa_electron = new CreditCard();

            mastercard.bankAccount = "1111 1111 1111 1111";
            visa.bankAccount = "2222 2222 2222 2222";
            visa_electron.bankAccount = "3333 3333 3333 3333";

            mastercard.GiveMoney(100);
            visa.GiveMoney(500);
            visa_electron.GetMoney(1000);

            mastercard.DisplayInfo();
            visa.DisplayInfo();
            visa_electron.DisplayInfo();

        }



    }
}