using Microsoft.EntityFrameworkCore;
using Clinical2018.Models;

namespace Clinical2018.Data
{
    public class Clinical2018Contexto : DbContext
    {
        public Clinical2018Contexto(DbContextOptions<Clinical2018Contexto> options) : base(options)
        {
        }

        public DbSet<Pais> Pais { get; set; }
        public DbSet<UF> UF { get; set; }
        public DbSet<Localidade> Localidade { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Logradouro> Logradouro { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Clinica_Dentista> Clinica_Dentista { get; set; }
        public DbSet<Clinica_Paciente> Clinica_Paciente { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Pessoa_Ctto> Pessoa_Ctto { get; set; }
        public DbSet<Dentista> Dentista { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Paciente_Foto> Paciente_Foto { get; set; }
        public DbSet<Paciente_QSaude> Paciente_QSaude { get; set; }
        public DbSet<QSaude> QSaude { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Schedule> Schedule { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().ToTable("Pais");
            modelBuilder.Entity<UF>().ToTable("UF");
            modelBuilder.Entity<Localidade>().ToTable("Localidade");
            modelBuilder.Entity<Bairro>().ToTable("Bairro");
            modelBuilder.Entity<Logradouro>().ToTable("Logradouro");
            modelBuilder.Entity<Clinica>().ToTable("Clinica");
            modelBuilder.Entity<Clinica_Dentista>().ToTable("Clinica_Dentista");
            modelBuilder.Entity<Clinica_Paciente>().ToTable("Clinica_Paciente");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Pessoa_Ctto>().ToTable("Pessoa_Ctto");
            modelBuilder.Entity<Dentista>().ToTable("Dentista");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionario");
            modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<Paciente_Foto>().ToTable("Paciente_Foto");
            modelBuilder.Entity<Paciente_QSaude>().ToTable("Paciente_QSaude");
            modelBuilder.Entity<QSaude>().ToTable("QSaude");
            modelBuilder.Entity<Convenio>().ToTable("Convenio");
            modelBuilder.Entity<Schedule>().ToTable("Schedule");
        }

    }
}