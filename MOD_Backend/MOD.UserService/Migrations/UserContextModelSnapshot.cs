﻿// <auto-generated />
using MOD.UserService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.UserService.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.UserService.Models.Mentor", b =>
                {
                    b.Property<string>("MentorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MentorName")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Mentor_EmailId")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Password")
                        .HasColumnName("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mentor_PhoneNumber")
                        .HasColumnName("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("Mentor_Skills")
                        .HasColumnName("Skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Timeslot")
                        .HasColumnName("Timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Mentor_YrsOfExp")
                        .HasColumnName("Experience")
                        .HasColumnType("int");

                    b.HasKey("MentorId");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.UserService.Models.Student", b =>
                {
                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Student_EmailId")
                        .HasColumnName("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Student_Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Student_Password")
                        .HasColumnName("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Student_PhoneNumber")
                        .HasColumnName("ContactNumber")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
