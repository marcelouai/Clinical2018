using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Clinica_Conta
    {
        public int Clinica_ContaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Banco_AgenciaID]")]
        public int Banco_AgenciaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Descricao]")]
        [StringLength(50, ErrorMessage = "[Descricao] não pode ter mais de 50 caracteres")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [DataInicial]")]
        public DateTime DataInicial { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [SaldoInicial]")]
        public float SaldoInicial { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Ativa]")]
        public bool Ativa { get; set; }
    }
}
