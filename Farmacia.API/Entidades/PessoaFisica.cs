using System;
using Farmacia.API.Enums;

namespace Farmacia.API.Entidades
{
    public class PessoaFisica //-- ok
    {
        public int IdPessoaFisica { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public TipoPessoaFisicaEnum TipoPessoaFisica { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string RG { get; set; }

        public DateTime DataNascimento { get; set; }

        
    }
}