using BeautyClub2026App.Models;
using BeautyClub2026App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ProdutoService _produtoService;

        public Produto? ProdutoSelecionado { get; set; }

        public DetailsModel(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult OnGet(int id)
        {
            ProdutoSelecionado = _produtoService.ObterPorId(id);

            if (ProdutoSelecionado == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}