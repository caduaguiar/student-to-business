using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class EntidadeBase
    {
        // utilizando DATA Annotations para validação dos campso
        [Key]
        public int Id { get; set; }
    }
}
