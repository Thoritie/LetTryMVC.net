﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using ThorCaseStudy.Models;

namespace ThorCaseStudy.Migrations
{
    [DbContext(typeof(ThorCaseStudyContext))]
    partial class ThorCaseStudyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("ThorCaseStudy.Models.Thor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Thor");
                });
#pragma warning restore 612, 618
        }
    }
}
