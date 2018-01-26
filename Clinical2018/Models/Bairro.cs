using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Bairro
    {
        public int BairroID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF_SGL]")]
        [StringLength(2, ErrorMessage = "[UF_SGL] não pode ter mais de 2 caracteres")]
        public string UF_SGL { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(80, ErrorMessage = "[Nome] não pode ter mais de 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [LocalidadeID]")]
        public int LocalidadeID { get; set; }

        public ICollection<Logradouro> Logradouros { get; set; }

        //public int BairroID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF_SGL]")]
        //[StringLength(4, ErrorMessage = "[UF_SGL] não pode ter mais de 4 caracteres")]
        //public string UF_SGL { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        //[StringLength(150, ErrorMessage = "[Nome] não pode ter mais de 144 caracteres")]
        //public string Nome { get; set; }
        //[StringLength(80, ErrorMessage = "[NomeAbrev] não pode ter mais de 72 caracteres")]
        //public string NomeAbrev { get; set; }


        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [LocalidadeID]")]
        //public int LocalidadeID { get; set; }

        //public ICollection<Pessoa> Pessoas { get; set; }
    }
}
