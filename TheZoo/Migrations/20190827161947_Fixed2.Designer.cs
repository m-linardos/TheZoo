﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheZoo.Models;

namespace TheZoo.Migrations
{
    [DbContext(typeof(TheZooDB))]
    [Migration("20190827161947_Fixed2")]
    partial class Fixed2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheZoo.Models.Cat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("HeathStatus");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<int>("age");

                    b.HasKey("Id");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("TheZoo.Models.PettingZoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("HeathStatus");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<int>("age");

                    b.Property<string>("temperament");

                    b.HasKey("Id");

                    b.ToTable("PettingZooAnimals");
                });

            modelBuilder.Entity("TheZoo.Models.WaterFowl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("HeathStatus");

                    b.Property<int>("MyProperty");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.Property<int>("age");

                    b.HasKey("Id");

                    b.ToTable("WaterFowlGroup");
                });
#pragma warning restore 612, 618
        }
    }
}
