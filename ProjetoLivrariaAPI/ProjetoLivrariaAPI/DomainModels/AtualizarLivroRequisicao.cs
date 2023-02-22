namespace ProjetoLivrariaAPI.DomainModels
{
    public class AtualizarLivroRequisicao
    {

        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public string Resumo { get; set; }
        public int NumeroDePaginas { get; set; }
        public string DataDePublicacao { get; set; }
        public int Edicao { get; set; }
        public string Colecao { get; set; }
        public string UrlFotoCapa { get; set; }
        public double Valor { get; set; }
        public Guid GeneroId { get; set; }
        public Guid AutorId { get; set; }
        public Guid EditoraId { get; set; }
        public string? GeneroNome { get; set; }
        public string? Descricao { get; set; }
        public string? AutorNome { get; set; }
        public string? EditoraNome { get; set; }

    }
}
