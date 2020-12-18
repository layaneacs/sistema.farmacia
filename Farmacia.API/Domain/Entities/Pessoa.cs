using System.ComponentModel.DataAnnotations;
using Farmacia.API.Enums;

namespace Farmacia.API.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }        

        public int IdContato { get; set; }
        public Contato Contato { get; set; }

        public int IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
    }
}