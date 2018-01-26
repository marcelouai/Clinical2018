using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Clinical2018.Models
{
    public class Pais
    {
        public int PaisID { get; set; }
        [StringLength(5, ErrorMessage = "[Codigo] não pode ter mais de 5 caracteres")]
        public string Codigo { get; set; }
        [StringLength(5, ErrorMessage = "[CodPaisC] não pode ter mais de 5 caracteres")]
        public string CodPaisC { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(60, ErrorMessage = "[Nome] não pode ter mais de 60 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [DDI]")]
        [StringLength(5, ErrorMessage = "[DDI] não pode ter mais de 5 caracteres")]
        public string DDI { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Continente]")]
        [StringLength(30, ErrorMessage = "[Continente] não pode ter mais de 30 caracteres")]
        public string Continente { get; set; }

        public ICollection<UF> UFs { get; set; }
    }
}
