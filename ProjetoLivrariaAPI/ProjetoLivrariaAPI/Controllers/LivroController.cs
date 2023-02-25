using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Models;
using ProjetoLivrariaAPI.Repository;
using Livro = ProjetoLivrariaAPI.DomainModels.Livro;

namespace ProjetoLivrariaAPI.Controllers
{
    
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
        [Route("[controller]")]

        public async Task<IActionResult> BuscaTodosLivros()
        {
            var livros = await livroRepository.GetLivros();

            return Ok(mapper.Map<List<Livro>>(livros));
            
        }

        [HttpGet]
        [Route("[controller]/{livroId:guid}")]
        public async Task<IActionResult> BuscaLivroId([FromRoute] Guid livroId)
        {
            var livro = await livroRepository.GetLivro(livroId);

            if(livro == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<Livro>(livro));
        }

        [HttpPut]
        [Route("editar/{livroId:guid}")]
        public async Task<IActionResult> AtualizarLivro([FromRoute] Guid livroId, [FromBody] AtualizarLivroRequisicao requisicao)
        {
            if(await livroRepository.LivroExiste(livroId))
            {
                Console.WriteLine(livroId);
                var livroAtualizado = await livroRepository.AtualizacaoLivro(livroId, mapper.Map<Models.Livro>(requisicao));
            
                if(livroAtualizado != null)
                {
                    return Ok(mapper.Map<Livro>(livroAtualizado));
                }
            }
            return NotFound();
            
        }

        [HttpDelete]
        [Route("deletar/{livroId:guid}")]

        public async Task<IActionResult> ExcluirLivro([FromRoute] Guid livroId)
        {
           if(await livroRepository.LivroExiste(livroId))
            {
                var livroDeletado = await livroRepository.DeletarLivro(livroId);
                return Ok(mapper.Map<Livro>(livroDeletado));
            }
            return NotFound();
        }

        [HttpPost]
        [Route("criar")]

        public async Task<IActionResult> CriarLivro([FromBody] CriaLivroRequisicao requisicao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var livro = await livroRepository.CriaLivro(mapper.Map<Models.Livro>(requisicao));

            return CreatedAtAction(nameof(BuscaLivroId),
                new {livroId = livro.Id},
                mapper.Map<Livro>(livro));

        }

    }
}
