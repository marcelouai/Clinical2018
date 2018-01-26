using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Paciente_QSaude
    {
        public int Paciente_qsaudeID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pacienteID]")]
        public int PacienteID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [qsaudeID]")]
        //public int QsaudeID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Resposta]")]
        //[StringLength(3, ErrorMessage = "[Resposta] não pode ter mais de 3 caracteres")]
        //public string Resposta { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Observacao]")]
        //[StringLength(50, ErrorMessage = "[Observacao] não pode ter mais de 50 caracteres")]
        //public string Observacao { get; set; }
    }
}
