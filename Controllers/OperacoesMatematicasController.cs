using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesMatematicasController : Controller
{
    public IActionResult Somar()
    {
        return View();
    }

    public IActionResult ResultadoSoma([FromForm] double n1, [FromForm] double n2)
    {
        ViewBag.N1 = n1;
        ViewBag.N2 = n2;
        ViewBag.Resultado = n1 + n2;

        return View();
    }

    public IActionResult Multiplicacao()
    {
        return View();
    }

    public IActionResult ResultadoMultiplicacao([FromForm] double n1, [FromForm] double n2)
    {
        ViewData["N1"] = n1;
        ViewData["N2"] = n2;
        ViewData["Resultado"] = n1 * n2;

        return View();
    }
}
