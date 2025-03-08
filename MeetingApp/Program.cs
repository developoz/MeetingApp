var builder = WebApplication.CreateBuilder(args);


//uygulamaya mvc şablonu ile çalışacağımızı söylüyoruz.
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();


// {controller=Home}/{action=Index}/id?
//app.MapDefaultControllerRoute(); bunun yerine aşağıda manuel olarak da route ayarlarını yapabiliriz.



app.MapControllerRoute(
    name:"default",
    pattern: "{controller=Home}/{action=Index}/{id?}"

);

app.Run();
