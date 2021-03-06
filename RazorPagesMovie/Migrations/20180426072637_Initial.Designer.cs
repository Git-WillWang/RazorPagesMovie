﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RazorPagesMovie.Models;
using System;

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20180426072637_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesMovie.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Genre");

                    b.Property<int>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<int>("Title");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });
#pragma warning restore 612, 618
        }
    }
}
