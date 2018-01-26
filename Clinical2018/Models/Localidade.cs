using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Clinical2018.Models
{
    public class Localidade
    {
        public int LocalidadeID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(80, ErrorMessage = "[Nome] não pode ter mais de 80 caracteres")]
        public string Nome { get; set; }
        [StringLength(8, ErrorMessage = "[CEP] não pode ter mais de 8 caracteres")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF_SGL]")]
        [StringLength(50, ErrorMessage = "[UF_SGL] não pode ter mais de 50 caracteres")]
        public string UF_SGL { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UFID]")]
        public int UFID { get; set; }

        public ICollection<Bairro> Bairros { get; set; }

        //public int MunicipioID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [ufID]")]
        //public int UFID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [NOME]")]
        //[StringLength(70, ErrorMessage = "[NOME] não pode ter mais de 70 caracteres")]
        //public string Nome { get; set; }
        //[StringLength(2, ErrorMessage = "[UF] não pode ter mais de 2 caracteres")]
        //public string UF_SGL { get; set; }
        //public ICollection<Bairro> Bairros { get; set; }
        //public ICollection<CEP> Ceps { get; set; }
        //public virtual ICollection<Pessoa> Pessoas { get; set; }
        //public virtual ICollection<Clinica> Clinica { get; set; }
    }
}
