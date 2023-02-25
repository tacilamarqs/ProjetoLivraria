using ProjetoLivrariaAPI.Data;
using ProjetoLivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;
using Livro = ProjetoLivrariaAPI.Models.Livro;

namespace ProjetoLivrariaAPI.Repository
{
    public class SqlLivroRepository : LivroRepository
    {
        private readonly DataContext context;
        public SqlLivroRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Models.Livro>> GetLivros()
        {
            return await context.Livro
                .Include(nameof(Autor))
                .ToListAsync();
        }

        public async Task<Models.Livro> GetLivro(Guid livroId)
        {
            return await context.Livro
                .Include(nameof(Autor))
                .FirstOrDefaultAsync(x => x.Id == livroId);
        }


        public async Task<List<Autor>> GetAutores()
        {
            return await context.Autor.ToListAsync();
        }


        public async Task<bool> LivroExiste(Guid livroId)
        {
            return await context.Livro.AnyAsync(x => x.Id == livroId);
        }

        public async Task<Livro> AtualizacaoLivro(Guid livroId, Livro requisicao)
        {
            var livrosExistentes = await GetLivro(livroId);

            if(livrosExistentes != null)
            {
                livrosExistentes.Titulo = requisicao.Titulo;
                livrosExistentes.Subtitulo = requisicao.Subtitulo;
                livrosExistentes.Resumo = requisicao.Resumo;
                livrosExistentes.NumeroDePaginas = requisicao.NumeroDePaginas;
                livrosExistentes.DataDePublicacao = requisicao.DataDePublicacao;
                livrosExistentes.Editora = requisicao.Editora;
                livrosExistentes.Genero = requisicao.Genero;
                livrosExistentes.Edicao = requisicao.Edicao;
                livrosExistentes.Colecao = requisicao.Colecao;
                livrosExistentes.UrlFotoCapa = requisicao.UrlFotoCapa;
                livrosExistentes.Valor = requisicao.Valor;
                livrosExistentes.Autor.AutorNome = requisicao.Autor.AutorNome;

                await context.SaveChangesAsync();
                return livrosExistentes;
            }

            return null;
        }

        public async Task<Livro> DeletarLivro(Guid livroId)
        {
            var livroExiste = await GetLivro(livroId);
            if (livroExiste != null)
            {
                context.Livro.Remove(livroExiste);
                await context.SaveChangesAsync();
                return livroExiste;
            }

            return null;
        }

        public async Task<Livro> CriaLivro(Livro requisicao)
        {
            
            var novoLivro = await context.Livro.AddAsync(requisicao);
            await context.SaveChangesAsync();
            return novoLivro.Entity;
        }
    }
}
