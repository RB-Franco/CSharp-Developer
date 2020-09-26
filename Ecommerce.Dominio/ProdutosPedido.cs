namespace Ecommerce.Dominio
{
    public class ProdutosPedido
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; }
    }
}