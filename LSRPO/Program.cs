using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Contracts.User;
using LSRPO.Core.Services;
using LSRPO.Core.Services.User;
using LSRPO.Infrastructure.Data;
using LSRPO.Infrastructure.Data.Models;
using LSRPO.Infrastructure.Data.Repositories;
using LSRPO.ModelBinders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<AUTH_USER, AUTH_ROLE>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddRoles<AUTH_ROLE>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
        options.ModelBinderProviders.Insert(1, new DateTimeModelBinderProvider(FormatingConstant.NormalDateFormat));
        options.ModelBinderProviders.Insert(2, new DoubleModelBinderProvider());
    });

builder.Services.AddScoped<IApplicatioDbRepository, ApplicatioDbRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<INotifyObjectService, NotifyObjectService>();
builder.Services.AddScoped<INotifyGroupService, NotifyGroupService>();
builder.Services.AddScoped<INotifyProcessService, NotifyProcessService>();
builder.Services.AddScoped<INotifyStatusService, NotifyStatusService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseDeveloperExceptionPage();
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
    name: "Area",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();