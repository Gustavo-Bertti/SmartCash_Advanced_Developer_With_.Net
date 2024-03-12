using Microsoft.AspNetCore.Mvc;
using SmartCash.Models;


namespace SmartCash.Controllers
{
    public class RelatorioController : Controller
    {


        public IActionResult Relatorio()
{
    Faturamento faturamento = new Faturamento("entrada", 1000, "Valor lucrado no dia", DateTime.Now);
    Despesas despesas = new Despesas("saida", 1000, "Valor lucrado no dia", DateTime.Now);

    Relatorio relatorio = new Relatorio(faturamento, despesas);
    return View(relatorio);
}
      

      
    }
}
