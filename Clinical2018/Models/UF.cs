using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Clinical2018.Models
{
    public class UF
    {
        public int UFID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF_SGL]")]
        [StringLength(2, ErrorMessage = "[UF_SGL] não pode ter mais de 2 caracteres")]
        public string UF_SGL { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(30, ErrorMessage = "[Nome] não pode ter mais de 30 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [PaisID]")]
        public int PaisID { get; set; }

        public ICollection<Localidade> Localidades { get; set; }

        //public int UFID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF]")]
        //[StringLength(2, ErrorMessage = "[UF] não pode ter mais de 2 caracteres")]
        //public string UF_SGL { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        //[StringLength(40, ErrorMessage = "[Nome] não pode ter mais de 40 caracteres")]
        //public string Nome { get; set; }
        //[StringLength(1, ErrorMessage = "[Nacional] não pode ter mais de 1 caracteres")]
        //public string Nacional { get; set; }
        //[StringLength(4, ErrorMessage = "[CodigoSINIEF] não pode ter mais de 4 caracteres")]
        //public string CodigoSINIEF { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [paisID]")]
        //public int PaisID { get; set; }
        //public ICollection<Municipio> Municipios { get; set; }
        //public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
