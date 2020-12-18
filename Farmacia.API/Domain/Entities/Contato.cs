using System.ComponentModel.DataAnnotations;

namespace Farmacia.API.Domain.Entities
{
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Celular { get; set; }
        public string TelefoneRecado { get; set; }
        public string Email { get; set; }
        public string whatsapp { get; set; }

    }
}