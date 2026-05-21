using BeautyClub2026App.Models;
using BeautyClub2026App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class CreateModel : PageModel
    {
        private IProdutoService _service;

        public CreateModel(IProdutoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Produto Produto { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Incluir(Produto);

            return RedirectToPage("/Index");
        }
    }
}