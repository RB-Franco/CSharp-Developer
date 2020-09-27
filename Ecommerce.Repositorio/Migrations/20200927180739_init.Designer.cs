﻿// <auto-generated />
using Ecommerce.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ecommerce.Repositorio.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20200927180739_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Ecommerce.Dominio.Cliente", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<int>("Id_Cli")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Ecommerce.Dominio.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("QtdItem");

                    b.Property<decimal>("ValorFrete");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Ecommerce.Dominio.Produto", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<int>("Id_Prod")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImagemUrl");

                    b.Property<string>("Nome");

                    b.Property<decimal>("PrecoUnitario");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Ecommerce.Dominio.ProdutosPedido", b =>
                {
                    b.Property<int>("ClienteId");

                    b.Property<int>("PedidoId");

                    b.Property<int>("ProdutoId");

                    b.HasKey("ClienteId", "PedidoId", "ProdutoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("ProdutosPedidos");
                });

            modelBuilder.Entity("Ecommerce.Dominio.ProdutosPedido", b =>
                {
                    b.HasOne("Ecommerce.Dominio.Pedido")
                        .WithMany("ProdutosPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}