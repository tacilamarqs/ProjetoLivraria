using AutoMapper;
using ProjetoLivrariaAPI.DomainModels;

namespace ProjetoLivrariaAPI.Profiles
{
    public class EditoraProfile : Profile
    {
        public EditoraProfile()
        {
            CreateMap<Models.Editora, Editora>()
                .ReverseMap();
        }
    }
}
