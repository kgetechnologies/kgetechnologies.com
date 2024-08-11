var builder = WebApplication.CreateBuilder(args);

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
app.UseFileServer();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "contactus",
				pattern: "contactus",
				defaults: new { controller = "contactus", action = "Index" });

app.MapControllerRoute(name: "contactus1",
				pattern: "contactus/Index",
				defaults: new { controller = "contactus", action = "Index" });

app.MapControllerRoute(name: "Defaultc",
				pattern: "sitemap/{id}.xml",
				defaults: new { controller = "sitemap", action = "Index" });

app.MapControllerRoute(name: "Defaultb",
				pattern: "sitemap/{id}",
				defaults: new { controller = "sitemap", action = "Index" });

app.MapControllerRoute(name: "Defaulta",
                pattern: "{*id}",
                defaults: new { controller = "Home", action = "Index" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
