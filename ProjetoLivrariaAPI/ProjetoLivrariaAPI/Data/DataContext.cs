using Microsoft.EntityFrameworkCore;
using ProjetoLivrariaAPI.Models;

namespace ProjetoLivrariaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Livro> Livro { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Editora> Editora { get; set; }

    }
}
