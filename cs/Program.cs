var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Adds MVC
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
