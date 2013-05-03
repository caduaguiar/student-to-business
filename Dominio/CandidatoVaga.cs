using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CandidatoVaga : EntidadeBase
    {

        public ICollection<Candidato> Candidatos { get; set; }

        public ICollection<Vaga> Vagas { get; set; }

        [Required(ErrorMessage = "Informe a Data")]
        public DateTime Data { get; set; }
    }
}
