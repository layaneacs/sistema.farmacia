using System;

namespace Farmacia.API.Entidades
{
    public class Cliente //-- ok
    {
        public int IdCliente { get; set; }

        public string IdPessoaFisica { get; set; }
        public PessoaFisica Pessoa { get; set; }

        public DateTime DataCadastro { get; set; }

        public string Observacao { get; set; }

        public bool Vip  { get; set; }
        
    }
}