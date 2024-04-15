namespace RoutingWithoutMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapDefaultControllerRoute();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id?}"
                );

            //app.MapGet("/", () => "Hello World!");



            app.Run();
        }
    }
}
