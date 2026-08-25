namespace FestivalCidade
{
    class Usuario
    {
        public string Nome { get; set; }
        public int QuantidadeDias { get; set; }
        public string Cupom { get; set; }
        public int PontuacaoClube { get; set; }
        public Usuario(string nome, int quantidadeDias, string cupom, int pontuacaoClube)
        {
            Nome = nome;
            QuantidadeDias = quantidadeDias;
            Cupom = cupom;
            PontuacaoClube = pontuacaoClube;
        }
        public decimal CalcularCustoBruto()
        {
            return 15.00m + (QuantidadeDias * 120.00m);
        }
        public decimal CalcularDesconto()
        {
            if (Cupom.Equals("ROCK10", StringComparison.OrdinalIgnoreCase))
            {
                return CalcularCustoBruto() * 0.10m;
            }

            return 0.00m;
        }
        public decimal CalcularValorFinal()
        {
            return CalcularCustoBruto() - CalcularDesconto();
        }
    }

}
