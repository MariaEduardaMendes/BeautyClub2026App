using BeautyClub2026App.Models;

namespace BeautyClub2026App.Services.Memory
{
    public class ProdutoService : IProdutoService
    {
        private IList<Produto> _produtos;

        public ProdutoService()
        {
            CarregarListaInicial();
        }

        public IList<Produto> ObterTodos()
        {
            return _produtos;
        }

        public Produto Obter(int id)
        {
            return _produtos.Single(item => item.ProdutoId == id);
        }

        private void CarregarListaInicial()
        {
            _produtos = new List<Produto>()
            {
                new Produto
                {
                    ProdutoId = 1,
                    Nome = "Sérum Facial Vitamina C 15%",
                    Descricao = "Sérum antioxidante de alta potência que ilumina, uniformiza o tom da pele e reduz linhas finas.",
                    ImagemUrl = "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-15),
                    EntregaExpressa = true,
                    Preco = 149.90,
                },
                new Produto
                {
                    ProdutoId = 2,
                    Nome = "Creme Hidratante Noturno Reparador",
                    Descricao = "Hidratação profunda com ácido hialurônico e ceramidas para restaurar a barreira da pele durante o sono.",
                    ImagemUrl = "https://images.unsplash.com/photo-1629198688000-71f23e745b6e?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-30),
                    EntregaExpressa = false,
                    Preco = 129.50,
                },
                new Produto
                {
                    ProdutoId = 3,
                    Nome = "Protetor Solar FPS 50 Toque Seco",
                    Descricao = "Alta proteção UVA/UVB com textura invisível e controle de oleosidade por até 12 horas.",
                    ImagemUrl = "https://images.unsplash.com/photo-1556228578-0d85b1a4d571?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-10),
                    EntregaExpressa = true,
                    Preco = 89.90,
                },
                new Produto
                {
                    ProdutoId = 4,
                    Nome = "Base Líquida Matte Acabamento Natural",
                    Descricao = "Cobertura média a alta, vegana e de longa duração. Não craquela e resiste ao suor.",
                    ImagemUrl = "https://images.unsplash.com/photo-1599305090598-fe179d501227?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-5),
                    EntregaExpressa = true,
                    Preco = 115.00,
                },
                new Produto
                {
                    ProdutoId = 5,
                    Nome = "Máscara de Cílios Volume Extremo",
                    Descricao = "Fórmula enriquecida com óleo de rícino para cílios mais volumosos, longos e saudáveis.",
                    ImagemUrl = "https://images.unsplash.com/photo-1631214500115-598fc2cb8d2d?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-45),
                    EntregaExpressa = false,
                    Preco = 65.90,
                },
                new Produto
                {
                    ProdutoId = 6,
                    Nome = "Batom Hidratante Vermelho Clássico",
                    Descricao = "Cor intensa com acabamento acetinado. Enriquecido com manteiga de karité.",
                    ImagemUrl = "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-2),
                    EntregaExpressa = true,
                    Preco = 54.90,
                },
                new Produto
                {
                    ProdutoId = 7,
                    Nome = "Tônico Facial Calmante de Camomila",
                    Descricao = "Equilibra o pH da pele, acalma vermelhidões e prepara o rosto para a hidratação. Sem álcool.",
                    ImagemUrl = "https://images.unsplash.com/photo-1608248543803-ba4f8c70ae0b?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-20),
                    EntregaExpressa = false,
                    Preco = 72.00,
                },
                new Produto
                {
                    ProdutoId = 8,
                    Nome = "Óleo Capilar Nutritivo Argan & Ojon",
                    Descricao = "Reduz o frizz, sela as pontas duplas e proporciona brilho intenso sem pesar os fios.",
                    ImagemUrl = "https://images.unsplash.com/photo-1526947425960-945c6e72858f?w=500&h=500&fit=crop&q=80",
                    DataCadastro = DateTime.Now.AddDays(-8),
                    EntregaExpressa = true,
                    Preco = 85.50,
                }
            };
        }

        public void Incluir(Produto produto)
        {
            var proximoNumero = _produtos.Max(item => item.ProdutoId) + 1;
            produto.ProdutoId = proximoNumero;
            _produtos.Add(produto);
        }

        public void Alterar(Produto produtoAlterado)
        {
            var produtoExistente = Obter(produtoAlterado.ProdutoId);
            produtoExistente.Nome = produtoAlterado.Nome;
            produtoExistente.Descricao = produtoAlterado.Descricao;
            produtoExistente.Preco = produtoAlterado.Preco;
            produtoExistente.EntregaExpressa = produtoAlterado.EntregaExpressa;
            produtoExistente.DataCadastro = produtoAlterado.DataCadastro;
            produtoExistente.ImagemUrl = produtoAlterado.ImagemUrl;
        }

        public void Excluir(int id)
        {
            var produtoExistente = Obter(id);
            _produtos.Remove(produtoExistente);
        }
    }
}