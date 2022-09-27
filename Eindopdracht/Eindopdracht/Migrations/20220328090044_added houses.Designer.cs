﻿// <auto-generated />
using System;
using Eindopdracht.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eindopdracht.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220328090044_added houses")]
    partial class addedhouses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eindopdracht.Model.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BathroomTotal")
                        .HasColumnType("int");

                    b.Property<int>("BedTotal")
                        .HasColumnType("int");

                    b.Property<int>("BedroomTotal")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseType")
                        .HasColumnType("int");

                    b.Property<int?>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("MaxPerson")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<bool>("SmokingAllowed")
                        .HasColumnType("bit");

                    b.Property<string>("Streetname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Eindopdracht.Model.Landlord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Landlords");
                });

            modelBuilder.Entity("Eindopdracht.Model.House", b =>
                {
                    b.HasOne("Eindopdracht.Model.Landlord", "Landlord")
                        .WithMany()
                        .HasForeignKey("LandlordId");

                    b.Navigation("Landlord");
                });
#pragma warning restore 612, 618
        }
    }
}