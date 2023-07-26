using BlazorApp.Areas.Identity;
using BlazorApp.Data;
using DataAccessLibrary.Data;
using DataAccessLibrary.Data.APIs;
using DataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Environment.GetEnvironmentVariable("SyncfusionKey"));
var connectionString = builder.Configuration.GetConnectionString("SQLDB") ?? throw new InvalidOperationException("Connection string 'SQLDB' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
	options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddScoped<IStockDataService, StockDataService>();
builder.Services.AddScoped<ICustomerDataService, CustomerDataService>();
builder.Services.AddScoped<IApiCalls, MockApiCalls>();
builder.Services.AddScoped<IVehicleDataService, VehicleDataService>();
builder.Services.AddScoped<IAppointmentDataService, AppointmentDataService>();
builder.Services.AddScoped<ICustomerSessionData, CustomerSessionData>();
builder.Services.AddScoped<IMechanicSessionData, MechanicSessionData>();
builder.Services.AddScoped<IMechanicDataService, MechanicDataService>();
builder.Services.AddScoped<IReportDataService, ReportDataService>();
builder.Services.AddScoped<IMessageDataService, MessageDataService>();
builder.Services.AddScoped<IStatisticsDataService, StatisticsDataService>();
builder.Services.AddScoped<IManagerSessionData, ManagerSessionData>();
builder.Services.AddSyncfusionBlazor();

builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseMigrationsEndPoint();
}
else
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
