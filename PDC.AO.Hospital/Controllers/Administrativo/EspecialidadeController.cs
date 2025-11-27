using Microsoft.AspNetCore.Mvc;
using PDC.AO.Aplication.Services.DTOs;
using PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
using PDC.AO.Hospital.ViewModels;

namespace PDC.AO.Hospital.Controllers.Administrativo;

public class EspecialidadeController : Controller
{
    public async Task<IActionResult> Especialidade([FromServices] IGetAllEspecialidade useCase)
    {
        var viewModel = new EspecialidadeViewModel
        {
            Especialidades = await useCase.Execute() ?? new List<EspecialidadeDTO>(),
            NovaEspecialidade = new EspecialidadeDTO()
        };

        return View("../PessoaAdmin/Especialidade", viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> CadastrarEspecialidade(
        EspecialidadeViewModel viewModel,
        [FromServices] ICadastrarEspecialidadeUseCase useCase)
    {
        if (!ModelState.IsValid)
        {
            TempData["Erro"] = "Dados inválidos. Verifique os campos e tente novamente.";
            return RedirectToAction("Especialidade");
        }

        var entity = await useCase.Execute(viewModel.NovaEspecialidade);

        if (entity == null)
        {
            TempData["Erro"] = "Ocorreu um erro ao cadastrar a especialidade.";
            return RedirectToAction("Especialidade");
        }

        TempData["Sucesso"] = "Especialidade cadastrada com sucesso!";
        return RedirectToAction("Especialidade");
    }

    [HttpPost]
    public async Task<IActionResult> EliminarEspecialidade([FromServices] IEliminarEspecialidade UseCase, int id)
    {
        try
        {
            var result = await UseCase.Execute(id);
            if (result is false)
            {
                TempData["Erro"] = "Erro ao eliminar a especialidade!";
            }
            else
            {
                TempData["Sucesso"] = "Especialidade eliminada com sucesso!";
            }
            return RedirectToAction("Especialidade");
        }
        catch (Exception ex)
        {
            TempData["Erro"] = $"Erro ao eliminar a especialidade: {ex.Message}";
            return RedirectToAction("Especialidade");
        }
    }
}