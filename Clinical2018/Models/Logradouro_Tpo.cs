using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Logradouro_Tpo
    {

        public int Logradouro_TpoID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tipo]")]
        [StringLength(50, ErrorMessage = "[Tipo] não pode ter mais de 50 caracteres")]
        public string Tipo { get; set; }
    }
}
