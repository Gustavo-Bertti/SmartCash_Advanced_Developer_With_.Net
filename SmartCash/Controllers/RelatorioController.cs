using Microsoft.AspNetCore.Mvc;
using SmartCash.Models;


namespace SmartCash.Controllers
{
    public class RelatorioController : Controller
    {


        public IActionResult Relatorio()
        {
            FluxoDeCaixa fluxoDeCaixa = new FluxoDeCaixa("entrada", 1000, "Valor lucrado no dia", DateTime.Now);
            FluxoDeCaixa fluxoDeCaixa2 = new FluxoDeCaixa("saida", 1000, "Valor lucrado no dia", DateTime.Now);
            Faturamento faturamento = new Faturamento(fluxoDeCaixa);
            Despesas despesas = new Despesas(fluxoDeCaixa2);
            Relatorio relatorio = new Relatorio(faturamento, despesas);
            return View(relatorio);
        }
      

      
    }
}
