namespace Farmacia.API.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdContato { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LembreteSenha { get; set; }
        public string IdPessoaFisica { get; set; } 
        public string TipoUsuario { get; set; }    
    }
}