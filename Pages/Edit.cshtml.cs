using BeautyClub2026App.Models;
using BeautyClub2026App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class EditModel : PageModel
    {
        private IProdutoService _service;

        public EditModel(IProdutoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _service.Obter(id);

            if (Produto == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Produto);

            return RedirectToPage("/Index");
        }
    }
}