using Microsoft.AspNetCore.Mvc;

namespace PDC.AO.Hospital.Controllers.Administrativo;
public class DashboardController : Controller
{
    public ViewResult Especialidade()
    {
        return View("../PessoaAdmin/Especialidade");
    }
}
