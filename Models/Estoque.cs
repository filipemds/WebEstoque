namespace WebEstoque.Models
{
    public class Estoque
    {

        public int Id { get; set; }

        public int Quantidade { get; set; }

        public Mercadoria Mercadoria { get; set; }

        public int? MercadoriaId { get; set; }
    }
}