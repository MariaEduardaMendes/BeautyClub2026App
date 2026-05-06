using BeautyClub2026App.Models;
using BeautyClub2026App.Services; 
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProdutoService _produtoService;

        public IList<Produto> Produtos { get; set; } = default!;

        public IndexModel(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public void OnGet()
        {
            // Busca a lista pronta no serviço
            Produtos = _produtoService.ObterTodos();
        }
    }
}