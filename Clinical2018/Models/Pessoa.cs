using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Clinical2018.Models
{
    public enum TipoEstadoCivil
    {
        [DescriptionAttribute("Solteiro(a)")] Solteiro = 1,
        [DescriptionAttribute("Casado(a)")] Casado = 2,
        [DescriptionAttribute("Viúvo(a)")] Viúvo = 3,
        [DescriptionAttribute("Separado(a)")] Separado = 4,
        [DescriptionAttribute("Divorciado(a)")] Divorciado = 5,
        [DescriptionAttribute("Desquitado(a)")] Desquitado = 6,
        [DescriptionAttribute("Outro")] Outro = 7
    }
    public enum TipoPessoa
    {
        [DescriptionAttribute("Fisica")] Fisica = 1,
        [DescriptionAttribute("Juridica")] Juridica = 2
    }
    public enum TipoSexo
    {
        [DescriptionAttribute("Masculino")] Masculino = 1,
        [DescriptionAttribute("Feminino")] Feminino = 2
    }
    public enum TipoAppMensagem
    {
        [DescriptionAttribute("Não Tem")] NT = 0,
        [DescriptionAttribute("WhatsApp")] WhatsApp = 1,
        [DescriptionAttribute("Telegram")] Telegram = 2,
        [DescriptionAttribute("Skype")] Skype = 3
    }

    public class Pessoa:Endereco
    {

        public int PessoaID { get; set; }


        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tpo_Pessoa]")]
        //[StringLength(50, ErrorMessage = "[Tpo_Pessoa] não pode ter mais de 50 caracteres")]
        [Display(Name = "Tipo")]
        [EnumDataType(typeof(TipoPessoa))]
        public TipoPessoa Tpo_Pessoa { get; set; }

        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Nome]")]
        [StringLength(70, ErrorMessage = "[Nome] não pode ter mais de 70 caracteres")]
        public string Nome { get; set; }
        [StringLength(70, ErrorMessage = "[NomeFantasia] não pode ter mais de 70 caracteres")]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [CPF_CNPJ]")]
        [StringLength(50, ErrorMessage = "[CPF_CNPJ] não pode ter mais de 50 caracteres")]
        [Display(Name = "CPF/CNPJ")]
        public string CPF_CNPJ { get; set; }
        [StringLength(50, ErrorMessage = "[RG] não pode ter mais de 50 caracteres")]
        public string RG { get; set; }
        [StringLength(50, ErrorMessage = "[RG_Emiss] não pode ter mais de 50 caracteres")]
        [Display(Name = "Emissor")]
        public string RG_Emiss { get; set; }
        [StringLength(50, ErrorMessage = "[Naturalidade] não pode ter mais de 50 caracteres")]
        public string Naturalidade { get; set; }
        [StringLength(50, ErrorMessage = "[Nacionalidade] não pode ter mais de 50 caracteres")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Estado Civil")]
        [EnumDataType(typeof(TipoEstadoCivil))]
        public TipoEstadoCivil? EstadoCivil { get; set; }
        [EnumDataType(typeof(TipoSexo))]
        public TipoSexo? Sexo { get; set; }


        [Display(Name = "Data Alteração")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Data_Alt]")]
        public DateTime Data_Alt { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Data_Cad]")]
        [Display(Name = "Data Cadastro")]
        [DataType(DataType.Date)]
        public DateTime Data_Cad { get; set; }
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? Data_Nasc { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [EMail]")]
        [StringLength(50, ErrorMessage = "[EMail] não pode ter mais de 50 caracteres")]
        [EmailAddress]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Campo de preenchimento obrigatório! [Tel]")]
        //[StringLength(50, ErrorMessage = "[Tel] não pode ter mais de 50 caracteres")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?\d{2}\)?[\s-]?\d{4}-?\d{4}$", ErrorMessage = "Você deve digitar um telefone no formato (##) ####-####")]
        public string Tel { get; set; }
        //[StringLength(50, ErrorMessage = "[Tel_Cel] não pode ter mais de 50 caracteres")]
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?\d{2}\)?[\s-]?\d{4}-?\d{4}$", ErrorMessage = "Você deve digitar um telefone no formato (##) ####-####")]
        public string Tel_Cel { get; set; }
        //[StringLength(50, ErrorMessage = "[Tel_Cel_Mess] não pode ter mais de 50 caracteres")]
        [EnumDataType(typeof(TipoAppMensagem))]
        [Display(Name = "Mensagem")]
        public TipoAppMensagem? Tel_Cel_Mess { get; set; }
        //[StringLength(50, ErrorMessage = "[Tel_Comer] não pode ter mais de 50 caracteres")]
        [Display(Name = "Comercial")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?\d{2}\)?[\s-]?\d{4}-?\d{4}$", ErrorMessage = "Você deve digitar um telefone no formato (##) ####-####")]
        public string Tel_Comer { get; set; }
        //[StringLength(50, ErrorMessage = "[Tel_Comer_Mess] não pode ter mais de 50 caracteres")]
        [Display(Name = "Mensagem")]
        [EnumDataType(typeof(TipoAppMensagem))]
        public TipoAppMensagem? Tel_Comer_Mess { get; set; }
        [StringLength(50, ErrorMessage = "[Tel_Comer_Ramal] não pode ter mais de 50 caracteres")]
        [Display(Name = "Ramal")]
        public string Tel_Comer_Ramal { get; set; }
        public byte[] FotoRosto { get; set; }
        public byte[] FotoRosto_Image { get; set; }
        public ICollection<Pessoa_Ctto> Pessoa_Cttos { get; set; }
        public ICollection<Pessoa_Conta> Pessoa_Contas { get; set; }

        public Paciente Paciente { get; set; }
        public Dentista Dentista { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Funcionario Funcionario { get; set; }

        public Pessoa()
        {
            Tpo_Pessoa = TipoPessoa.Fisica;
            Sexo = TipoSexo.Masculino;
            RG_Emiss = "MG";
            Nacionalidade = "Brasileira";
            EstadoCivil = TipoEstadoCivil.Solteiro;
            Data_Alt = DateTime.Now;
            Data_Cad = DateTime.Now;
        }
}
}
