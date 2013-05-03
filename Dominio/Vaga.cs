using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Vaga:EntidadeBase
    {
        

        [Required(ErrorMessage = "Informe uma Descrição para a vaga")]
        [MinLength(30,ErrorMessage = "A Descrição deve possuir no mínimo 30 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe um Cargo para a vaga")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Informe o Status da vaga")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Informe o Local de Trabalho para a vaga")]
        public string LocalDeTrabalho { get; set; }

        [Required(ErrorMessage = "Informe um Sa")]
        public int Salario { get; set; }

        [Required(ErrorMessage = "Informe o Nivel do Cargo")]
        public string NivelDeCargo { get; set; }

       [Required(ErrorMessage = "Infomre o número de vagas")]
        public int NumeroDeVagas { get; set; }

        
       public int NumeroDeCanditatos { get; set; }

        // NAO SEI SE É A MELHOR FORMA PARA SE FAZER ISSO

        public ICollection<BeneficioDaVaga> BeneficioDaVagas { get; set; }

        public ICollection<Requisitos> Requisitoses { get; set; }

        public ICollection<Empresa> Empresas { get; set; }

        public ICollection<CandidatoVaga> CandidatosVaga { get; set; } 
    }
}
