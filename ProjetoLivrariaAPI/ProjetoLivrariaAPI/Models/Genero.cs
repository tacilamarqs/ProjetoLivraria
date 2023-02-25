using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.Models
{
    public class Genero
    {
        public Guid GeneroId { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório!")]
        public string GeneroNome { get; set; }
        public string? Descricao { get; set; }

    }
}
