using PDC.AO.Aplication.Services.DTOs;

namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public interface IGetAllEspecialidade
{
    Task<List<EspecialidadeDTO>> Execute();
}
