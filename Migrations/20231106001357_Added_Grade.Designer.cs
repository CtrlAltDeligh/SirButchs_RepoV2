﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student.Web.Api.Data;

#nullable disable

namespace Student.Web.Api.Migrations
{
    [DbContext(typeof(StudentDataContext))]
    [Migration("20231106001357_Added_Grade")]
    partial class Added_Grade
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("Student.Web.Api.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FinalGrade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FinalTerm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MidTerm")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PupilId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PupilId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grades", (string)null);
                });

            modelBuilder.Entity("Student.Web.Api.Models.Grading", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gradings", (string)null);
                });

            modelBuilder.Entity("Student.Web.Api.Models.Pupil", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Pupils", (string)null);
                });

            modelBuilder.Entity("Student.Web.Api.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects", (string)null);
                });

            modelBuilder.Entity("Student.Web.Api.Models.Grade", b =>
                {
                    b.HasOne("Student.Web.Api.Models.Pupil", "Pupil")
                        .WithMany("Grades")
                        .HasForeignKey("PupilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Student.Web.Api.Models.Subject", "Subject")
                        .WithMany("Grades")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pupil");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Student.Web.Api.Models.Pupil", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("Student.Web.Api.Models.Subject", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
