using BeautyClub2026App.Data;
using BeautyClub2026App.Services;

namespace BeautyClub2026App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddTransient<IProdutoService, Services.Data.ProdutoService>();
            // builder.Services.AddSingleton<IProdutoService, Services.Memory.ProdutoService>();

            builder.Services.AddDbContext<BeautyClubDbContext>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages().WithStaticAssets();

            app.Run();
        }
    }
}