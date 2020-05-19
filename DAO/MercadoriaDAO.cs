using System.Collections.Generic;
using System.Linq;
using WebEstoque.Models;

namespace WebEstoque.DAO
{
    public class MercadoriaDAO
    {
        public void Adicionar(Mercadoria mercadoria)
        {
            using (var context = new WebEstoqueContext())
            {
                context.Mercadorias.Add(mercadoria);
                context.SaveChanges();
            }
        }

        public void Atualizar(Mercadoria mercadoria)
        {
            using (var contexto = new WebEstoqueContext())
            {
                contexto.Entry(mercadoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public IList<Mercadoria> Listar()
        {
            using (var contexto = new WebEstoqueContext())
            {
                return contexto.Mercadorias.Include("Estoque").ToList();
            }
        }

    }
}