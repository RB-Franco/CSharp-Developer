using System.Collections.Generic;

namespace Ecommerce.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodigoCli { get; set; }
        public string Nome { get; set; }
        public List<ProdutosPedido> ProdutosPedidos { get; set; }

    }
}