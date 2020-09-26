namespace Ecommerce.Dominio
{
    public class ProdutosPedido
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}