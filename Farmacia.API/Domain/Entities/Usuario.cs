using System.ComponentModel.DataAnnotations;

namespace Farmacia.API.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdContato { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LembreteSenha { get; set; }
        public string IdPessoaFisica { get; set; } 
        public string TipoUsuario { get; set; }    
    }
}