
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Azure.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CandidateDetailContext>(options =>
        options.UseSqlServer(builder.Configuration["ConnectionStrings:CandidateDetailContext"]));

builder.Services.AddMvc(option => option.EnableEndpointRouting = false);

WebApplication app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<CandidateDetailContext>();
    dbContext.Database.EnsureCreated();
}

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
