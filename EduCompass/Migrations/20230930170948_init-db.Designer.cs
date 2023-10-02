﻿// <auto-generated />
using System;
using EduCompass.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduCompass.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230930170948_init-db")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EduCompass.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Answer4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("EduCompass.Models.Career", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoefficientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameInGreek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("EduCompass.Models.Coefficient", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameInGreek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Coefficients");
                });

            modelBuilder.Entity("EduCompass.Models.CoefficientQuizGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerStrings")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoefficientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("QuestionIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStarted")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CoefficientQuizGrades");
                });

            modelBuilder.Entity("EduCompass.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AudioFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<string>("UUID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EduCompass.Models.CourseHasCoefficient", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("CoefficientName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "CoefficientName");

                    b.ToTable("CourseHasCoefficients");
                });

            modelBuilder.Entity("EduCompass.Models.CourseQuizGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AnswerIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("QuestionIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeFinished")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStarted")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CourseQuizGrades");
                });

            modelBuilder.Entity("EduCompass.Models.Grade", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FinalGrade")
                        .HasColumnType("int");

                    b.Property<int>("InterestScore")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CourseId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("EduCompass.Models.PostGraduateInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hyperlink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PostGraduateInstitutions");
                });

            modelBuilder.Entity("EduCompass.Models.PostGraduateInstitutionHasCoefficient", b =>
                {
                    b.Property<int>("PostGraduateInstitutionId")
                        .HasColumnType("int");

                    b.Property<string>("CoefficientName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("HasCoefficient")
                        .HasColumnType("bit");

                    b.HasKey("PostGraduateInstitutionId", "CoefficientName");

                    b.ToTable("PostGraduateInstitutionHasCoefficients");
                });

            modelBuilder.Entity("EduCompass.Models.PrerequisiteCourse", b =>
                {
                    b.Property<int>("BaseCourseId")
                        .HasColumnType("int");

                    b.Property<int>("PrerequisiteCourseId")
                        .HasColumnType("int");

                    b.HasKey("BaseCourseId", "PrerequisiteCourseId");

                    b.ToTable("PrerequisiteCourses");
                });

            modelBuilder.Entity("EduCompass.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("EduCompass.Models.TimeSpent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TotalTime")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TimeSpents");
                });

            modelBuilder.Entity("EduCompass.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasCompletedIntroTest")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EduCompass.Models.UserHasCoefficient", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("CoefficientName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.HasKey("UserId", "CoefficientName");

                    b.ToTable("UserHasCoefficients");
                });
#pragma warning restore 612, 618
        }
    }
}