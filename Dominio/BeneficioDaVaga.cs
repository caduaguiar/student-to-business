using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class BeneficioDaVaga:EntidadeBase
    {
        [Required(ErrorMessage = "Informe os Beneficios da vaga")]
        public string Descricao { get; set; }

        public Vaga Vaga { get; set; }
    }
}
