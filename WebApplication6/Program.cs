using Microsoft.EntityFrameworkCore;
using WebApplication6.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var config = builder.Configuration;
builder.Services.AddDbContext<CarDbContext>(options =>
{
    options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.UseAuthorization();
app.Run();
