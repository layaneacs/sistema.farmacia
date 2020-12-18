using System;
using System.ComponentModel.DataAnnotations;

namespace Farmacia.API.Domain.Entities
{
    public class PessoaJuridica //--Fornecedor - Ok
    {
        [Key]
        public int IdPessoaJuridica { get; set; }

        public int IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string CNPJ { get; set; }

        public DateTime DataCadastro { get; set; }   
        
    }
}