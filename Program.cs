using Microsoft.EntityFrameworkCore;
using E_Commerce_Outdoorways.Context;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the AppDbContext in the Dependency Injection (DI) container.
// ASP.NET Core uses DI to create and manage objects automatically for each request.
// In this case, we are telling the application:
//
// "Whenever someone needs AppDbContext, create an instance of it
//  using SQL Server as the database provider."

builder.Services.AddDbContext<AppDbContext>(options => 
{
    // Configure EF Core to use SQL Server
    // We load the connection string from appsettings.json:
    //
    //  "ConnectionStrings": {
    //      "SqlString": "Server=RICCARDO\\SQLEXPRESS;Database=OUTDOORWAYS;Trusted_Connection=True;"
    //  }
    //
    // builder.Configuration.GetConnectionString("SqlString")
    // extracts exactly that text.
    //
    // This is the string EF uses to connect to SQL Server.
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlString"));
});

// ADD SERVICE TO STORE DATA FOR THE SINGLE SESSION
builder.Services.AddSession();


var app = builder.Build();

// TELLS THE APP TO USE SESSION
app.UseSession();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
