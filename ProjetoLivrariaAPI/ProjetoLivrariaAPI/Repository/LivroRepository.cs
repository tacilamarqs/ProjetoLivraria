using ProjetoLivrariaAPI.Models;

namespace ProjetoLivrariaAPI.Repository
{
    public interface LivroRepository
    {
        Task<List<Livro>> GetLivros();

        Task<Livro> GetLivro(Guid livroId);

        Task<List<Genero>>GetGeneros();

        Task<List<Autor>> GetAutores();

        Task<List<Editora>> GetEditoras();
    }
}
