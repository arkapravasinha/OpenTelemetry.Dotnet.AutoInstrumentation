using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<WeatherForecastContext>(options =>
{
    options.UseSqlServer(builder.Configuration["DB_CONNECTION"]);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

var dbContext = services.GetRequiredService<WeatherForecastContext>();
if (dbContext.Database.GetPendingMigrations().Any())
    dbContext.Database.Migrate();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


