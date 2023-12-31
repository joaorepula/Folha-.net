﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20231010002519_novamigration")]
    partial class novamigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Models.Folha", b =>
                {
                    b.Property<int>("FolhaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("ano")
                        .HasColumnType("int");

                    b.Property<double?>("impostoFgts")
                        .HasColumnType("double");

                    b.Property<double?>("impostoInss")
                        .HasColumnType("double");

                    b.Property<double?>("impostoIrrf")
                        .HasColumnType("double");

                    b.Property<int>("mes")
                        .HasColumnType("int");

                    b.Property<double?>("quantidade")
                        .HasColumnType("double");

                    b.Property<double?>("salarioBruto")
                        .HasColumnType("double");

                    b.Property<double?>("salarioLiquido")
                        .HasColumnType("double");

                    b.Property<double?>("valor")
                        .HasColumnType("double");

                    b.HasKey("FolhaId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Folha");
                });

            modelBuilder.Entity("API.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("API.Models.Folha", b =>
                {
                    b.HasOne("API.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
