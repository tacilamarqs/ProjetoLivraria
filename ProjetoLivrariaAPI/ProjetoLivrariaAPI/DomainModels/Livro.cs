using ProjetoLivrariaAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjetoLivrariaAPI.DomainModels
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Resumo { get; set; }

        public int NumeroDePaginas { get; set; }
        public DateTime? DataDePublicacao { get; set; }

        public string Editora { get; set; }
        public string Genero { get; set; }
        public int Edicao { get; set; }
        public string Colecao { get; set; }
        public string? UrlFotoCapa { get; set; }
        public double Valor { get; set; }

        public Autor Autor { get; set; }
        public Guid AutorId { get; set; }

    }
}
