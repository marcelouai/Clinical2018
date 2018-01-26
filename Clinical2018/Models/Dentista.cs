using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Dentista
    {
        public int DentistaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pessoaID]")]
        public int PessoaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [CRO]")]
        [StringLength(10, ErrorMessage = "[CRO] não pode ter mais de 10 caracteres")]
        public string CRO { get; set; }
        public DateTime Data_CFO { get; set; }
        public DateTime Data_CRO { get; set; }
        [StringLength(50, ErrorMessage = "[Especialidades] não pode ter mais de 50 caracteres")]
        public string Especialidades { get; set; }

        public ICollection<Clinica_Dentista> Clinica_Dentistas { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
