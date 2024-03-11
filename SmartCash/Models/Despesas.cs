namespace SmartCash.Models
{
    public class Despesas
    {
        private FluxoDeCaixa _fluxoDeCaixa;
        private double _totalDespesas { get; set; }

        public Despesas(FluxoDeCaixa fluxoDeCaixa)
        {
            if (fluxoDeCaixa == null) throw new ArgumentNullException();
            else if(fluxoDeCaixa.Descricao() == "saida") throw new ArgumentNullException();
            _fluxoDeCaixa = fluxoDeCaixa;
            TotalDespesas();
        }
        protected double TotalDespesas()
        {
            _totalDespesas += _fluxoDeCaixa.Valor();
            return _totalDespesas;
        }

        public override string ToString()
        {
            return $"Valor total das despesas: {_totalDespesas} reais";
        }

    }
}
