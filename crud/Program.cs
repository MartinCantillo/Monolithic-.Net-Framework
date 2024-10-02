using crud.Data;
using crud.Repositories;
using crud.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adding DataContext to the container
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";

// env variables
/*
connectionString = connectionString
    .Replace("${DB_HOST}", Environment.GetEnvironmentVariable("DB_HOST") ?? "mysql")
    .Replace("${DB_PORT}", Environment.GetEnvironmentVariable("DB_PORT") ?? "3306")
    .Replace("${DB_NAME}", Environment.GetEnvironmentVariable("DB_NAME") ?? "bdCrud")
    .Replace("${DB_USER}", Environment.GetEnvironmentVariable("DB_USER") ?? "root")
    .Replace("${DB_PASSWORD}", Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "bdm");
**/
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySQL(connectionString ?? ""));
// Adding Autor repository and service
builder.Services.AddScoped<IAutor, SAutor>();

var app = builder.Build();

builder.WebHost.UseUrls("http://0.0.0.0:80");

// Apply migrations at application startup
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.Migrate();
}

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
