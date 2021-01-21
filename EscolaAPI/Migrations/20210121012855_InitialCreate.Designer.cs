﻿// <auto-generated />
using EscolaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210121012855_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EscolaAPI.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nascimento = "01/01/2000",
                            Nome = "Alex Marques",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nascimento = "01/02/2000",
                            Nome = "Júlia Pereira",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Nascimento = "01/03/2000",
                            Nome = "Caio Ferreira",
                            ProfessorId = 3
                        });
                });

            modelBuilder.Entity("EscolaAPI.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Carlos da Silva"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Paula Souza"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Simone Santos"
                        });
                });

            modelBuilder.Entity("EscolaAPI.Models.Aluno", b =>
                {
                    b.HasOne("EscolaAPI.Models.Professor", "Professor")
                        .WithMany("Alunos")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("EscolaAPI.Models.Professor", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}