using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pessoaID]")]
        public int PessoaID { get; set; }
        public Pessoa Pessoa { get; set; }

    }
}
