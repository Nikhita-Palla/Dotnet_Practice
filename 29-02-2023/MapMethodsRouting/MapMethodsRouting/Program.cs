namespace MapMethodsRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/Home", async (context) =>
                {
                      await context.Response.WriteAsync("GET");
                });
                endpoints.MapPost("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("POST");
                });
                endpoints.MapPut("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("PUT");
                });
                endpoints.MapDelete("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("DELETE");
                });
            });

            app.Run();
        }
    }
}
