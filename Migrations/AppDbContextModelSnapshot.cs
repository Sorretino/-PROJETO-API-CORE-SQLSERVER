﻿// <auto-generated />
using AlunosApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlunosApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlunosApi.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "maria@gmail.com",
                            Idade = 23,
                            Imagem = "https://dowhile.io/_next/image?url=%2Fimages%2Fbuild-the-future-hero.png&w=1920&q=100",
                            Nome = "Maria da Penha"
                        },
                        new
                        {
                            Id = 2,
                            Email = "fernando@gmail.com",
                            Idade = 39,
                            Imagem = "https://dowhile.io/_next/image?url=%2Fimages%2Fbuild-the-future-hero.png&w=1920&q=100",
                            Nome = "Fernando Sorrentino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
