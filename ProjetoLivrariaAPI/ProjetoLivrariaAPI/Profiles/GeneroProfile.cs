using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;

namespace ProjetoLivrariaAPI.Profiles
{
    public class GeneroProfile : Profile
    {
        public GeneroProfile()
        {
            CreateMap<Models.Genero, Genero>()
                .ReverseMap();
        }
    }
}
