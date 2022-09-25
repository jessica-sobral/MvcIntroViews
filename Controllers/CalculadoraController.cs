using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class CalculadoraController : Controller
{
    public IActionResult Operacao()
    {
        return View();
    }

    public IActionResult Resultado([FromForm] string operacao, [FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Operacao = operacao;
        
        switch (operacao)
        {
            case "Soma":
                ViewBag.Resultado = n1 + n2;
                break;
            case "Subtração":
                ViewBag.Resultado = n1 - n2;
                break;
            case "Multiplicação":
                ViewBag.Resultado = n1 * n2;
                break;
            case "Divisão":
                ViewBag.Resultado = n1 / n2;
                break;
        }

        return View();
    }
}