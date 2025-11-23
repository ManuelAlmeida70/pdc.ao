using Microsoft.AspNetCore.Mvc;
using PDC.AO.Aplication.Services.DTOs;
using PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;

namespace PDC.AO.Hospital.Controllers.Administrativo;
public class EspecialidadeController : Controller
{

    public ViewResult Especialidade()
    {
        return View("../PessoaAdmin/Especialidade");
    }
    public async Task<EspecialidadeDTO> CadastrarEspecialidade(EspecialidadeDTO especialidade, [FromServices] ICadastrarEspecialidadeUseCase useCase)
    {

        var entity = await useCase.Execute(especialidade);

        if (entity == null)
        {
            return null!;
        }
        return entity;
    }
}
