using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Endereco
    {
        [StringLength(16, ErrorMessage = "[CEP] não pode ter mais de 16 caracteres")]
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }
        [StringLength(10, ErrorMessage = "[Logradouro_Tpo] não pode ter mais de 10 caracteres")]
        [Display(Name = "Tipo Logradouro")]
        public string Logradouro_Tpo { get; set; }
        [StringLength(80, ErrorMessage = "[Logradouro] não pode ter mais de 80 caracteres")]
        public string Logradouro { get; set; }
        [StringLength(50, ErrorMessage = "[Numero] não pode ter mais de 50 caracteres")]
        public string Numero { get; set; }
        [StringLength(50, ErrorMessage = "[Complemento] não pode ter mais de 50 caracteres")]
        public string Complemento { get; set; }
        [StringLength(80, ErrorMessage = "[Bairro] não pode ter mais de 80 caracteres")]
        public string Bairro { get; set; }
        [StringLength(80, ErrorMessage = "[Localidade] não pode ter mais de 80 caracteres")]
        public string Localidade { get; set; }
        [StringLength(2, ErrorMessage = "[UF_SGL] não pode ter mais de 2 caracteres")]
        public string UF_SGL { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [LocalidadeID]")]
        public int LocalidadeID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [LogradouroID]")]
        public int? LogradouroID { get; set; }
        public int? BairroID { get; set; }
        public int? Logradouro_TpoID { get; set; }

        //public Localidade Localidade { get; set; }
    }
}
