using WebEstoque.Models;

namespace WebEstoque.DAO
{
    public class EstoqueDAO
    {
        public void Adiciona(Estoque estoque)
        {
            using (var context = new WebEstoqueContext())
            {
                context.Estoques.Add(estoque);
                context.SaveChanges();
            }
        }

        public void Atualiza(Estoque estoque)
        {
            using (var contexto = new WebEstoqueContext())
            {
                contexto.Entry(estoque).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}