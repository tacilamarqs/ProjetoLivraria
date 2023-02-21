using ProjetoLivrariaAPI.Data;
using ProjetoLivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoLivrariaAPI.Repository
{
    public class SqlLivroRepository : LivroRepository
    {
        private readonly DataContext context;
        public SqlLivroRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Livro>> GetLivros()
        {
            return await context.Livro.Include(nameof(Genero)).Include(nameof(Editora)).Include(nameof(Autor)).ToListAsync();
        }

        public async Task<Livro> GetLivro(Guid livroId)
        {
            return await context.Livro
                .Include(nameof(Genero)).Include(nameof(Editora)).Include(nameof(Autor))
                .FirstOrDefaultAsync(x => x.Id == livroId);
        }

        public async Task<List<Genero>> GetGeneros()
        {
            return await context.Genero.ToListAsync();
        }

        public async Task<List<Autor>> GetAutores()
        {
            return await context.Autor.ToListAsync();
        }

        public async Task<List<Editora>> GetEditoras()
        {
            return await context.Editora.ToListAsync();
        }
    }
}
