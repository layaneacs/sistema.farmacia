using System;
using Farmacia.API.Enums;

namespace Farmacia.API.Entidades
{
    public class Funcionario //--ok
    {
        public int IdFuncionario { get; set; }

        public int IdPessoaFisica { get; set; }
        public PessoaFisica Pessoa { get; set; }

        public CargoEnum Cargo { get; set; }

        public string Registro { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim  { get; set; }

    }
}