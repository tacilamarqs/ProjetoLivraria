using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O título é obrigatório!")]
        [MaxLength(100, ErrorMessage = " O tamanho do título não pode ter mais de 100 caracteres")]
        public string Titulo { get; set; }
        [MaxLength(100, ErrorMessage = " O tamanho do subtítulo não pode ter mais de 100 caracteres")]
        public string Subtitulo { get; set; }
        [MaxLength(500, ErrorMessage = " O tamanho do resumo não pode ter mais de 500 caracteres")]
        public string Resumo { get; set; }

        [Required(ErrorMessage = "O número de páginas é obrigatório!")]
        [Range(1, 10000, ErrorMessage = "O livro deve ter entre 1 e 10.000 páginas!")]
        public int NumeroDePaginas { get; set; }
        [Required(ErrorMessage = "A data de publicação é obrigatória!")]
        public DateTime DataDePublicacao { get; set; }
        
        
        [Range(1, 20, ErrorMessage = "O livro só pode ter até 20 edições!")]
        public int Edicao { get; set; }
        public string Colecao { get; set; }
        public string UrlFotoCapa { get; set; }
        [Required(ErrorMessage = "O valor é obrigatório!")]
        public double Valor { get; set; }

        public Guid GeneroId { get; set; }
        public Guid AutorId { get; set; }
        public Guid EditoraId { get; set; }

       
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        
        public Genero Genero { get; set; }
    }
}
