using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Repository;

namespace ProjetoLivrariaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EditoraController : Controller
    {
        private readonly LivroRepository livroRepository;
        private readonly IMapper mapper;

        public EditoraController(LivroRepository livroRepository, IMapper mapper)
        {
            this.livroRepository = livroRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEditoras()
        {
            var editoraLista = await livroRepository.GetEditoras();

            if (editoraLista == null || !editoraLista.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Editora>>(editoraLista));
        }
    }
}
