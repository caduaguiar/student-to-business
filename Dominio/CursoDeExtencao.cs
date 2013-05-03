using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
   public class CursoDeExtencao:EntidadeBase
    {
       [Required(ErrorMessage = "Informe o Nome do Curso de extenção realizado")]
       [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Nome do curso deve possuir apenas letras")]
       public string Nome { get; set; }

       [Required(ErrorMessage = "Informe o Nome da instituição de ensino")]
       [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Nome do instituição deve possuir apenas letras")]
       public string NomeDaInstituição { get; set; }

       
       [Required(ErrorMessage = "Informe a duração do curso em horas")]
       [RegularExpression(@"^[0-9]$", ErrorMessage = "A Duração do Curso deve ser em horas")]
       public int Duracao { get; set; }

       public string Descricao { get; set; }

       [Required(ErrorMessage = "Informe a Data Inicio do curso")]
       public DateTime DataInicio { get; set; }

       [Required(ErrorMessage = "Informe a Data Termino do curso")]
       public DateTime DataTermino { get; set; }

       public Curriculo Curriculo { get; set; }

    }
}
