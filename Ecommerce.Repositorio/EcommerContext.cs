using Ecommerce.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositorio
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) {}

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ProdutosPedido> ProdutosPedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<Cliente>().Property(p => p.Id_Cli)
                .UseNpgsqlIdentityAlwaysColumn().UseNpgsqlIdentityColumn(); 

            modelBuilder.Entity<Produto>().Property(p => p.Id_Prod)
                .UseNpgsqlIdentityAlwaysColumn().UseNpgsqlIdentityColumn();     

            modelBuilder.Entity<Pedido>().Property(p => p.Id)
                .UseNpgsqlIdentityAlwaysColumn();                             

            modelBuilder.Entity<ProdutosPedido>()
                .HasKey(PP => new {PP.ClienteId, PP.PedidoId, PP.ProdutoId});
            
        }
    }
}