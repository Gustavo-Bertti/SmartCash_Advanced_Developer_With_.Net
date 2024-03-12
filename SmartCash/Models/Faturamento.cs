namespace SmartCash.Models
{
       public class Faturamento : FluxoDeCaixa
   {

       private double _totalFaturamento;


       public Faturamento(string tipo, double valor, string descricao, DateTime data) : base(tipo, valor, descricao, data)
       {
           if (tipo == "entrada") _totalFaturamento = valor;
           else throw new ArgumentNullException();

       }



           protected double TotalFaturamento() 
       {
           ;
           return _totalFaturamento;
       
       }

       public override string ToString()
       {
           return $"Valor total do faturamento: {_totalFaturamento} reais";
       }
   }
}
