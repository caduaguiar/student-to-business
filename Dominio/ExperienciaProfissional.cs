using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class ExperienciaProfissional:EntidadeBase
    {
        [Required(ErrorMessage = "Informe o Cargo")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "O Cargo deve possuir apenas letras")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Informe o Nome da Empresa")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "O Cargo deve possuir apenas letras")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Informe a Data de inicio na empresa")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Informe a Data de termino na empresa")]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "Informe a Descrição das atividades exercidas")]
        public string Descricao { get; set; }

        public Curriculo Curriculo { get; set; }

    }
}
