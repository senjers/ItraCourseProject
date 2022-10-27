var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "hello",
    pattern: "{controller=Home}/{action=Hello}/{id?}");


app.Run();
