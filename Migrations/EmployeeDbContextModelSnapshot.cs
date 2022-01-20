﻿// <auto-generated />
using Angular.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Angular.API.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Angular.API.Entities.Employee", b =>
                {
                    b.Property<int>("employeeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("emailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employeeid");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}