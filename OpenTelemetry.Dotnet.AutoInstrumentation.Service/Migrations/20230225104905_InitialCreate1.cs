using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "WeatherForecasts",
                newName: "WeatherForecastHistory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecastHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 16, 19, 4, 924, DateTimeKind.Local).AddTicks(9944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "WeatherForecastHistory",
                newName: "WeatherForecasts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecasts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 16, 19, 4, 924, DateTimeKind.Local).AddTicks(9944));
        }
    }
}
