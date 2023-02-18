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

       
    }
}
