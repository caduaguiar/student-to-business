using System.ComponentModel.DataAnnotations;

namespace Dominio
{
   public class Usuario:EntidadeBase
    {
       [Required(ErrorMessage = "Informe o Nome")]
       [MinLength(5, ErrorMessage = "O Nome deve possuir no mínimo 5 caracteres")]
       [MaxLength(50,ErrorMessage = "O Nome devepossuir no máximo 50 caracteres")]
       public string Nome { get; set; }

       [Required(ErrorMessage = "Informe um Login")]
       [MinLength(3,ErrorMessage = "Login deve possuir no mínimo 3 caracteres")]
       [MaxLength(15,ErrorMessage = "Login deve possuir no máximo 15 caracteres")]
       [RegularExpression(@"^[a-zA-Z0-9]$", ErrorMessage = "Login deve possuir apenas letras e numeros")]
       public string Login { get; set; }

       [Required(ErrorMessage = "Informe uma senha")]
       [MinLength(3, ErrorMessage = "Senha deve possuir no mínimo 3 caracteres")]
       [MaxLength(15, ErrorMessage = "Senha deve possuir no máximo 15 caracteres")]
       [DataType(DataType.Password)]
       public string Senha { get; set; }

       [Required(ErrorMessage = "Confirme a senha")]
       [DataType(DataType.Password)]
       [Compare("Senha",ErrorMessage = "As senhas não conferem")]
       public string ConfirmaSenha { get; set; }

       [Required(ErrorMessage = "Informe um Email")]
       // expressao regular de email pesquisar....
       public string Email { get; set; }

       // expressao regular de site
       public string Site { get; set; }

       // expressao regular twitter
       public string Twitter { get; set; }
       
       // expressao regular de facebook
       public string Facebook { get; set; }

       [Required(ErrorMessage = "Por favor informe um telefone")]
       [RegularExpression(@"^[0-9]$", ErrorMessage = "Telefone deve possuir apenas números")]
       public string Telefone { get; set; }

       [Required(ErrorMessage = "Informe o Endereço")]
       public Endereco  Enderecos { get; set; }
    }
}
