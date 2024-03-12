namespace SmartCash.Models
{
    public class Faturamento : FluxoDeCaixa
       {
       
           public Faturamento(string tipo, double valor, string descricao, DateTime data) : base(tipo, valor, descricao, data)
           {
               if (tipo != "entrada") throw new ArgumentNullException();
           }
       }
}
