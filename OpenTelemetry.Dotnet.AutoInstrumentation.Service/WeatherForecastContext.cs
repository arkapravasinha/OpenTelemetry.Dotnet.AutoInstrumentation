using Microsoft.EntityFrameworkCore;
using OpenTelemetry.Dotnet.AutoInstrumentation.Service;

public class WeatherForecastContext : DbContext
{
    public WeatherForecastContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new WeatherForecastConfiguration());
    }
}