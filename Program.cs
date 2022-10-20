using webapp_travel_agency.Models;

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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

TravelAgency context = new TravelAgency();

PacchettoViaggio package1 = new PacchettoViaggio();

package1.Title = "Package 1";
package1.Description = "Package 1";
package1.Image = "https://images.unsplash.com/photo-1519681393784-d120267933ba?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2250&q=80";
package1.Price = 99.9;

context.Packages.Add(package1);
context.SaveChanges();

PacchettoViaggio package2 = new PacchettoViaggio();

package2.Title = "Package 2";
package2.Description = "Package 2";
package2.Image = "https://images.unsplash.com/photo-1485160497022-3e09382fb310?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2250&q=80";
package2.Price = 99.9;

context.Packages.Add(package2);
context.SaveChanges();

PacchettoViaggio package3 = new PacchettoViaggio();

package3.Title = "Package 3";
package3.Description = "Package 3";
package3.Image = "https://images.unsplash.com/photo-1506318164473-2dfd3ede3623?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=3300&q";
package3.Price = 99.9;

context.Packages.Add(package3);
context.SaveChanges();
