﻿// <auto-generated />
using System;
using ClassSchedule.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassSchedule.Migrations
{
    [DbContext(typeof(ClassScheduleContext))]
    partial class ClassScheduleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("ClassSchedule.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DayId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MilitaryTime")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(4);

                    b.Property<int?>("Number")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(200);

                    b.HasKey("ClassId");

                    b.HasIndex("DayId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            DayId = 1,
                            MilitaryTime = "1500",
                            Number = 101,
                            TeacherId = 1,
                            Title = "Sign Language"
                        },
                        new
                        {
                            ClassId = 2,
                            DayId = 2,
                            MilitaryTime = "1100",
                            Number = 301,
                            TeacherId = 1,
                            Title = "Sign Language"
                        },
                        new
                        {
                            ClassId = 3,
                            DayId = 4,
                            MilitaryTime = "1300",
                            Number = 101,
                            TeacherId = 4,
                            Title = "Logic"
                        },
                        new
                        {
                            ClassId = 4,
                            DayId = 4,
                            MilitaryTime = "1500",
                            Number = 201,
                            TeacherId = 4,
                            Title = "Logic"
                        },
                        new
                        {
                            ClassId = 5,
                            DayId = 3,
                            MilitaryTime = "1000",
                            Number = 101,
                            TeacherId = 2,
                            Title = "Early Childhood Education"
                        },
                        new
                        {
                            ClassId = 6,
                            DayId = 5,
                            MilitaryTime = "1000",
                            Number = 401,
                            TeacherId = 2,
                            Title = "Early Childhood Education"
                        },
                        new
                        {
                            ClassId = 7,
                            DayId = 1,
                            MilitaryTime = "1300",
                            Number = 101,
                            TeacherId = 5,
                            Title = "Calculus"
                        },
                        new
                        {
                            ClassId = 8,
                            DayId = 3,
                            MilitaryTime = "1300",
                            Number = 201,
                            TeacherId = 5,
                            Title = "Calculus"
                        },
                        new
                        {
                            ClassId = 9,
                            DayId = 4,
                            MilitaryTime = "1400",
                            Number = 101,
                            TeacherId = 3,
                            Title = "Nonviolence and Social Change"
                        },
                        new
                        {
                            ClassId = 10,
                            DayId = 5,
                            MilitaryTime = "1400",
                            Number = 201,
                            TeacherId = 3,
                            Title = "Nonviolence and Social Change"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.HasKey("DayId");

                    b.ToTable("Days");

                    b.HasData(
                        new
                        {
                            DayId = 1,
                            Name = "Monday"
                        },
                        new
                        {
                            DayId = 2,
                            Name = "Tuesday"
                        },
                        new
                        {
                            DayId = 3,
                            Name = "Wednesday"
                        },
                        new
                        {
                            DayId = 4,
                            Name = "Thursday"
                        },
                        new
                        {
                            DayId = 5,
                            Name = "Friday"
                        },
                        new
                        {
                            DayId = 6,
                            Name = "Saturday"
                        },
                        new
                        {
                            DayId = 7,
                            Name = "Sunday"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            FirstName = "Anne",
                            LastName = "Sullivan"
                        },
                        new
                        {
                            TeacherId = 2,
                            FirstName = "Maria",
                            LastName = "Montessori"
                        },
                        new
                        {
                            TeacherId = 3,
                            FirstName = "Martin Luther",
                            LastName = "King"
                        },
                        new
                        {
                            TeacherId = 4,
                            FirstName = "",
                            LastName = "Aristotle"
                        },
                        new
                        {
                            TeacherId = 5,
                            FirstName = "Jaime",
                            LastName = "Escalante"
                        });
                });

            modelBuilder.Entity("ClassSchedule.Models.Class", b =>
                {
                    b.HasOne("ClassSchedule.Models.Day", "Day")
                        .WithMany("Classes")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassSchedule.Models.Teacher", "Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
