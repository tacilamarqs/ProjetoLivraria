using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;


namespace ProjetoLivrariaAPI.Profiles.Maps
{
    public class AtualizarLivroMap : IMappingAction<AtualizarLivroRequisicao, Models.Livro>
    {
        public void Process(AtualizarLivroRequisicao source, Models.Livro destination, ResolutionContext context)
        {
            destination.Autor = new Models.Autor()
            {
                AutorNome = source.AutorNome,

            };

            destination.Editora = new Models.Editora()
            {
                EditoraNome = source.EditoraNome,
            };

            destination.Genero = new Models.Genero()
            {
                GeneroNome = source.GeneroNome,
                Descricao = source.Descricao,
            };
        }
    }
}
