using System.Threading.Tasks;
using Ecommerce.Dominio;

namespace Ecommerce.Repositorio
{
    public interface IEcommerceRepositorio
    {
        //GERAL
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;         

         Task<bool> SaveChangesAsync();

         //PEDIDOS         

         //Busca todos os pedidos
         Task<Pedido[]> GetAllPedidoAsync();
                 
         //CLIENTE
         Task<Cliente[]> GetAllClientesAsync();
         
         //Produto
         Task<Produto[]> GetAllProdutosAsync();
         Task<Produto> GetProdutosAsyncById(int Id);

    }
}