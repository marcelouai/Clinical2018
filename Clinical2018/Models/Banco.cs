using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Banco
    {
        public int BancoID { get; set; }
        [StringLength(10, ErrorMessage = "[CodBacen] não pode ter mais de 10 caracteres")]
        public string CodBacen { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(70, ErrorMessage = "[Nome] não pode ter mais de 70 caracteres")]
        public string Nome { get; set; }
        [StringLength(25, ErrorMessage = "[Sigla] não pode ter mais de 25 caracteres")]
        public string Sigla { get; set; }
        [StringLength(15, ErrorMessage = "[Tipo] não pode ter mais de 15 caracteres")]
        public string Tipo { get; set; }
        [StringLength(50, ErrorMessage = "[Website] não pode ter mais de 50 caracteres")]
        public string Website { get; set; }

        public ICollection<Banco_Agencia> Banco_Agencias { get; set; }

        public Banco()
        {
            Tipo = "Conta Corrente";
        }
    }
}
