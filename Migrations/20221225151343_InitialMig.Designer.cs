﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcWorkspace.Data;

#nullable disable

namespace MvcBook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221225151343_InitialMig")]
    partial class InitialMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcBook.Models.Books", b =>
                {
                    b.Property<int>("B_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("B_Id"), 1L, 1);

                    b.Property<string>("B_Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("B_Page")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("B_Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MvcBook.Models.Commentaries", b =>
                {
                    b.Property<int>("C_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("C_Id"), 1L, 1);

                    b.Property<int>("B_Id")
                        .HasColumnType("int");

                    b.Property<string>("C_Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("C_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("C_Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("U_Id")
                        .HasColumnType("int");

                    b.HasKey("C_Id");

                    b.HasIndex("B_Id");

                    b.HasIndex("U_Id");

                    b.ToTable("Commentaries");
                });

            modelBuilder.Entity("MvcBook.Models.Users", b =>
                {
                    b.Property<int>("U_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("U_Id"), 1L, 1);

                    b.Property<bool>("Is_Admin")
                        .HasColumnType("bit");

                    b.Property<string>("U_Bday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("U_Password")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("U_SignupDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("U_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MvcBook.Models.Commentaries", b =>
                {
                    b.HasOne("MvcBook.Models.Books", "Books")
                        .WithMany()
                        .HasForeignKey("B_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcBook.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("U_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
