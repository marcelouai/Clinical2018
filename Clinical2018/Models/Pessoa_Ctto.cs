using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Pessoa_Ctto
    {
        public int Pessoa_CttoID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pessoaID]")]
        public int PessoaID { get; set; }
        [StringLength(100, ErrorMessage = "[Nome] não pode ter mais de 100 caracteres")]
        public string Nome { get; set; }
        [StringLength(20, ErrorMessage = "[Tipo] não pode ter mais de 20 caracteres")]
        public string Tipo { get; set; }
        [StringLength(16, ErrorMessage = "[Tel] não pode ter mais de 16 caracteres")]
        public string Tel { get; set; }
        [StringLength(16, ErrorMessage = "[Tel_Cel] não pode ter mais de 16 caracteres")]
        public string Tel_Cel { get; set; }
        [StringLength(50, ErrorMessage = "[EMail] não pode ter mais de 50 caracteres")]
        public string EMail { get; set; }
        [StringLength(100, ErrorMessage = "[Obs] não pode ter mais de 100 caracteres")]
        public string Obs { get; set; }
    }
}
