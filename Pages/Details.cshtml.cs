using BeautyClub2026App.Models;
using BeautyClub2026App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeautyClub2026App.Pages
{
    public class DetailsModel : PageModel
    {
        public Produto Produto { get; set; }
        private IProdutoService _service;

        public DetailsModel(IProdutoService service)
        {
            _service = service;
        }

        public void OnGet(int id)
        {
            Produto = _service.Obter(id);
        }
    }
}