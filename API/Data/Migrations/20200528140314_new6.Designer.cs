﻿// <auto-generated />
using System;
using Challenges.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Challenges.Migrations
{
    [DbContext(typeof(ChallengesContext))]
    [Migration("20200528140314_new6")]
    partial class new6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Challenges.Data.Entities.Addition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IntegerOne");

                    b.Property<int>("IntegerTwo");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.ToTable("Additions");
                });

            modelBuilder.Entity("Challenges.Data.Entities.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IntegerOne");

                    b.Property<int>("IntegerTwo");

                    b.Property<double>("Result");

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("Challenges.Data.Entities.Factorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Integer");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.ToTable("Factorials");
                });

            modelBuilder.Entity("Challenges.Data.Entities.Multiplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IntegerOne");

                    b.Property<int>("IntegerTwo");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.ToTable("Multiplications");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("InputtedCharacters");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("OutputtedCharacters");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingValuesForInput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("CharacterNumber");

                    b.Property<int?>("SortingInputId");

                    b.HasKey("Id");

                    b.HasIndex("SortingInputId");

                    b.ToTable("SortingValuesForInput");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingValuesForOutput", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("SortingOutputId");

                    b.HasKey("ID");

                    b.HasIndex("SortingOutputId");

                    b.ToTable("SortingValuesForOutput");
                });

            modelBuilder.Entity("Challenges.Data.Entities.StringInversion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Result");

                    b.Property<string>("String");

                    b.HasKey("Id");

                    b.ToTable("StringInversions");
                });

            modelBuilder.Entity("Challenges.Data.Entities.Subtraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IntegerOne");

                    b.Property<int>("IntegerTwo");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.ToTable("Subtractions");
                });

            modelBuilder.Entity("Challenges.Data.Entities.WhiteSpaceRemoval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Result");

                    b.Property<string>("String");

                    b.HasKey("Id");

                    b.ToTable("WhiteSpcaeRemovals");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingValuesForInput", b =>
                {
                    b.HasOne("Challenges.Data.Entities.SortingInput")
                        .WithMany("InputCharacterCollection")
                        .HasForeignKey("SortingInputId");
                });

            modelBuilder.Entity("Challenges.Data.Entities.SortingValuesForOutput", b =>
                {
                    b.HasOne("Challenges.Data.Entities.SortingOutput")
                        .WithMany("OutputCharacterCollection")
                        .HasForeignKey("SortingOutputId");
                });
#pragma warning restore 612, 618
        }
    }
}
