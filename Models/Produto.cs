using System.ComponentModel.DataAnnotations;

namespace BeautyClub2026App.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Nome' obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Campo 'Nome' deve conter entre 5 e 100 caracteres.")]
        public string Nome { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Descrição' obrigatório.")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "Campo 'Descrição' deve conter entre 20 e 200 caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo 'Imagem' obrigatório.")]
        [Display(Name = "Imagem")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
        [DataType(DataType.Currency)]
        public double Preco { get; set; }

        [Display(Name = "Entrega Expressa")]
        public bool EntregaExpressa { get; set; }

        public string EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";

        [Display(Name = "Disponível desde")]
        [Required(ErrorMessage = "Campo 'Disponível desde' obrigatório.")]
        [DataType("month")]
        [DisplayFormat(DataFormatString = "{0:D}")]
        public DateTime DataCadastro { get; set; }
    }
}