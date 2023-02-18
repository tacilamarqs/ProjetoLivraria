using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.DomainModels
{
    public class Autor
    {
        public Guid AutorId { get; set; }
        public string AutorNome { get; set; }

    }
}
