using Farmacia.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Farmacia.API.Infra.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TB_CLIENTE");
            builder.HasKey(p => p.IdCliente);
            builder.Property(p => p.DataCadastro);
            builder.Property(p => p.Vip);
            builder.Property(p => p.Observacao);
            builder.HasOne(p => p.PessoaFisica).WithOne();
            
        }
    }
}