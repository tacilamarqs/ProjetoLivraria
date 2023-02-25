using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Models;
using ProjetoLivrariaAPI.Profiles.Maps;
using Autor = ProjetoLivrariaAPI.DomainModels.Autor;
using Livro = ProjetoLivrariaAPI.DomainModels.Livro;

namespace ProjetoLivrariaAPI.Profiles
{
    public class Profile : AutoMapper.Profile
    {
        public Profile()
        {
            CreateMap<Models.Livro, Livro>()
                .ReverseMap();

            CreateMap<Models.Autor, Autor>()
                .ReverseMap();

            CreateMap<AtualizarLivroRequisicao, Models.Livro>()
                .AfterMap<AtualizarLivroMap>();

            CreateMap<CriaLivroRequisicao, Models.Livro>()
                .AfterMap<CriaLivroMap>();
                            
        }
    }
}
