﻿// <auto-generated />
using CadastrodeTransacao.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastrodeTransacao.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230411031546_Version2")]
    partial class Version2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("CadastrodeTransacao.Models.PessoaModel", b =>
                {
                    b.Property<int>("PK_Pessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PK_Pessoa");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("CadastrodeTransacao.Models.TransacoesModel", b =>
                {
                    b.Property<int>("PK_Transacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FK_Pessoa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Valor")
                        .HasColumnType("INTEGER");

                    b.HasKey("PK_Transacao");

                    b.HasIndex("FK_Pessoa");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("CadastrodeTransacao.Models.TransacoesModel", b =>
                {
                    b.HasOne("CadastrodeTransacao.Models.PessoaModel", "PK_Pessoa")
                        .WithMany()
                        .HasForeignKey("FK_Pessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PK_Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
