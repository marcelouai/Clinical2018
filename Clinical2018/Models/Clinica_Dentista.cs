using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Clinica_Dentista
    {
        public int Clinica_DentistaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [dentistaID]")]
        public int DentistaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [clinicaID]")]
        public int ClinicaID { get; set; }

        public ICollection<Dentista> Detistas { get; set; }
    }
}
