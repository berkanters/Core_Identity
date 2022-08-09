using CoreIdentity102.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/*1*/
builder.Services.AddDbContext<AppIdentityDbContex>(options =>//Scopesuz yazýmý
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConStr")));

builder.Services.AddIdentity<AppUser, AppRole>(opts =>
    {
        opts.Password.RequireDigit = false;
        opts.Password.RequireLowercase = false;
        opts.Password.RequireUppercase = false;
        opts.Password.RequireNonAlphanumeric = false;
        opts.Password.RequiredLength = 4;

    }
).AddEntityFrameworkStores<AppIdentityDbContex>();
builder.Services.AddControllersWithViews();
//Bu proje çalýþtýðý sürece arkada gizli bir hafýz ile tutuluyor. Projenin her yerinde bunu her yerden çekebilirim.

var app = builder.Build();

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
app.UseAuthentication();//Oturuma Giriþ çýkýþ iþlemlerinin kontrol edilmesini istiyoruz bu yüzden yazýyoruz.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
