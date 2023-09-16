using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MeuRazorApp.Pages {
    public class Categories : PageModel {
        public List<Categoria> Categorias { get; set; } = new();

        public async Task OnGet(int skip = 0, int take = 25) {
            await Task.Delay(1000);

            var temp = new List<Categoria>();

            for (var i = 0; i <= 100; i++) {
                temp.Add(new Categoria(i, $"Categoria {i}", i * 29));
            }

            Categorias = temp.Skip(skip).Take(take).ToList();
        }
    }

    public record Categoria(int Id, string Titulo, decimal Preco);
}
