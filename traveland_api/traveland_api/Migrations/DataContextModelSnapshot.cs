﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using traveland_api.Context;

#nullable disable

namespace traveland_api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("traveland_api.Models.Compra", b =>
                {
                    b.Property<int>("id_compra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("data_compra")
                        .HasColumnType("longtext");

                    b.Property<decimal>("total_compra")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("id_compra");

                    b.HasIndex("DestinoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("traveland_api.Models.Contato", b =>
                {
                    b.Property<int>("id_contato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("mensagem")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.HasKey("id_contato");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("traveland_api.Models.Destinos", b =>
                {
                    b.Property<int>("id_destino")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("data_ida")
                        .HasColumnType("longtext");

                    b.Property<string>("data_volta")
                        .HasColumnType("longtext");

                    b.Property<string>("estado")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_destino")
                        .HasColumnType("longtext");

                    b.Property<string>("pais")
                        .HasColumnType("longtext");

                    b.Property<decimal>("preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("id_destino");

                    b.ToTable("Destinos");
                });

            modelBuilder.Entity("traveland_api.Models.Usuarios", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_usuario")
                        .HasColumnType("longtext");

                    b.Property<string>("senha")
                        .HasColumnType("longtext");

                    b.HasKey("id_usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("traveland_api.Models.Compra", b =>
                {
                    b.HasOne("traveland_api.Models.Destinos", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("traveland_api.Models.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destino");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
