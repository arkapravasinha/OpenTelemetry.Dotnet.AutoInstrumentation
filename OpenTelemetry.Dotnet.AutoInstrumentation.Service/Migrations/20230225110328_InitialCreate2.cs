using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Service.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecastHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 16, 19, 4, 924, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WeatherForecastHistory",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "0, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeatherForecastHistory",
                table: "WeatherForecastHistory",
                column: "Id");

            migrationBuilder.InsertData(
                table: "WeatherForecastHistory",
                columns: new[] { "Id", "Date", "Summary", "TemperatureC" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2941), "Cool", -16 },
                    { 2, new DateTime(2023, 2, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2962), "Mild", 23 },
                    { 3, new DateTime(2023, 2, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2965), "Warm", -14 },
                    { 4, new DateTime(2023, 3, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2966), "Balmy", 26 },
                    { 5, new DateTime(2023, 3, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2968), "Cool", -12 },
                    { 6, new DateTime(2023, 3, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2971), "Freezing", -8 },
                    { 7, new DateTime(2023, 3, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2973), "Bracing", 44 },
                    { 8, new DateTime(2023, 3, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2975), "Hot", -2 },
                    { 9, new DateTime(2023, 3, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2976), "Chilly", 15 },
                    { 10, new DateTime(2023, 3, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2979), "Bracing", 48 },
                    { 11, new DateTime(2023, 3, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2980), "Sweltering", 12 },
                    { 12, new DateTime(2023, 3, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2982), "Scorching", -1 },
                    { 13, new DateTime(2023, 3, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2983), "Chilly", -20 },
                    { 14, new DateTime(2023, 3, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2984), "Balmy", 39 },
                    { 15, new DateTime(2023, 3, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2986), "Cool", 46 },
                    { 16, new DateTime(2023, 3, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2987), "Bracing", -10 },
                    { 17, new DateTime(2023, 3, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2988), "Sweltering", 38 },
                    { 18, new DateTime(2023, 3, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2991), "Cool", 17 },
                    { 19, new DateTime(2023, 3, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2992), "Balmy", -20 },
                    { 20, new DateTime(2023, 3, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2994), "Balmy", 20 },
                    { 21, new DateTime(2023, 3, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2995), "Balmy", 22 },
                    { 22, new DateTime(2023, 3, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2997), "Chilly", -6 },
                    { 23, new DateTime(2023, 3, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2998), "Hot", 10 },
                    { 24, new DateTime(2023, 3, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3000), "Freezing", 39 },
                    { 25, new DateTime(2023, 3, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3001), "Scorching", 2 },
                    { 26, new DateTime(2023, 3, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3003), "Bracing", 14 },
                    { 27, new DateTime(2023, 3, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3004), "Scorching", 34 },
                    { 28, new DateTime(2023, 3, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3006), "Hot", 48 },
                    { 29, new DateTime(2023, 3, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3007), "Hot", -13 },
                    { 30, new DateTime(2023, 3, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3009), "Bracing", -12 },
                    { 31, new DateTime(2023, 3, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3010), "Cool", 19 },
                    { 32, new DateTime(2023, 3, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3011), "Mild", -9 },
                    { 33, new DateTime(2023, 3, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3013), "Cool", 16 },
                    { 34, new DateTime(2023, 3, 31, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3015), "Mild", 1 },
                    { 35, new DateTime(2023, 4, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3017), "Cool", -2 },
                    { 36, new DateTime(2023, 4, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3018), "Cool", 14 },
                    { 37, new DateTime(2023, 4, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3020), "Freezing", 4 },
                    { 38, new DateTime(2023, 4, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3021), "Bracing", 8 },
                    { 39, new DateTime(2023, 4, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3022), "Freezing", -19 },
                    { 40, new DateTime(2023, 4, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3024), "Chilly", -16 },
                    { 41, new DateTime(2023, 4, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3025), "Bracing", 16 },
                    { 42, new DateTime(2023, 4, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3026), "Freezing", 10 },
                    { 43, new DateTime(2023, 4, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3027), "Freezing", 23 },
                    { 44, new DateTime(2023, 4, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3029), "Warm", 24 },
                    { 45, new DateTime(2023, 4, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3030), "Scorching", 28 },
                    { 46, new DateTime(2023, 4, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3032), "Bracing", -19 },
                    { 47, new DateTime(2023, 4, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3033), "Balmy", -15 },
                    { 48, new DateTime(2023, 4, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3035), "Mild", 54 },
                    { 49, new DateTime(2023, 4, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3036), "Bracing", 27 },
                    { 50, new DateTime(2023, 4, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3037), "Freezing", 1 },
                    { 51, new DateTime(2023, 4, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3039), "Balmy", 1 },
                    { 52, new DateTime(2023, 4, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3040), "Freezing", 22 },
                    { 53, new DateTime(2023, 4, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3042), "Mild", 5 },
                    { 54, new DateTime(2023, 4, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3043), "Chilly", -2 },
                    { 55, new DateTime(2023, 4, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3044), "Mild", -19 },
                    { 56, new DateTime(2023, 4, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3045), "Sweltering", -11 },
                    { 57, new DateTime(2023, 4, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3047), "Hot", 43 },
                    { 58, new DateTime(2023, 4, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3048), "Bracing", 11 },
                    { 59, new DateTime(2023, 4, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3050), "Warm", 43 },
                    { 60, new DateTime(2023, 4, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3051), "Cool", 47 },
                    { 61, new DateTime(2023, 4, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3052), "Chilly", 13 },
                    { 62, new DateTime(2023, 4, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3054), "Scorching", 17 },
                    { 63, new DateTime(2023, 4, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3055), "Chilly", 16 },
                    { 64, new DateTime(2023, 4, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3056), "Cool", 23 },
                    { 65, new DateTime(2023, 5, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3058), "Freezing", 24 },
                    { 66, new DateTime(2023, 5, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3205), "Bracing", 26 },
                    { 67, new DateTime(2023, 5, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3208), "Bracing", 3 },
                    { 68, new DateTime(2023, 5, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3209), "Chilly", 33 },
                    { 69, new DateTime(2023, 5, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3211), "Chilly", 34 },
                    { 70, new DateTime(2023, 5, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3212), "Balmy", 25 },
                    { 71, new DateTime(2023, 5, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3214), "Scorching", -20 },
                    { 72, new DateTime(2023, 5, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3215), "Sweltering", 18 },
                    { 73, new DateTime(2023, 5, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3217), "Cool", 18 },
                    { 74, new DateTime(2023, 5, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3218), "Warm", 46 },
                    { 75, new DateTime(2023, 5, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3220), "Mild", -16 },
                    { 76, new DateTime(2023, 5, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3221), "Hot", -9 },
                    { 77, new DateTime(2023, 5, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3223), "Sweltering", 49 },
                    { 78, new DateTime(2023, 5, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3224), "Freezing", 7 },
                    { 79, new DateTime(2023, 5, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3226), "Cool", -9 },
                    { 80, new DateTime(2023, 5, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3227), "Sweltering", -13 },
                    { 81, new DateTime(2023, 5, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3229), "Sweltering", 43 },
                    { 82, new DateTime(2023, 5, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3230), "Mild", 15 },
                    { 83, new DateTime(2023, 5, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3231), "Scorching", -7 },
                    { 84, new DateTime(2023, 5, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3233), "Bracing", 33 },
                    { 85, new DateTime(2023, 5, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3234), "Bracing", -10 },
                    { 86, new DateTime(2023, 5, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3235), "Mild", -11 },
                    { 87, new DateTime(2023, 5, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3237), "Warm", 40 },
                    { 88, new DateTime(2023, 5, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3238), "Chilly", 32 },
                    { 89, new DateTime(2023, 5, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3240), "Scorching", 36 },
                    { 90, new DateTime(2023, 5, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3241), "Cool", 0 },
                    { 91, new DateTime(2023, 5, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3243), "Balmy", -17 },
                    { 92, new DateTime(2023, 5, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3244), "Warm", 34 },
                    { 93, new DateTime(2023, 5, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3246), "Hot", 34 },
                    { 94, new DateTime(2023, 5, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3248), "Hot", 2 },
                    { 95, new DateTime(2023, 5, 31, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3249), "Hot", 15 },
                    { 96, new DateTime(2023, 6, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3251), "Warm", 18 },
                    { 97, new DateTime(2023, 6, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3252), "Sweltering", 32 },
                    { 98, new DateTime(2023, 6, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3253), "Hot", 37 },
                    { 99, new DateTime(2023, 6, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3255), "Cool", -5 },
                    { 100, new DateTime(2023, 6, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3257), "Chilly", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeatherForecastHistory",
                table: "WeatherForecastHistory");

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "WeatherForecastHistory",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 100);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WeatherForecastHistory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecastHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 16, 19, 4, 924, DateTimeKind.Local).AddTicks(9944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2447));
        }
    }
}
