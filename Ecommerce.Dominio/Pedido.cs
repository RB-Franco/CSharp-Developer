using System.Collections.Generic;

namespace Ecommerce.Dominio
{
    public class Pedido
    {
        public int Id { get; set; }        
        public decimal ValorTotal { get; set; }
        public int QtdItem { get; set; }
        public decimal ValorFrete { get; set; }  
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } 
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; } 
        
        public List<ProdutosPedido> ProdutosPedidos { get; set; }
    }
}