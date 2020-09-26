namespace Ecommerce.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string CodigoProd { get; set; }
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string ImagemUrl { get; set; }
    }
}