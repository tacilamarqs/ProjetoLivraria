using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Models;
using ProjetoLivrariaAPI.Profiles.Maps;
using Livro = ProjetoLivrariaAPI.DomainModels.Livro;

namespace ProjetoLivrariaAPI.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Models.Livro, Livro>()
                .ReverseMap();

            CreateMap<AtualizarLivroRequisicao, Models.Livro>()
                .AfterMap<AtualizarLivroMap>();

            CreateMap<CriaLivroRequisicao, Models.Livro>()
                .AfterMap<CriaLivroMap>();
                            
        }
    }
}
