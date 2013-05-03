using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public enum Status
    {
        Cursando,
        Concluido,
        Trancado
    }

    public class Instituicao:EntidadeBase
    {
        [Required(ErrorMessage = "Informe o Nome da isntituição")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Nome da instituição deve possuir apenas letras")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Informe um Status do curso")]
        public Status Status { get; set; }
        
        [Required(ErrorMessage = "Informe a Data Inicio do curso")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Informe a Data Termino do curso")]
        public DateTime DataTermino { get; set; }

        // posso coloar alguma validação para este campo?
        public string Curso { get; set; }

        [Required(ErrorMessage = "Informe o Nivel de Graduação")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Nivel de graduação  deve possuir apenas letras")]
        public string NivelDeGraduacao  { get; set; }
    }
}
