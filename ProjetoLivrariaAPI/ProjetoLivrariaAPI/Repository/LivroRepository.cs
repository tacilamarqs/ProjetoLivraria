using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Models;

namespace ProjetoLivrariaAPI.Repository
{
    public interface LivroRepository
    {
        Task<List<Models.Livro>> GetLivros();

        Task<Models.Livro> GetLivro(Guid livroId);

        Task<List<Models.Genero>>GetGeneros();

        Task<List<Models.Autor>> GetAutores();

        Task<List<Models.Editora>> GetEditoras();

        Task<bool> LivroExiste(Guid livroId);

        Task<Models.Livro> AtualizacaoLivro(Guid livroId, Models.Livro requisicao);

        Task<Models.Livro> CriaLivro(Models.Livro requisicao);

        Task<Models.Livro> ExcluirLivro(Guid studentId);
    }
}
