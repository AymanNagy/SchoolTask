﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Models;

namespace School.Migrations
{
    [DbContext(typeof(AppDpContext))]
    partial class AppDpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("School.Models.Database.Days", b =>
                {
                    b.Property<int>("DayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayID");

                    b.ToTable("tbDays");

                    b.HasData(
                        new
                        {
                            DayID = 1,
                            DayName = "Saturday"
                        },
                        new
                        {
                            DayID = 2,
                            DayName = "Sunday"
                        },
                        new
                        {
                            DayID = 3,
                            DayName = "Monday"
                        },
                        new
                        {
                            DayID = 4,
                            DayName = "Tuesday"
                        },
                        new
                        {
                            DayID = 5,
                            DayName = "Wednesday"
                        },
                        new
                        {
                            DayID = 6,
                            DayName = "Thursday"
                        },
                        new
                        {
                            DayID = 7,
                            DayName = "Friday"
                        });
                });

            modelBuilder.Entity("School.Models.Database.SchoolClass", b =>
                {
                    b.Property<int>("SchoolClassID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.HasKey("SchoolClassID");

                    b.HasIndex("SchoolID");

                    b.ToTable("tbSchoolClass");

                    b.HasData(
                        new
                        {
                            SchoolClassID = 1,
                            ClassName = "Class 1",
                            SchoolID = 1
                        },
                        new
                        {
                            SchoolClassID = 2,
                            ClassName = "Class 2",
                            SchoolID = 1
                        },
                        new
                        {
                            SchoolClassID = 3,
                            ClassName = "Class 3",
                            SchoolID = 1
                        },
                        new
                        {
                            SchoolClassID = 4,
                            ClassName = "Class 4",
                            SchoolID = 1
                        },
                        new
                        {
                            SchoolClassID = 5,
                            ClassName = "Class 5",
                            SchoolID = 1
                        });
                });

            modelBuilder.Entity("School.Models.Database.Schools", b =>
                {
                    b.Property<int>("SchoolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolID");

                    b.ToTable("tbSchools");

                    b.HasData(
                        new
                        {
                            SchoolID = 1,
                            SchoolName = "School1"
                        },
                        new
                        {
                            SchoolID = 2,
                            SchoolName = "School2"
                        },
                        new
                        {
                            SchoolID = 3,
                            SchoolName = "School3"
                        },
                        new
                        {
                            SchoolID = 4,
                            SchoolName = "School4"
                        });
                });

            modelBuilder.Entity("School.Models.Database.Students", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SchoolClassID")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("SchoolClassID");

                    b.ToTable("tbStudents");
                });

            modelBuilder.Entity("School.Models.Database.SubjectTable", b =>
                {
                    b.Property<int>("SubjectTableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DayID")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolClassID")
                        .HasColumnType("int");

                    b.Property<int?>("TeachersAndSubjectID")
                        .HasColumnType("int");

                    b.HasKey("SubjectTableID");

                    b.HasIndex("DayID");

                    b.HasIndex("SchoolClassID");

                    b.HasIndex("TeachersAndSubjectID");

                    b.ToTable("tbSubjectTable");
                });

            modelBuilder.Entity("School.Models.Database.Subjects", b =>
                {
                    b.Property<int>("SubjectsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectsID");

                    b.ToTable("tbSubjects");

                    b.HasData(
                        new
                        {
                            SubjectsID = 1,
                            SubjectName = "Sub 1"
                        },
                        new
                        {
                            SubjectsID = 2,
                            SubjectName = "Sub 2"
                        },
                        new
                        {
                            SubjectsID = 3,
                            SubjectName = "Sub 3"
                        },
                        new
                        {
                            SubjectsID = 4,
                            SubjectName = "Sub 4"
                        });
                });

            modelBuilder.Entity("School.Models.Database.Teachers", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("tbTeachers");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            TeacherName = "Teacher 1"
                        },
                        new
                        {
                            TeacherID = 2,
                            TeacherName = "Teacher 2"
                        },
                        new
                        {
                            TeacherID = 3,
                            TeacherName = "Teacher 3"
                        },
                        new
                        {
                            TeacherID = 4,
                            TeacherName = "Teacher 4"
                        });
                });

            modelBuilder.Entity("School.Models.Database.TeachersAndSubject", b =>
                {
                    b.Property<int>("TeachersAndSubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectsID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("TeachersAndSubjectID");

                    b.HasIndex("SubjectsID");

                    b.HasIndex("TeacherID");

                    b.ToTable("tbTeachersAndSubject");
                });

            modelBuilder.Entity("School.Models.Database.SchoolClass", b =>
                {
                    b.HasOne("School.Models.Database.Schools", "school")
                        .WithMany("SchoolClasss")
                        .HasForeignKey("SchoolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Models.Database.Students", b =>
                {
                    b.HasOne("School.Models.Database.SchoolClass", "SchoolClass")
                        .WithMany("students")
                        .HasForeignKey("SchoolClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("School.Models.Database.SubjectTable", b =>
                {
                    b.HasOne("School.Models.Database.Days", "Day")
                        .WithMany()
                        .HasForeignKey("DayID");

                    b.HasOne("School.Models.Database.SchoolClass", "SchoolClass")
                        .WithMany()
                        .HasForeignKey("SchoolClassID");

                    b.HasOne("School.Models.Database.TeachersAndSubject", "TeachersAndSubject")
                        .WithMany()
                        .HasForeignKey("TeachersAndSubjectID");
                });

            modelBuilder.Entity("School.Models.Database.TeachersAndSubject", b =>
                {
                    b.HasOne("School.Models.Database.Subjects", "Subject")
                        .WithMany("TeachersAndSubjects")
                        .HasForeignKey("SubjectsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Models.Database.Teachers", "teacher")
                        .WithMany("TeachersAndSubjects")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
