using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Repository;

namespace ProjetoLivrariaAPI.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class AutorController : Controller
    {
        private readonly LivroRepository livroRepository;
        private readonly IMapper mapper;

        public AutorController(LivroRepository livroRepository, IMapper mapper)
        {
            this.livroRepository = livroRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAutores()
        {
            var autorLista = await livroRepository.GetAutores();

            if (autorLista == null || !autorLista.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Autor>>(autorLista));
        }
    }
}
