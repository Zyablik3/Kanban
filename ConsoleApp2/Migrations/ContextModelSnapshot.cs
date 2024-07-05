﻿// <auto-generated />
using System;
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ConsoleApp2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp2.entity.KanbanProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Cost")
                        .HasColumnType("integer");

                    b.Property<int?>("KanbanTaskId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KanbanTaskId");

                    b.ToTable("KanbanProjects");
                });

            modelBuilder.Entity("ConsoleApp2.entity.KanbanTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AcceeptSoft")
                        .HasColumnType("text");

                    b.Property<string>("ApproveTZ")
                        .HasColumnType("text");

                    b.Property<string>("DevelopSoft")
                        .HasColumnType("text");

                    b.Property<string>("Interview")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("WriteTZ")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KanbanTasks");
                });

            modelBuilder.Entity("ConsoleApp2.entity.MyTaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Accept")
                        .HasColumnType("text");

                    b.Property<string>("Analysis")
                        .HasColumnType("text");

                    b.Property<string>("Development")
                        .HasColumnType("text");

                    b.Property<string>("Drop")
                        .HasColumnType("text");

                    b.Property<string>("Queue")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MyTaskStatuses");
                });

            modelBuilder.Entity("ConsoleApp2.entity.Zakazchik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<int>("INN")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Zakazchik");
                });

            modelBuilder.Entity("ConsoleApp2.entity.KanbanProject", b =>
                {
                    b.HasOne("ConsoleApp2.entity.KanbanTask", null)
                        .WithMany("KanbanProjects")
                        .HasForeignKey("KanbanTaskId");
                });

            modelBuilder.Entity("ConsoleApp2.entity.KanbanTask", b =>
                {
                    b.Navigation("KanbanProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
