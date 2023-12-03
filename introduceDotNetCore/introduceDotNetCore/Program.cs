var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.UseWelcomePage();
/*
 * 1. Şişeyi doldur
 * 2. Kapağını kapat.
 * 3. Kasaya yerleştir.
 */

//app.MapGet("/", () => "Merhaba!");
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}");

app.Run();

//Conversion over Configuration
