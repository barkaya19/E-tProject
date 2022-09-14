using GknProject.Core.Models;
using GknProject.Repository;
using GknProject.Service.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using GknProject.Core.Repositories;
using GknProject.Repository.Repositories;
using GknProject.Core.Service;
using GknProject.Service.Services;
using Autofac.Extensions.DependencyInjection;
using Autofac;
using GknProject.UI.Modules;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddDbContext<GknKargoErpContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
     {
         option.MigrationsAssembly(Assembly.GetAssembly(typeof(GknKargoErpContext)).GetName().Name);
     });

  
});
builder.Services.AddDbContext<GknKargoErpUserContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("UserConnection"));

});



builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));
//builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
var app = builder.Build();

//builder.Services.AddHttpContextAccessor();



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
