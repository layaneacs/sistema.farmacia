using Farmacia.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.API.Infra.Persistence
{
    public class EFContext: DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {   
                

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; } 
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


    }
}