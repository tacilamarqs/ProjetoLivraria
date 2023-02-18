using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.Models
{
    public class Autor
    {
        public Guid AutorId { get; set; }
        [Required(ErrorMessage = "O autor é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O nome do autor não pode ter mais de 50 caracteres")]
        public string AutorNome { get; set; }


    }
}
