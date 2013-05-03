using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Idioma:EntidadeBase
    {
        [Required(ErrorMessage = "Informe o Idioma ")]
        [RegularExpression(@"^[a-zA-Z]$", ErrorMessage = "O Idioma deve possuir apenas letras")]
        public string Lingua { get; set; }

        public enum Leitura
        {
            Basico,
            Intermediario,
            Avancado
        }
        public enum Conversacao
        {
            Basico,
            Intermediario,
            Avancado
        }
        public enum Escrita
        {
            Basico,
            Intermediario,
            Avancado
        }

        public Curriculo Curriculo { get; set; }
    }
}
