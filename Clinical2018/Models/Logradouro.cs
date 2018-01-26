using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Clinical2018.Models
{
    public enum TipoLogradouro
    {
        aeroporto, alameda, área, avenida, campo, chácara, colônia, condomínio, conjunto, distrito, esplanada, estação, estrada, favela, fazenda, feira, jardim, ladeira, lago, lagoa, largo, loteamento, morro, núcleo, parque, passarela, pátio, praça, quadra, recanto, residencial, rodovia, rua, setor, sítio, travessa, trecho, trevo, vale, vereda, via, viaduto, viela, vila
    }

    public class Logradouro
    {
        public int LogradouroID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UF_SGL]")]
        [StringLength(50, ErrorMessage = "[UF_SGL] não pode ter mais de 50 caracteres")]
        public string UF_SGL { get; set; }
        public int Logradouro_TpoID { get; set; }
        [StringLength(50, ErrorMessage = "[Tipo] não pode ter mais de 50 caracteres")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(70, ErrorMessage = "[Nome] não pode ter mais de 70 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [NomeASC]")]
        [StringLength(70, ErrorMessage = "[NomeASC] não pode ter mais de 70 caracteres")]
        public string NomeASC { get; set; }
        [StringLength(90, ErrorMessage = "[Complemento] não pode ter mais de 90 caracteres")]
        public string Complemento { get; set; }
        public int BairroID_Fin { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [CEP]")]
        [StringLength(8, ErrorMessage = "[CEP] não pode ter mais de 8 caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [BairroID]")]
        public int BairroID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [LocalidadeID]")]
        public int LocalidadeID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [UFID]")]
        public int UFID { get; set; }
        //public int cepID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [CEP]")]
        //[StringLength(20, ErrorMessage = "[CEP] não pode ter mais de 20 caracteres")]
        //public string NumCEP { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [Logradouro]")]
        //[StringLength(100, ErrorMessage = "[Logradouro] não pode ter mais de 100 caracteres")]
        //public string Logradouro { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [TipoLogradouro]")]
        //[StringLength(50, ErrorMessage = "[TipoLogradouro] não pode ter mais de 50 caracteres")]
        //public string TipoLogradouro { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [municipioID]")]
        //public int municipioID { get; set; }
        //[Required(ErrorMessage = "Campo de preenchimento obrigatório! [bairroID]")]
        //public int bairroID { get; set; }
    }
}
