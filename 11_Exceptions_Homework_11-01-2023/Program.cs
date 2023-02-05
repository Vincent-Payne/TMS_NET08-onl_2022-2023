using System.Runtime.CompilerServices;

namespace _11_Exceptions_Homework_09_01_2022
{
    internal class Program
    {
        /*
        Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра: - Login - Password - ConfirmPassword 
        Все поля имеют тип данных String. Длина Login должна быть меньше 20 символов и не должен содержать пробелы. Если Login не соответствует этим требованиям,
        необходимо выбросить WrongLoginException. Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру. 
        Также Password и ConfirmPassword должны быть равны. Если Password не соответствует этим требованиям, необходимо выбросить WrongPasswordException. 
        WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию, 
        второй принимает сообщение исключения и передает его в конструктор класса Exception. Метод возвращает true, если значения верны или false в другом случае.*/
        public class WrongLoginException : Exception 
        {
            public WrongLoginException() : base("Login contains spaces or longer than 20 characters") { }
            public WrongLoginException(string warning_msg) : base(warning_msg) { }
        }

        public class WrongPasswordException : Exception
        {
            public WrongPasswordException() : base("Password must contain at least one digit, doesn't contain spaces and be shorter than 20 characters") { }
            public WrongPasswordException(string warning_msg) : base(warning_msg) { }
        }

        public class UserAuth
        {
            public string login, password, confirm_password;
            public void DataInput(string login, string password, string confirm_password)
            {
                this.login = login;
                this.password = password;
                this.confirm_password = confirm_password;
            }

        }

        public static void AuthChk(string login, string password, string confirm_password)
        {
            bool contains_digit = password.Any(char.IsDigit);
            if (login.Length > 20 || login.Contains(" ")) throw new WrongLoginException();
            if (password.Length > 20 || login.Contains(" ") || password != confirm_password) throw new WrongPasswordException();
            if (!contains_digit) throw new WrongPasswordException();
        }
        static void Main(string[] args)
        {
            UserAuth user1 = new UserAuth();
            UserAuth user2 = new UserAuth();
            UserAuth user3 = new UserAuth();

            user1.DataInput("DR Zoidberg", "12345pass", "12345pass");
            user2.DataInput("GabeN", "HalfLife_3_is_not_real", "HalfLife ");
            user3.DataInput("McDonald", "KFCMustDie123", "KFCMustDie123");
            try
            {
                AuthChk(user1.login, user1.password, user1.confirm_password);
                //AuthChk(user2.login, user2.password, user2.confirm_password);
                //AuthChk(user3.login, user3.password, user3.confirm_password);

            }

            catch (Exception warning_msg) { Console.WriteLine(warning_msg.Message); }
        }
    }
}
