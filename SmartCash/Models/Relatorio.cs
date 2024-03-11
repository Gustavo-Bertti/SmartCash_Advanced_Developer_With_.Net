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

        public string DetailsFaturamento()
        {
            return _faturamento.ToString() +", "+ _despesas.ToString();
        }

        
    }
}
