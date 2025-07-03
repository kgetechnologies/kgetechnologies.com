using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

// --- Configure CORS Services ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:7229") // Your frontend's origin
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });

    // You can also add more permissive policies for development:
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin() // Not recommended for production
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();
// No MapStaticAssets, just configure static files normally
app.UseStaticFiles();
// --- Enable CORS Middleware ---
// Apply the specific policy
app.UseCors("AllowSpecificOrigin");

// Or, for development, you might use the more permissive one (less secure for production):
// app.UseCors("AllowAllOrigins");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
