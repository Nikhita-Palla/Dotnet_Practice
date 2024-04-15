namespace MiddleWares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.Use(async (context,next) =>
            {
                await context.Response.WriteAsync("Welcome to MyAPP\n");
                await next(context);  // pass the context to next middleware
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("By Palla Nikhita");
            });

            app.Run();
        }
    }
}
