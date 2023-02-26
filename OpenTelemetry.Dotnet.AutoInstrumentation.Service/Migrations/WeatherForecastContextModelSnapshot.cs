﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace OpenTelemetry.Dotnet.AutoInstrumentation.Service.Migrations
{
    [DbContext(typeof(WeatherForecastContext))]
    partial class WeatherForecastContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OpenTelemetry.Dotnet.AutoInstrumentation.Service.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 0L);

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 2, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2447));

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecastHistory", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 2, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2941),
                            Summary = "Cool",
                            TemperatureC = -16
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 2, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2962),
                            Summary = "Mild",
                            TemperatureC = 23
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 2, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2965),
                            Summary = "Warm",
                            TemperatureC = -14
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 3, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2966),
                            Summary = "Balmy",
                            TemperatureC = 26
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2023, 3, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2968),
                            Summary = "Cool",
                            TemperatureC = -12
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2023, 3, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2971),
                            Summary = "Freezing",
                            TemperatureC = -8
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2023, 3, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2973),
                            Summary = "Bracing",
                            TemperatureC = 44
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2023, 3, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2975),
                            Summary = "Hot",
                            TemperatureC = -2
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2023, 3, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2976),
                            Summary = "Chilly",
                            TemperatureC = 15
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2023, 3, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2979),
                            Summary = "Bracing",
                            TemperatureC = 48
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2023, 3, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2980),
                            Summary = "Sweltering",
                            TemperatureC = 12
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2023, 3, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2982),
                            Summary = "Scorching",
                            TemperatureC = -1
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2023, 3, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2983),
                            Summary = "Chilly",
                            TemperatureC = -20
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2023, 3, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2984),
                            Summary = "Balmy",
                            TemperatureC = 39
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2023, 3, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2986),
                            Summary = "Cool",
                            TemperatureC = 46
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2023, 3, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2987),
                            Summary = "Bracing",
                            TemperatureC = -10
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2023, 3, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2988),
                            Summary = "Sweltering",
                            TemperatureC = 38
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2023, 3, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2991),
                            Summary = "Cool",
                            TemperatureC = 17
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2023, 3, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2992),
                            Summary = "Balmy",
                            TemperatureC = -20
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2023, 3, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2994),
                            Summary = "Balmy",
                            TemperatureC = 20
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2023, 3, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2995),
                            Summary = "Balmy",
                            TemperatureC = 22
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2023, 3, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2997),
                            Summary = "Chilly",
                            TemperatureC = -6
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2023, 3, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(2998),
                            Summary = "Hot",
                            TemperatureC = 10
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2023, 3, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3000),
                            Summary = "Freezing",
                            TemperatureC = 39
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2023, 3, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3001),
                            Summary = "Scorching",
                            TemperatureC = 2
                        },
                        new
                        {
                            Id = 26,
                            Date = new DateTime(2023, 3, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3003),
                            Summary = "Bracing",
                            TemperatureC = 14
                        },
                        new
                        {
                            Id = 27,
                            Date = new DateTime(2023, 3, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3004),
                            Summary = "Scorching",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = 28,
                            Date = new DateTime(2023, 3, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3006),
                            Summary = "Hot",
                            TemperatureC = 48
                        },
                        new
                        {
                            Id = 29,
                            Date = new DateTime(2023, 3, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3007),
                            Summary = "Hot",
                            TemperatureC = -13
                        },
                        new
                        {
                            Id = 30,
                            Date = new DateTime(2023, 3, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3009),
                            Summary = "Bracing",
                            TemperatureC = -12
                        },
                        new
                        {
                            Id = 31,
                            Date = new DateTime(2023, 3, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3010),
                            Summary = "Cool",
                            TemperatureC = 19
                        },
                        new
                        {
                            Id = 32,
                            Date = new DateTime(2023, 3, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3011),
                            Summary = "Mild",
                            TemperatureC = -9
                        },
                        new
                        {
                            Id = 33,
                            Date = new DateTime(2023, 3, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3013),
                            Summary = "Cool",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 34,
                            Date = new DateTime(2023, 3, 31, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3015),
                            Summary = "Mild",
                            TemperatureC = 1
                        },
                        new
                        {
                            Id = 35,
                            Date = new DateTime(2023, 4, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3017),
                            Summary = "Cool",
                            TemperatureC = -2
                        },
                        new
                        {
                            Id = 36,
                            Date = new DateTime(2023, 4, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3018),
                            Summary = "Cool",
                            TemperatureC = 14
                        },
                        new
                        {
                            Id = 37,
                            Date = new DateTime(2023, 4, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3020),
                            Summary = "Freezing",
                            TemperatureC = 4
                        },
                        new
                        {
                            Id = 38,
                            Date = new DateTime(2023, 4, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3021),
                            Summary = "Bracing",
                            TemperatureC = 8
                        },
                        new
                        {
                            Id = 39,
                            Date = new DateTime(2023, 4, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3022),
                            Summary = "Freezing",
                            TemperatureC = -19
                        },
                        new
                        {
                            Id = 40,
                            Date = new DateTime(2023, 4, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3024),
                            Summary = "Chilly",
                            TemperatureC = -16
                        },
                        new
                        {
                            Id = 41,
                            Date = new DateTime(2023, 4, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3025),
                            Summary = "Bracing",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 42,
                            Date = new DateTime(2023, 4, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3026),
                            Summary = "Freezing",
                            TemperatureC = 10
                        },
                        new
                        {
                            Id = 43,
                            Date = new DateTime(2023, 4, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3027),
                            Summary = "Freezing",
                            TemperatureC = 23
                        },
                        new
                        {
                            Id = 44,
                            Date = new DateTime(2023, 4, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3029),
                            Summary = "Warm",
                            TemperatureC = 24
                        },
                        new
                        {
                            Id = 45,
                            Date = new DateTime(2023, 4, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3030),
                            Summary = "Scorching",
                            TemperatureC = 28
                        },
                        new
                        {
                            Id = 46,
                            Date = new DateTime(2023, 4, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3032),
                            Summary = "Bracing",
                            TemperatureC = -19
                        },
                        new
                        {
                            Id = 47,
                            Date = new DateTime(2023, 4, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3033),
                            Summary = "Balmy",
                            TemperatureC = -15
                        },
                        new
                        {
                            Id = 48,
                            Date = new DateTime(2023, 4, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3035),
                            Summary = "Mild",
                            TemperatureC = 54
                        },
                        new
                        {
                            Id = 49,
                            Date = new DateTime(2023, 4, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3036),
                            Summary = "Bracing",
                            TemperatureC = 27
                        },
                        new
                        {
                            Id = 50,
                            Date = new DateTime(2023, 4, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3037),
                            Summary = "Freezing",
                            TemperatureC = 1
                        },
                        new
                        {
                            Id = 51,
                            Date = new DateTime(2023, 4, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3039),
                            Summary = "Balmy",
                            TemperatureC = 1
                        },
                        new
                        {
                            Id = 52,
                            Date = new DateTime(2023, 4, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3040),
                            Summary = "Freezing",
                            TemperatureC = 22
                        },
                        new
                        {
                            Id = 53,
                            Date = new DateTime(2023, 4, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3042),
                            Summary = "Mild",
                            TemperatureC = 5
                        },
                        new
                        {
                            Id = 54,
                            Date = new DateTime(2023, 4, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3043),
                            Summary = "Chilly",
                            TemperatureC = -2
                        },
                        new
                        {
                            Id = 55,
                            Date = new DateTime(2023, 4, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3044),
                            Summary = "Mild",
                            TemperatureC = -19
                        },
                        new
                        {
                            Id = 56,
                            Date = new DateTime(2023, 4, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3045),
                            Summary = "Sweltering",
                            TemperatureC = -11
                        },
                        new
                        {
                            Id = 57,
                            Date = new DateTime(2023, 4, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3047),
                            Summary = "Hot",
                            TemperatureC = 43
                        },
                        new
                        {
                            Id = 58,
                            Date = new DateTime(2023, 4, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3048),
                            Summary = "Bracing",
                            TemperatureC = 11
                        },
                        new
                        {
                            Id = 59,
                            Date = new DateTime(2023, 4, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3050),
                            Summary = "Warm",
                            TemperatureC = 43
                        },
                        new
                        {
                            Id = 60,
                            Date = new DateTime(2023, 4, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3051),
                            Summary = "Cool",
                            TemperatureC = 47
                        },
                        new
                        {
                            Id = 61,
                            Date = new DateTime(2023, 4, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3052),
                            Summary = "Chilly",
                            TemperatureC = 13
                        },
                        new
                        {
                            Id = 62,
                            Date = new DateTime(2023, 4, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3054),
                            Summary = "Scorching",
                            TemperatureC = 17
                        },
                        new
                        {
                            Id = 63,
                            Date = new DateTime(2023, 4, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3055),
                            Summary = "Chilly",
                            TemperatureC = 16
                        },
                        new
                        {
                            Id = 64,
                            Date = new DateTime(2023, 4, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3056),
                            Summary = "Cool",
                            TemperatureC = 23
                        },
                        new
                        {
                            Id = 65,
                            Date = new DateTime(2023, 5, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3058),
                            Summary = "Freezing",
                            TemperatureC = 24
                        },
                        new
                        {
                            Id = 66,
                            Date = new DateTime(2023, 5, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3205),
                            Summary = "Bracing",
                            TemperatureC = 26
                        },
                        new
                        {
                            Id = 67,
                            Date = new DateTime(2023, 5, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3208),
                            Summary = "Bracing",
                            TemperatureC = 3
                        },
                        new
                        {
                            Id = 68,
                            Date = new DateTime(2023, 5, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3209),
                            Summary = "Chilly",
                            TemperatureC = 33
                        },
                        new
                        {
                            Id = 69,
                            Date = new DateTime(2023, 5, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3211),
                            Summary = "Chilly",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = 70,
                            Date = new DateTime(2023, 5, 6, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3212),
                            Summary = "Balmy",
                            TemperatureC = 25
                        },
                        new
                        {
                            Id = 71,
                            Date = new DateTime(2023, 5, 7, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3214),
                            Summary = "Scorching",
                            TemperatureC = -20
                        },
                        new
                        {
                            Id = 72,
                            Date = new DateTime(2023, 5, 8, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3215),
                            Summary = "Sweltering",
                            TemperatureC = 18
                        },
                        new
                        {
                            Id = 73,
                            Date = new DateTime(2023, 5, 9, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3217),
                            Summary = "Cool",
                            TemperatureC = 18
                        },
                        new
                        {
                            Id = 74,
                            Date = new DateTime(2023, 5, 10, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3218),
                            Summary = "Warm",
                            TemperatureC = 46
                        },
                        new
                        {
                            Id = 75,
                            Date = new DateTime(2023, 5, 11, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3220),
                            Summary = "Mild",
                            TemperatureC = -16
                        },
                        new
                        {
                            Id = 76,
                            Date = new DateTime(2023, 5, 12, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3221),
                            Summary = "Hot",
                            TemperatureC = -9
                        },
                        new
                        {
                            Id = 77,
                            Date = new DateTime(2023, 5, 13, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3223),
                            Summary = "Sweltering",
                            TemperatureC = 49
                        },
                        new
                        {
                            Id = 78,
                            Date = new DateTime(2023, 5, 14, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3224),
                            Summary = "Freezing",
                            TemperatureC = 7
                        },
                        new
                        {
                            Id = 79,
                            Date = new DateTime(2023, 5, 15, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3226),
                            Summary = "Cool",
                            TemperatureC = -9
                        },
                        new
                        {
                            Id = 80,
                            Date = new DateTime(2023, 5, 16, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3227),
                            Summary = "Sweltering",
                            TemperatureC = -13
                        },
                        new
                        {
                            Id = 81,
                            Date = new DateTime(2023, 5, 17, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3229),
                            Summary = "Sweltering",
                            TemperatureC = 43
                        },
                        new
                        {
                            Id = 82,
                            Date = new DateTime(2023, 5, 18, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3230),
                            Summary = "Mild",
                            TemperatureC = 15
                        },
                        new
                        {
                            Id = 83,
                            Date = new DateTime(2023, 5, 19, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3231),
                            Summary = "Scorching",
                            TemperatureC = -7
                        },
                        new
                        {
                            Id = 84,
                            Date = new DateTime(2023, 5, 20, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3233),
                            Summary = "Bracing",
                            TemperatureC = 33
                        },
                        new
                        {
                            Id = 85,
                            Date = new DateTime(2023, 5, 21, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3234),
                            Summary = "Bracing",
                            TemperatureC = -10
                        },
                        new
                        {
                            Id = 86,
                            Date = new DateTime(2023, 5, 22, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3235),
                            Summary = "Mild",
                            TemperatureC = -11
                        },
                        new
                        {
                            Id = 87,
                            Date = new DateTime(2023, 5, 23, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3237),
                            Summary = "Warm",
                            TemperatureC = 40
                        },
                        new
                        {
                            Id = 88,
                            Date = new DateTime(2023, 5, 24, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3238),
                            Summary = "Chilly",
                            TemperatureC = 32
                        },
                        new
                        {
                            Id = 89,
                            Date = new DateTime(2023, 5, 25, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3240),
                            Summary = "Scorching",
                            TemperatureC = 36
                        },
                        new
                        {
                            Id = 90,
                            Date = new DateTime(2023, 5, 26, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3241),
                            Summary = "Cool",
                            TemperatureC = 0
                        },
                        new
                        {
                            Id = 91,
                            Date = new DateTime(2023, 5, 27, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3243),
                            Summary = "Balmy",
                            TemperatureC = -17
                        },
                        new
                        {
                            Id = 92,
                            Date = new DateTime(2023, 5, 28, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3244),
                            Summary = "Warm",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = 93,
                            Date = new DateTime(2023, 5, 29, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3246),
                            Summary = "Hot",
                            TemperatureC = 34
                        },
                        new
                        {
                            Id = 94,
                            Date = new DateTime(2023, 5, 30, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3248),
                            Summary = "Hot",
                            TemperatureC = 2
                        },
                        new
                        {
                            Id = 95,
                            Date = new DateTime(2023, 5, 31, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3249),
                            Summary = "Hot",
                            TemperatureC = 15
                        },
                        new
                        {
                            Id = 96,
                            Date = new DateTime(2023, 6, 1, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3251),
                            Summary = "Warm",
                            TemperatureC = 18
                        },
                        new
                        {
                            Id = 97,
                            Date = new DateTime(2023, 6, 2, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3252),
                            Summary = "Sweltering",
                            TemperatureC = 32
                        },
                        new
                        {
                            Id = 98,
                            Date = new DateTime(2023, 6, 3, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3253),
                            Summary = "Hot",
                            TemperatureC = 37
                        },
                        new
                        {
                            Id = 99,
                            Date = new DateTime(2023, 6, 4, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3255),
                            Summary = "Cool",
                            TemperatureC = -5
                        },
                        new
                        {
                            Id = 100,
                            Date = new DateTime(2023, 6, 5, 16, 33, 28, 2, DateTimeKind.Local).AddTicks(3257),
                            Summary = "Chilly",
                            TemperatureC = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
