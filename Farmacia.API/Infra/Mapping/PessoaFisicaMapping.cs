using Farmacia.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Farmacia.API.Infra.Mapping
{
    public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.ToTable("TB_PessoaFisica");
            builder.HasKey(p => p.IdPessoaFisica);
            builder.Property(p => p.CPF);
            builder.Property(p => p.DataNascimento);
            builder.Property(p => p.Nome);
            builder.Property(p => p.RG);
            builder.Property(p => p.TipoPessoaFisica);
            builder.HasOne(p => p.Pessoa).WithOne();
            
        }
    }
}