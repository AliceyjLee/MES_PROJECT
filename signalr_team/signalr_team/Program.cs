using signalr_team.ImgHub;
using signalr_team.IoTHub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// signalr µî·Ï
builder.Services.AddSignalR(
    options => options.MaximumReceiveMessageSize = 1024*1024*1024
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<IoTHub>("/iothub");
app.MapHub<ImgHub>("/imghub");

app.Run("http://0.0.0.0:5140");
