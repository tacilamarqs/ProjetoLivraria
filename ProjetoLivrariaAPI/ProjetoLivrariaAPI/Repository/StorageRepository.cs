namespace ProjetoLivrariaAPI.Repository
{
    public class StorageRepository : ImagemRepository
    {
        public async Task<string> Upar(IFormFile arquivo, string arquivoNome)
        {
            var arquivoPath = Path.Combine(Directory.GetCurrentDirectory(), @"Resources\Imagens", arquivoNome);
            using Stream fileStream = new FileStream(arquivoPath, FileMode.Create);
            await arquivo.CopyToAsync(fileStream);
            return GetServerPath(arquivoNome);
        }

        private string GetServerPath(string arquivoNome)
        {
            return Path.Combine(@"Resources\Imagens", arquivoNome);
        }
    }
}
