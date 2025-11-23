using Microsoft.AspNetCore.Mvc;

namespace PDC.AO.Hospital.Controllers;
public class HomeController : Controller
{
    public ViewResult Index()
    {
        ViewBag.Nome = "Manuel Mazunga de Almeida";

        return View();
    }

    public ViewResult Login()
    {
        return View();
    }

    public ViewResult IniciarSessao()
    {
        return View("../PessoaAdmin/Dashboard");
    }
    public ViewResult CriarConta()
    {
        return View();
    }
}
