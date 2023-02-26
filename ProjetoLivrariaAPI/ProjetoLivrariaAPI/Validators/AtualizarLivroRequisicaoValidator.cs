using FluentValidation;
using ProjetoLivrariaAPI.DomainModels;
using ProjetoLivrariaAPI.Repository;

namespace ProjetoLivrariaAPI.Validators
{
    public class AtualizarLivroRequisicaoValidator : AbstractValidator<AtualizarLivroRequisicao>
    {
        public AtualizarLivroRequisicaoValidator(LivroRepository livroRepository)
        {
            RuleFor(x => x.Titulo).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Subtitulo).MaximumLength(100);
            RuleFor(x => x.Resumo).MaximumLength(500);
            RuleFor(x => x.NumeroDePaginas).NotEmpty().LessThanOrEqualTo(10000);
            RuleFor(x => x.DataDePublicacao).NotEmpty();
            RuleFor(x => x.Editora).NotEmpty().MaximumLength(150);
            RuleFor(x => x.Edicao).LessThan(21);
            RuleFor(x => x.Genero).NotEmpty();
            RuleFor(x => x.AutorNome).MaximumLength(50);
        }
    }
}
