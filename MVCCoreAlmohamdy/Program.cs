using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCCoreAlmohamdy.Data;
using MVCCoreAlmohamdy.Repositry;
using MVCCoreAlmohamdy.Repositry.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyAppDbContext>(opition => opition.UseSqlServer(builder.Configuration.GetConnectionString("con")));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).
   AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<MyAppDbContext>();

//builder.Services.AddTransient(typeof(IRepositry<>), typeof(MainRepositry<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

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
app.UseAuthentication(); ;

app.UseAuthorization();

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints => endpoints.MapRazorPages());
app.Run();
