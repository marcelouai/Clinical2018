using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Clinica_Paciente
    {
        public int Clinica_PacienteID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pacienteID]")]
        public int PacienteID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [clinicaID]")]
        public int ClinicaID { get; set; }

    }
}
