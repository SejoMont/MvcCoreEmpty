var builder = WebApplication.CreateBuilder(args);

//a�adir los servicios de vistas y controladores
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();
