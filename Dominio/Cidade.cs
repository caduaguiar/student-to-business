using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Cidade:EntidadeBase
    {
        [Required(ErrorMessage = "O Nome da Cidade é obrigatório")]
        [MinLength(3,ErrorMessage = "O Nome da Cidade deve possuir no mínimo 3 letras")]
        [MaxLength(60,ErrorMessage = "O Nome da Cidade não pode haver mais do que 60 caracteres")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Digite somente letras")]
        public string Nome { get; set; }

        public Estado Estado { get; set; }

    }
}
