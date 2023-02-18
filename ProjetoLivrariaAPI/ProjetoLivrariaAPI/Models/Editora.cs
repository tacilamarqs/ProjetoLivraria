using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.Models
{
    public class Editora
    {
        public Guid EditoraId { get; set; }
        [Required(ErrorMessage = "A editora é obrigatória!")]
        [MaxLength(150, ErrorMessage = " O tamanho do nome da editora não pode ter mais de 150 caracteres")]
        public string EditoraNome { get; set; }
    }
}
