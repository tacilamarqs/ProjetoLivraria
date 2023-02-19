using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaAPI.Models;
using ProjetoLivrariaAPI.Repository;

namespace ProjetoLivrariaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        // private static List<Livro> livros = new List<Livro>();
        private readonly LivroRepository livroRepository;
        private readonly IMapper mapper;

        public LivroController (LivroRepository livroRepository, IMapper mapper)
        {
            this.livroRepository = livroRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BuscaTodosLivros()
        {
            var livros = await livroRepository.GetLivros();

            return Ok(mapper.Map<List<Livro>>(livros));
            
        }
    }
}
