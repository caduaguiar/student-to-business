using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Estado:EntidadeBase
    {
        // validação dos dados atrave de DATA ANNOTATIONS

        [Required(ErrorMessage = "Informe a Sigla")]
        [MinLength(2,ErrorMessage = "Digite uma Sigla com no mínimo 2 caracteres")]
        [MaxLength(2, ErrorMessage = "Digite uma Sigla com no máximo 2 caracteres")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Digite somente letras")]
        public string Sigla { get; set; }
        
        [Required(ErrorMessage = "Informe o Nome do Estado")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Digite somente letras")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a Cidade")]
        public ICollection<Cidade> Cidades { get; set; } 
    }
}
