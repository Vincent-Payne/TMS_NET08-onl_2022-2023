namespace _13_ASP.NET_First_App_23_01_2023
{
    //На ASP.NET Core написать Web-приложение которое будет отображать на странице ваше имя фамилию, сегодняшнюю дату, 
    //окружение в котором запущено приложение, название приложения, хост и  используемый протокол в формате как на картинке
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Run(async (context) => 
            {
                var response = context.Response;
                await context.Response.WriteAsync($"Name: Pavel Dyachuk." +
                    $"\nCurrent Date and Time: {DateTime.Now}." +
                    $"\nYour Environment: {app.Environment.EnvironmentName}." +
                    $"\nApplication Name: {app.Environment.ApplicationName}." +
                    $"\nApplication Host: {context.Request.Host}." +
                    $"\nProtocol: {context.Request.Protocol}.");
            });

            app.Run();
        }
    }
}