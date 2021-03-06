﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vacandum.EF;

namespace Vacandum.EF.Migrations
{
    [DbContext(typeof(VacandumContext))]
    partial class VacandumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("Vacandum.Services.Models.Company", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<string>("ExternalId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Vacandum.Services.Models.Salary", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<int>("Currency");

                    b.Property<float?>("From");

                    b.Property<float?>("To");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("Vacandum.Services.Models.Vacancy", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<byte[]>("CompanyId")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<int>("Experience");

                    b.Property<string>("ExternalId");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<byte[]>("SalaryId")
                        .HasConversion(new ValueConverter<byte[], byte[]>(v => default(byte[]), v => default(byte[]), new ConverterMappingHints(size: 16)));

                    b.Property<DateTime>("SavingDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SalaryId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("Vacandum.Services.Models.Vacancy", b =>
                {
                    b.HasOne("Vacandum.Services.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Vacandum.Services.Models.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryId");
                });
#pragma warning restore 612, 618
        }
    }
}
