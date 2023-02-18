using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.DomainModels
{
    public class Editora
    {
        public Guid EditoraId { get; set; }
        public string EditoraNome { get; set; }
    }
}
