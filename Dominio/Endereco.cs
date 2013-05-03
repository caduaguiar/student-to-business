using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Endereco : EntidadeBase
    {
        [Required(ErrorMessage = "Informe o nome da rua")]
        [MaxLength(40, ErrorMessage = "Nome da rua não pode ser maior do que 40 caracteres")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Digite somente letras")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Informe o Número")]
        [RegularExpression(@"^[0-9]$", ErrorMessage = "Digite somente letras")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe o nome do bairro")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "Digite somente letras")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe o complemento")]
        public string Complemento { get; set; }

        // qual data Annotation devo usar?
        public ICollection<Usuario> Usuarios { get; set; }
    }
}

    
