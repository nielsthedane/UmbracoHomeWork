﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UmbracoClassLibary.Models;

namespace UmbracoHomework.Migrations
{
    [DbContext(typeof(PrizeDrawContext))]
    [Migration("20180827195809_addedBirthday")]
    partial class addedBirthday
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UmbracoClassLibary.Models.SerialNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("SerialNumbers");
                });

            modelBuilder.Entity("UmbracoClassLibary.Models.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<Guid>("SerialNumber");

                    b.HasKey("Id");

                    b.ToTable("Submissions");
                });
#pragma warning restore 612, 618
        }
    }
}