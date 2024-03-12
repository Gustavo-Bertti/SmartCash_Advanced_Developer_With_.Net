namespace SmartCash.Models
{
    public class Relatorio
    {
        private Faturamento _faturamento;
        private Despesas _despesas;
 

        public Relatorio(Faturamento faturamento, Despesas despesas)
        {
            _faturamento = faturamento;
            _despesas = despesas;
        }

        public override string ToString()
        {
            return $"Faturamento: {_faturamento.Valor()}, Despesa: {_despesas.Valor()} reais";
        }
       

        
    }
}
