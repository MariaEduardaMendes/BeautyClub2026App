namespace BeautyClub2026App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ========================================================
            // FASE 1: Adicionar serviços ao contêiner (builder.Services)
            // ========================================================

            // Adiciona o suporte a Razor Pages
            builder.Services.AddRazorPages();

            // Registra o ProdutoService como um Singleton
            builder.Services.AddSingleton<BeautyClub2026App.Services.ProdutoService>();

            // ========================================================
            // CONSTRUÇÃO DA APLICAÇÃO (Chamado apenas UMA VEZ)
            // ========================================================
            var app = builder.Build();

            // ========================================================
            // FASE 2: Configurar o pipeline HTTP (app.Use...)
            // ========================================================

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}