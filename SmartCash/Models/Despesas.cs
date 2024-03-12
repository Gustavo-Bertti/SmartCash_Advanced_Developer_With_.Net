namespace SmartCash.Models
{
 public class Despesas : FluxoDeCaixa
   {
   
       public Despesas(string tipo, double valor, string descricao, DateTime data) : base(tipo, valor, descricao, data)
       {
           if (tipo != "saida") throw new ArgumentNullException();
       }
   
   }
}
