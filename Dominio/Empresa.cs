using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Empresa:Usuario
    {
        [Required(ErrorMessage = "Informe um CNPJ")]
        [RegularExpression(@"^[0-9]$", ErrorMessage = "CNPJ deve possuir apenas números")]
        public int Cnpj { get; set; }

        [Required(ErrorMessage = "Informe o porte da empresa")]
        [RegularExpression(@"^[0-3]$", ErrorMessage = "Porte deve possuir números de 1 a 3 ")]
        public int Porte { get; set; }

        [Required(ErrorMessage = "Informe o ramo da atividade da empresa")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Ramo de atividade de possuir apenas letras")]
        [MaxLength(25,ErrorMessage = "Ramo de atividade de possuir no máximo 25 ")]
        public string RamoDeAtividade { get; set; }

        public Vaga Vagas { get; set; } 
    }
}
