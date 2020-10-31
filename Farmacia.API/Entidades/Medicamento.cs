namespace Farmacia.API.Entidades
{
    public class Medicamento //-- ok
    {
        public int IdMedicamento { get; set; }

        public string Nome { get; set; }

        public string Fabricante { get; set; }

        public decimal Dosagem { get; set; }

        public decimal PrecoUnitatio { get; set; }

        public int Quantidade { get; set; }

        public int IdPessoaJuridica { get; set; } //-- Fornecedor
        public PessoaJuridica Pessoa { get; set; }

    }
}