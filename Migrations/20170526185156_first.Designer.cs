﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using aspnet_exam_movie.Models;

namespace MovieProject_ASPNET.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20170526185156_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("aspnet_exam_movie.Models.Entities.Movie", b =>
                {
                    b.Property<int>("MovieItemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Director");

                    b.Property<string>("Genre");

                    b.Property<string>("MovieLength");

                    b.Property<string>("MoviePlot");

                    b.Property<string>("MovieTitle");

                    b.Property<int>("Rating");

                    b.Property<int>("YearPublished");

                    b.HasKey("MovieItemID");

                    b.ToTable("Movies");
                });
        }
    }
}
