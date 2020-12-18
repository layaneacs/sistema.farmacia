using System;

namespace Farmacia.API.Domain.Entities
{
    public class Cliente
    {
        
        public int IdCliente { get; set; }
        
        public int IdPessoaFisica { get; set; }
        public PessoaFisica PessoaFisica { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Observacao { get; set; }

        public bool Vip  { get; set; }
    }
}