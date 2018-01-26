using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Banco_Agencia:Endereco
    {
        public int Banco_AgenciaID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [BancoID]")]
        public int BancoID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(70, ErrorMessage = "[Nome] não pode ter mais de 70 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Codigo]")]
        [StringLength(10, ErrorMessage = "[Codigo] não pode ter mais de 10 caracteres")]
        public string Codigo { get; set; }
        [StringLength(16, ErrorMessage = "[Tel] não pode ter mais de 16 caracteres")]
        public string Tel { get; set; }
        [StringLength(16, ErrorMessage = "[TelCelular] não pode ter mais de 16 caracteres")]
        public string TelCelular { get; set; }
        [StringLength(50, ErrorMessage = "[Gerente] não pode ter mais de 50 caracteres")]
        public string Gerente { get; set; }
        [StringLength(16, ErrorMessage = "[Observacao] não pode ter mais de 16 caracteres")]
        public string Observacao { get; set; }

        public ICollection<Pessoa_Conta> Pessoa_Contas { get; set; }
    }
}
