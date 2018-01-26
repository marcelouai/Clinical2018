using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Clinica:Endereco
    {
        public int ClinicaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [DentistaID]")]
        public int DentistaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [CNPJ]")]
        [StringLength(14, ErrorMessage = "[CNPJ] não pode ter mais de 14 caracteres")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(50, ErrorMessage = "[Nome] não pode ter mais de 50 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [NomeFantasia]")]
        [StringLength(50, ErrorMessage = "[NomeFantasia] não pode ter mais de 50 caracteres")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [DataAbertura]")]
        public DateTime DataAbertura { get; set; }
        //[StringLength(14, ErrorMessage = "[CEP] não pode ter mais de 14 caracteres")]
        //public string CEP { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Rua]")]
        //[StringLength(100, ErrorMessage = "[Rua] não pode ter mais de 100 caracteres")]
        //public string Rua { get; set; }
        //[StringLength(10, ErrorMessage = "[Numero] não pode ter mais de 10 caracteres")]
        //public string Numero { get; set; }
        //[StringLength(50, ErrorMessage = "[Complemento] não pode ter mais de 50 caracteres")]
        //public string Complemento { get; set; }
        //public int bairroID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [municipioID]")]
        //public int municipioID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [ufID]")]
        //public int ufID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [EMail]")]
        [StringLength(50, ErrorMessage = "[EMail] não pode ter mais de 50 caracteres")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tel]")]
        [StringLength(16, ErrorMessage = "[Tel] não pode ter mais de 16 caracteres")]
        public string Tel { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tel2]")]
        [StringLength(16, ErrorMessage = "[Tel2] não pode ter mais de 16 caracteres")]
        public string Tel2 { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tel_Cel]")]
        [StringLength(16, ErrorMessage = "[Tel_Cel] não pode ter mais de 16 caracteres")]
        public string Tel_Cel { get; set; }
        [StringLength(10, ErrorMessage = "[Tel_Cel_Mess] não pode ter mais de 10 caracteres")]
        public string Tel_Cel_Mess { get; set; }

        //public Dentista Dentista { get; set; }

        public ICollection<Clinica> Clinica_Dentistas { get; set; }
        public ICollection<Clinica_Paciente> Clinica_Pacientes { get; set; }
        public ICollection<Clinica_Conta> Clinica_Contas { get; set; }
    }
}
