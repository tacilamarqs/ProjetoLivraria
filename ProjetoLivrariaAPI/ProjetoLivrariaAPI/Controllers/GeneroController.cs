using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Repository;

namespace ProjetoLivrariaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeneroController : Controller
    {
        private readonly LivroRepository livroRepository;
        private readonly IMapper mapper;

        public GeneroController(LivroRepository livroRepository, IMapper mapper)
        {
            this.livroRepository = livroRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGeneros()
        {
            var generoLista = await livroRepository.GetGeneros(); 

            if(generoLista == null || !generoLista.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Genero>>(generoLista));
        }
    }
}
