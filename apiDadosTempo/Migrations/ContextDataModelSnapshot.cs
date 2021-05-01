﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiDadosTempo.Context;

namespace apiDadosTempo.Migrations
{
    [DbContext(typeof(ContextData))]
    partial class ContextDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apiDadosTempo.Entities.CidadeTemperatura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataHoraConsulta")
                        .HasColumnType("datetime2");

                    b.Property<double>("max")
                        .HasColumnType("float");

                    b.Property<double>("min")
                        .HasColumnType("float");

                    b.Property<double>("temp")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("cidadeTemperatura");
                });
#pragma warning restore 612, 618
        }
    }
}
