var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


// Default Route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Restaurant}/{action=Menu}/{id?}");


// Custom SEO Friendly Route
app.MapControllerRoute(
    name: "foodorder",
    pattern: "order-food",
    defaults: new { controller = "Order", action = "PlaceOrder" });


// Route Constraint Example
app.MapControllerRoute(
    name: "restaurantdetails",
    pattern: "restaurant/{id:int}",
    defaults: new { controller = "Restaurant", action = "Details" });

app.Run();
