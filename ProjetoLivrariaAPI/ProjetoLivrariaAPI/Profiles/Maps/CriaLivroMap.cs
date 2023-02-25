using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;

namespace ProjetoLivrariaAPI.Profiles.Maps
{
    public class CriaLivroMap : IMappingAction<CriaLivroRequisicao, Models.Livro>
    {

        public void Process(CriaLivroRequisicao source, Models.Livro destination, ResolutionContext context)
        {
            destination.Id = Guid.NewGuid();
            destination.Autor = new Models.Autor()
            {
                AutorId = Guid.NewGuid(),
                AutorNome = source.AutorNome
            };
        }
    }
}
