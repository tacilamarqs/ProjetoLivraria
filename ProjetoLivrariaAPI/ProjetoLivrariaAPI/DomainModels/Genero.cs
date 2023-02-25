using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.DomainModels
{
    public class Genero
    {
        public Guid GeneroId { get; set; }
        public string GeneroNome { get; set; }
        public string? Descricao { get; set; }
    }
}
