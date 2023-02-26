using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Service
{
    public class WeatherForecastConfiguration : IEntityTypeConfiguration<WeatherForecast>
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.ToTable("WeatherForecastHistory")
                .HasKey(wf=>wf.Id);

            builder.Property(wf => wf.Id)
                .UseIdentityColumn(seed: 0,increment: 1)
                .ValueGeneratedOnAdd();

            builder.Property(wf=>wf.Date)
                .HasDefaultValue(DateTime.Now);
            builder.Property(wf => wf.TemperatureC)
                .IsRequired();
            builder.Property(wf => wf.Summary);

            builder.HasData(Enumerable.Range(1, 100).Select(index => new WeatherForecast
            {
                Id = index,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })) ;
        }
    }
}
