
using PDC.AO.Aplication.Services.DTOs;
using PDC.AO.Domain.Repositories;

namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public class EliminarEspecialidade : IEliminarEspecialidade
{
    private readonly IEspecialidadeRepository _especialidadeRepository;
    public EliminarEspecialidade(IEspecialidadeRepository especialidadeRepository)
    {
        _especialidadeRepository = especialidadeRepository;
    }
    public async Task<bool> Execute(int id)
    {
        var especialidade = await _especialidadeRepository.DeleteEspecialidade(id);

        if (especialidade is false)
        {
            return false;
        }

        return true;
    }
}
