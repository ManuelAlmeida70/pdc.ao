using PDC.AO.Domain.Entities;

namespace PDC.AO.Domain.Repositories;
public interface IEspecialidadeRepository
{
    Task Add(Especialidade especialidade);

    Task<List<Especialidade>> GetAllEspecialidade();

    Task<Boolean> DeleteEspecialidade(int id);
}
