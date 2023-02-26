namespace ProjetoLivrariaAPI.Repository
{
    public interface ImagemRepository
    {
        Task<string> Upar(IFormFile arquivo, string arquivoNome);
    }
}
