using Clinical2018.Models;
using System;
using System.Linq;

namespace Clinical2018.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Clinical2018Contexto context)
        {
            context.Database.EnsureCreated();
            //// procura por qualquer Pessoa
            //if (!context.Pessoa.Any())
            //{
            //    var pessoas = new Pessoa[]
            //    {
            //        new Pessoa{Nome="Carlos",CPF_CNPJ="11111111111111",EMail="Carlos@gmail.com",EstadoCivil=""
            //new Estudante{Nome="Maria",SobreNome="Alonso",DataMatricula=DateTime.Parse("2012-09-01")},
            //new Estudante{Nome="Bianca",SobreNome="Almeida",DataMatricula=DateTime.Parse("2013-09-01")},
            //new Estudante{Nome="Jose Carlos",SobreNome="Siqueira",DataMatricula=DateTime.Parse("2012-09-01")},
            //new Estudante{Nome="Yuri",SobreNome="Silva",DataMatricula=DateTime.Parse("2012-09-01")},
            //new Estudante{Nome="Mario",SobreNome="Domingues",DataMatricula=DateTime.Parse("2011-09-01")},
            //new Estudante{Nome="Laura",SobreNome="Santos",DataMatricula=DateTime.Parse("2013-09-01")},
            //new Estudante{Nome="Jefferson",SobreNome="Bueno",DataMatricula=DateTime.Parse("2015-09-01")}
            //    };
            //}
        }
    }
}