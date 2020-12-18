using System;
using System.ComponentModel.DataAnnotations;
using Farmacia.API.Enums;

namespace Farmacia.API.Domain.Entities
{
    public class Funcionario //--ok
    {
        [Key]
        public int IdFuncionario { get; set; }

        public int IdPessoaFisica { get; set; }
        public PessoaFisica Pessoa { get; set; }

        public TipoPessoaEnum TipoPessoa { get; set; } //-- Tipo Funcionario

        public CargoEnum Cargo { get; set; }

        public string Registro { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim  { get; set; }

    }
}