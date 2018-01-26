using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class QSaude
    {
        public int QsaudeID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tipo]")]
        [StringLength(3, ErrorMessage = "[Tipo] não pode ter mais de 3 caracteres")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Ordem]")]
        [StringLength(2, ErrorMessage = "[Ordem] não pode ter mais de 2 caracteres")]
        public string Ordem { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Pergunta]")]
        [StringLength(150, ErrorMessage = "[Pergunta] não pode ter mais de 150 caracteres")]
        public string Pergunta { get; set; }
    }
}
