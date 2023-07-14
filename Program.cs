using Microsoft.EntityFrameworkCore;
//using sweapp.Data;
using sweapp.Models;
using Microsoft.Extensions.DependencyInjection;
using sweapp.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SweappContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sweappContext") ?? throw new InvalidOperationException("Connection string 'sweappContext' not found.")));


builder.Services.AddDatabaseDeveloperPageExceptionFilter();


builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SweappContext>();
/*
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<SweappContext>();
*/
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
