using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Convenio
    {
        public int ConvenioID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(50, ErrorMessage = "[Nome] não pode ter mais de 50 caracteres")]
        public string Nome { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
