

namespace BeautyClub2026App.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
        public double Preco { get; set; }
        public bool EntregaExpressa { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}