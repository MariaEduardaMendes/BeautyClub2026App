using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeautyClub2026App.Migrations
{
    /// <inheritdoc />
    public partial class InitialWithSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ImagemUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    EntregaExpressa = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "DataCadastro", "Descricao", "EntregaExpressa", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 6, 9, 28, 59, 254, DateTimeKind.Local).AddTicks(391), "Sérum antioxidante de alta potência que ilumina, uniformiza o tom da pele e reduz linhas finas.", true, "https://images.unsplash.com/photo-1620916566398-39f1143ab7be?w=500&h=500&fit=crop&q=80", "Sérum Facial Vitamina C 15%", 149.90000000000001 },
                    { 2, new DateTime(2026, 4, 21, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4442), "Hidratação profunda com ácido hialurônico e ceramidas para restaurar a barreira da pele durante o sono.", false, "https://images.unsplash.com/photo-1629198688000-71f23e745b6e?w=500&h=500&fit=crop&q=80", "Creme Hidratante Noturno Reparador", 129.5 },
                    { 3, new DateTime(2026, 5, 11, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4458), "Alta proteção UVA/UVB com textura invisível e controle de oleosidade por até 12 horas.", true, "https://images.unsplash.com/photo-1556228578-0d85b1a4d571?w=500&h=500&fit=crop&q=80", "Protetor Solar FPS 50 Toque Seco", 89.900000000000006 },
                    { 4, new DateTime(2026, 5, 16, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4460), "Cobertura média a alta, vegana e de longa duração. Não craquela e resiste ao suor.", true, "https://images.unsplash.com/photo-1599305090598-fe179d501227?w=500&h=500&fit=crop&q=80", "Base Líquida Matte Acabamento Natural", 115.0 },
                    { 5, new DateTime(2026, 4, 6, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4462), "Fórmula enriquecida com óleo de rícino para cílios mais volumosos, longos e saudáveis.", false, "https://images.unsplash.com/photo-1631214500115-598fc2cb8d2d?w=500&h=500&fit=crop&q=80", "Máscara de Cílios Volume Extremo", 65.900000000000006 },
                    { 6, new DateTime(2026, 5, 19, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4463), "Cor intensa com acabamento acetinado. Enriquecido com manteiga de karité.", true, "https://images.unsplash.com/photo-1586495777744-4413f21062fa?w=500&h=500&fit=crop&q=80", "Batom Hidratante Vermelho Clássico", 54.899999999999999 },
                    { 7, new DateTime(2026, 5, 1, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4465), "Equilibra o pH da pele, acalma vermelhidões e prepara o rosto para a hidratação. Sem álcool.", false, "https://images.unsplash.com/photo-1608248543803-ba4f8c70ae0b?w=500&h=500&fit=crop&q=80", "Tônico Facial Calmante de Camomila", 72.0 },
                    { 8, new DateTime(2026, 5, 13, 9, 28, 59, 255, DateTimeKind.Local).AddTicks(4466), "Reduz o frizz, sela as pontas duplas e proporciona brilho intenso sem pesar os fios.", true, "https://images.unsplash.com/photo-1526947425960-945c6e72858f?w=500&h=500&fit=crop&q=80", "Óleo Capilar Nutritivo Argan & Ojon", 85.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
