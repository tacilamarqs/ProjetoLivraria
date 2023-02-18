using ProjetoLivrariaAPI.Models;

namespace ProjetoLivrariaAPI.Repository
{
    public interface LivroRepository
    {
        Task<List<Livro>> GetLivros();
    }
}
