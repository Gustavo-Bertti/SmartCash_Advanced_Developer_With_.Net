namespace SmartCash.Models
{
     public class FluxoDeCaixa : GeradorId
     {
         private int _id { get; set; }
         private string _tipo { get; set; }
         private double _valor {  get; set; }
         private string _descricao { get; set; }
         private DateTime _data {  get; set; }
    
    
         public FluxoDeCaixa(string tipo, double valor, string descricao, DateTime data)
         {
             _id = GeradorIdRandomico();
             _tipo = tipo;
             _valor = valor;
             _descricao = descricao;
             _data = data;
         }
    
         public int GeradorIdRandomico()
         {
             Random rn = new Random();
             int id = (int)rn.NextInt64();
             return id;
         }
    
         protected string Descricao()
         {
             return _descricao;
         }
    
         public double Valor()
         {
             return _valor;
         }
    
         
     }
}
