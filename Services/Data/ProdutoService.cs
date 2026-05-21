using BeautyClub2026App.Data;
using BeautyClub2026App.Models;

namespace BeautyClub2026App.Services.Data
{
    public class ProdutoService : IProdutoService
    {
        private BeautyClubDbContext _context;

        public ProdutoService(BeautyClubDbContext context)
        {
            _context = context;
        }

        public IList<Produto> ObterTodos()
        {
            return _context.Produto.ToList();
        }

        public Produto Obter(int id)
        {
            return _context.Produto.SingleOrDefault(p => p.ProdutoId == id);
        }

        public void Incluir(Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public void Alterar(Produto produto)
        {
            var produtoExistente = Obter(produto.ProdutoId);

            produtoExistente.Nome = produto.Nome;
            produtoExistente.Descricao = produto.Descricao;
            produtoExistente.Preco = produto.Preco;
            produtoExistente.EntregaExpressa = produto.EntregaExpressa;
            produtoExistente.DataCadastro = produto.DataCadastro;
            produtoExistente.ImagemUrl = produto.ImagemUrl;

            _context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var produtoExistente = Obter(id);
            _context.Produto.Remove(produtoExistente);
            _context.SaveChanges();
        }
    }
}