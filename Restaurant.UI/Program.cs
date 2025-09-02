using Microsoft.EntityFrameworkCore;   
using Restaurant.DAL;
using Restaurant.DAL.Models;          
using Restaurant.UI.Components;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<RestaurantDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
