using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;
using Models = ProjetoLivrariaAPI.Models;

namespace ProjetoLivrariaAPI.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Models.Livro, Livro>()
                .ReverseMap();
        }
    }
}
