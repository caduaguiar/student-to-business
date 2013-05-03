using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum EstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    public class Candidato : Usuario
    {
        [Required(ErrorMessage = "Informe o CPf")]
        [MaxLength(11, ErrorMessage = "O CPF possui 11 caracteres")]
        [RegularExpression(@"^[0-9]$", ErrorMessage = "CPF deve possuir apenas números")]
        public int Cpf { get; set; }

        
        // qual tipo primitivo para se guavar imagem
        public string Foto { get; set; }

        [Required(ErrorMessage = "Informe seu nacimento")]
        public string Nascimento { get; set; }

        // preciso de uma enumerabol com todos os tipos de estado civils
        // verificar se essa é a maneira correta de implementação
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Informe o Sexo")]
        public bool Sexo { get; set; }


        // Lista e Coleções

        public Curriculo Curriculo { get; set; }

        public CandidatoVaga CandidatoVaga { get; set; }
    }
}
