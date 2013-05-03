using System.ComponentModel.DataAnnotations;

namespace Dominio
{
   public class Requisitos:EntidadeBase
    {
       [Required(ErrorMessage = "Infome a Descrição dos Requisitos da vaga")]
       public string Descricao { get; set; }

       public Vaga Vaga { get; set; }
    }
}
