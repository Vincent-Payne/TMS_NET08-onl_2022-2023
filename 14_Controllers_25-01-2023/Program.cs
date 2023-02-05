namespace _14_Controllers_25_01_2023
{
/*Разработать Web-приложение предоставляющее следующий функционал
1)Вывести информацию с предыдущего задания
2)Вывести объект контроллера в формате JSON
3)Вывести страницу содержащую переданную в метод параметры(использовать любой из возможных способов передачи параметров на представление)
Для реализации приведенного функционала разработать собственный контроллер и представление
Для каждого из заданий предусмотреть ссылку на главной страницы приложения(по аналогии со ссылками Home, Privacy в дефолтном проекте)
Для 3-го задания разработать в контроллере метод, принимающий минимум 3 параметра различных типов*/
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}