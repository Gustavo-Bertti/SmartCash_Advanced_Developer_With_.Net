namespace SmartCash.Models
{
   public class Despesas : FluxoDeCaixa
{
    private double _totalDespesas { get; set; }

    public Despesas(string tipo, double valor, string descricao, DateTime data) : base(tipo, valor, descricao, data)
    {
        if (tipo == "saida") _totalDespesas = valor;
        else throw new ArgumentNullException();

    }
    protected double TotalDespesas()
    {
        
        return _totalDespesas;
    }

    public override string ToString()
    {
        return $"Valor total das despesas: {_totalDespesas} reais";
    }

}
}
