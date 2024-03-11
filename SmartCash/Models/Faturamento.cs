namespace SmartCash.Models
{
    public class Faturamento
    {
        private FluxoDeCaixa _fluxoDeCaixa;
        private double _totalFaturamento {  get; set; }


        public Faturamento(FluxoDeCaixa fluxoDeCaixa)
        {
            if (fluxoDeCaixa == null) throw new ArgumentNullException();
            else if (fluxoDeCaixa.Descricao() == "entrada") throw new ArgumentNullException();
            _fluxoDeCaixa = fluxoDeCaixa;
            TotalFaturamento();
        }

        protected double TotalFaturamento() 
        {
            _totalFaturamento += _fluxoDeCaixa.Valor();
            return _totalFaturamento;
        
        }

        public override string ToString()
        {
            return $"Valor total do faturamento: {_totalFaturamento} reais";
        }
    }
}
