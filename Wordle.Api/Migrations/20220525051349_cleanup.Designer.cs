﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wordle.Api.Data;

#nullable disable

namespace Wordle.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220525051349_cleanup")]
    partial class cleanup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Wordle.Api.Data.DateWord", b =>
                {
                    b.Property<int>("DateWordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DateWordId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("DateWordId");

                    b.HasIndex("WordId");

                    b.ToTable("DateWords");
                });

            modelBuilder.Entity("Wordle.Api.Data.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"), 1L, 1);

                    b.Property<DateTime?>("DateEnded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameType")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<string>("Word")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Wordle.Api.Data.Guess", b =>
                {
                    b.Property<int>("GuessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuessId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuessId");

                    b.HasIndex("GameId");

                    b.ToTable("Guess");
                });

            modelBuilder.Entity("Wordle.Api.Data.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"), 1L, 1);

                    b.Property<double>("AverageAttempts")
                        .HasColumnType("float");

                    b.Property<int>("AverageSecondsPerGame")
                        .HasColumnType("int");

                    b.Property<int>("GameCount")
                        .HasColumnType("int");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Wordle.Api.Data.ScoreStat", b =>
                {
                    b.Property<int>("ScoreStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreStatId"), 1L, 1);

                    b.Property<int>("AverageSeconds")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int>("TotalGames")
                        .HasColumnType("int");

                    b.HasKey("ScoreStatId");

                    b.ToTable("ScoreStats");

                    b.HasData(
                        new
                        {
                            ScoreStatId = 1,
                            AverageSeconds = 0,
                            Score = 1,
                            TotalGames = 0
                        },
                        new
                        {
                            ScoreStatId = 2,
                            AverageSeconds = 0,
                            Score = 2,
                            TotalGames = 0
                        },
                        new
                        {
                            ScoreStatId = 3,
                            AverageSeconds = 0,
                            Score = 3,
                            TotalGames = 0
                        },
                        new
                        {
                            ScoreStatId = 4,
                            AverageSeconds = 0,
                            Score = 4,
                            TotalGames = 0
                        },
                        new
                        {
                            ScoreStatId = 5,
                            AverageSeconds = 0,
                            Score = 5,
                            TotalGames = 0
                        },
                        new
                        {
                            ScoreStatId = 6,
                            AverageSeconds = 0,
                            Score = 6,
                            TotalGames = 0
                        });
                });

            modelBuilder.Entity("Wordle.Api.Data.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SettingId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Wordle.Api.Data.Word", b =>
                {
                    b.Property<int>("WordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WordId"), 1L, 1);

                    b.Property<bool>("Common")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Wordle.Api.Data.DateWord", b =>
                {
                    b.HasOne("Wordle.Api.Data.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Wordle.Api.Data.Game", b =>
                {
                    b.HasOne("Wordle.Api.Data.Player", "Player")
                        .WithMany("Games")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Wordle.Api.Data.Guess", b =>
                {
                    b.HasOne("Wordle.Api.Data.Game", "Game")
                        .WithMany("Guesses")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Wordle.Api.Data.Game", b =>
                {
                    b.Navigation("Guesses");
                });

            modelBuilder.Entity("Wordle.Api.Data.Player", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
