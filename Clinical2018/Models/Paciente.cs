using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Paciente
    {
        public int PacienteID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pessoaID]")]
        public int pessoaID { get; set; }
        public int ConvenioID { get; set; }
        [StringLength(20, ErrorMessage = "[RG_Convenio] não pode ter mais de 20 caracteres")]
        public string RG_Convenio { get; set; }
        [StringLength(16, ErrorMessage = "[Obs_Medica] não pode ter mais de 16 caracteres")]
        public string Obs_Medica { get; set; }
        //[StringLength(100, ErrorMessage = "[CTT_NOME] não pode ter mais de 100 caracteres")]
        //public string CTT_NOME { get; set; }
        //[StringLength(20, ErrorMessage = "[CTT_TIPO] não pode ter mais de 20 caracteres")]
        //public string CTT_TIPO { get; set; }
        //[StringLength(16, ErrorMessage = "[CTT_TEL] não pode ter mais de 16 caracteres")]
        //public string CTT_TEL { get; set; }
        //[StringLength(16, ErrorMessage = "[CTT_TEL_CELULAR] não pode ter mais de 16 caracteres")]
        //public string CTT_TEL_CELULAR { get; set; }
        //[StringLength(50, ErrorMessage = "[CTT_EMAIL] não pode ter mais de 50 caracteres")]
        //public string CTT_EMAIL { get; set; }
        //[StringLength(100, ErrorMessage = "[CTT_OBS] não pode ter mais de 100 caracteres")]
        //public string CTT_OBS { get; set; }
        public byte[] Foto { get; set; }
        public DateTime Data_Pri_Cons { get; set; }
        public DateTime Data_Ult_Cons { get; set; }

        public ICollection<Clinica_Paciente> Clinica_Pacientes { get; set; }
        public ICollection<Paciente_Foto> Paciente_Fotos { get; set; }
        public ICollection<Paciente_QSaude> Paciente_QSaudes { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
