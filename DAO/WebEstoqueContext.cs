using System.Data.Entity;
using WebEstoque.Models;

namespace WebEstoque.DAO
{
    public class WebEstoqueContext : DbContext
    {
        public DbSet<Mercadoria> Mercadorias { get; set; }

        public DbSet<Estoque> Estoques { get; set; }

    }
}