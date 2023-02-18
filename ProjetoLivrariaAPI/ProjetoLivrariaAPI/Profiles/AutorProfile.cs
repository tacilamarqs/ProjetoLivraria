using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;

namespace ProjetoLivrariaAPI.Profiles
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            CreateMap<Models.Autor, Autor>()
                .ReverseMap();
        }
    }
}
