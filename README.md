# 💄 BeautyClub 2026 App

> **⚠️ Status do Projeto: Em Desenvolvimento (Work in Progress)** > *Este projeto encontra-se atualmente em fase de construção e aprendizagem. Novas funcionalidades e refatorações estão a ser implementadas.*

O **BeautyClub** é uma aplicação web de comércio eletrónico focada em produtos de beleza e cosmética. Este projeto foi desenvolvido com base numa arquitetura padronizada em ASP.NET Core, focando-se na implementação de um sistema robusto de gestão de produtos (CRUD) utilizando boas práticas de desenvolvimento e injeção de dependências.

---

## ⚙️ Funcionalidades Atuais

- **Catálogo de Produtos:** Visualização dos produtos em formato de cartões na página inicial.
- **Detalhes do Produto:** Página dedicada para visualizar informações completas de um item específico.
- **Gestão de Produtos (CRUD):** - Criação de novos produtos (`Create`).
  - Edição de produtos existentes (`Edit`).
- **Persistência de Dados:** Integração com base de dados real utilizando Entity Framework Core e SQLite.
- **Data Seeding:** População automática da base de dados com 8 produtos iniciais durante a primeira execução.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET 9.0 / ASP.NET Core Razor Pages
- **Base de Dados:** SQLite
- **ORM:** Entity Framework Core 9.0.0
- **Frontend:** HTML5, CSS3 e Bootstrap 5

---

## 🚀 Como Executar o Projeto Localmente

### Pré-requisitos
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) instalado.
- Ferramentas do Entity Framework Core instaladas globalmente (`dotnet tool install --global dotnet-ef`).

### Passos

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/SEU-USUARIO/beautyclub2026app.git](https://github.com/SEU-USUARIO/beautyclub2026app.git)
   cd beautyclub2026app
