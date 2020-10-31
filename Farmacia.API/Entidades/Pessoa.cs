using Farmacia.API.Enums;

namespace Farmacia.API.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public TipoPessoaEnum TipoPessoa { get; set; }
        public string IdContato { get; set; }
        public string IdEndereco { get; set; }
    }
}