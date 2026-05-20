using BeautyClub2026App.Models;

namespace BeautyClub2026App.Services
{
    public interface IProdutoService
    {
        IList<Produto> ObterTodos();
        Produto Obter(int id);
        void Incluir(Produto produto);
        void Alterar(Produto produto);
        void Excluir(int id);
    }
}