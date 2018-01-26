using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinical2018.Models
{
    public class Paciente_Foto
    {
        public int Paciente_FotoID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [pacienteID]")]
        public int PacienteID { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Titulo]")]
        [StringLength(250, ErrorMessage = "[Titulo] não pode ter mais de 250 caracteres")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Data]")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Arquivo]")]
        [StringLength(250, ErrorMessage = "[Arquivo] não pode ter mais de 250 caracteres")]
        public string Arquivo { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tamanho]")]
        public int Tamanho { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [width]")]
        public int width { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Height]")]
        public int Height { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [ArquivoOriginal]")]
        [StringLength(250, ErrorMessage = "[ArquivoOriginal] não pode ter mais de 250 caracteres")]
        public string ArquivoOriginal { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [FotoCapa]")]
        public bool FotoCapa { get; set; }
    }
}
