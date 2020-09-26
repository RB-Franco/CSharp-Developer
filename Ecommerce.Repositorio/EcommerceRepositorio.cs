using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repositorio
{
  public class EcommerceRepositorio : IEcommerceRepositorio
  {
    private readonly EcommerceContext _context;

    public EcommerceRepositorio(EcommerceContext context)
    {
      _context = context;
      _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    #region "Metodos Crud"
        //Metodos Gerais
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return( await _context.SaveChangesAsync()) >0;
        }
    #endregion

    #region "Metodos de Retorno"
        //PEDIDO
        public async Task<Pedido[]> GetAllPedidoAsync(bool includeProdutos = false)
        {
            IQueryable<Pedido> query = _context.Pedidos;
            
            if (includeProdutos)
            {
             query = query
                .Include(pp => pp.ProdutosPedidos)
                .ThenInclude(p => p.Produto);   
            }
            query = query.AsNoTracking().OrderBy(i => i.Id);
            
            return await query.ToArrayAsync();
        }
        
        //CLIENTE
        public async Task<Cliente[]> GetAllClientesAsync()
        {
            IQueryable<Cliente> query = _context.Clientes;
            
            query = query.AsNoTracking().OrderBy(p => p.Id);
            
            return await query.ToArrayAsync();
        }
        
        //PRODUTO        
        public async Task<Produto[]> GetAllProdutosAsync()
        {
            IQueryable<Produto> query = _context.Produtos;
            
            query = query.AsNoTracking().OrderBy(p => p.Nome);
            
            return await query.ToArrayAsync();
        }

        public async Task<Produto> GetProdutosAsyncById(int Id)
        {
            IQueryable<Produto> query = _context.Produtos;
            
            query = query.AsNoTracking().Where(p => p.Id == Id);
            
            return await query.FirstOrDefaultAsync();
        }
        
        
    #endregion
  }
}