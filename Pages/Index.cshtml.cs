using BeautyClub2026App.Models;
using BeautyClub2026App.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Produto> Produtos { get; set; }
        private IProdutoService _service;

        public IndexModel(IProdutoService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Produtos = _service.ObterTodos();
        }
    }
}