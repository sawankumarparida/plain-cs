using Microsoft.EntityFrameworkCore;
using cs.Services;
using cs.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Adds MVC
builder.Services.AddRazorPages();

// 2. CREATE THE 'app' VARIABLE HERE
var app = builder.Build();

// --- 2. MIDDLEWARE PIPELINE SECTION ---
// ALWAYS PLACE ERROR HANDLING FIRST
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// 2️⃣ Register DbContext with connection string
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// 3️⃣ Register ProductService
builder.Services.AddScoped<IProductService, ProductService>();

app.UseStaticFiles();
app.MapRazorPages();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
