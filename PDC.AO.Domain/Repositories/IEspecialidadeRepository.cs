using PDC.AO.Domain.Entities;

namespace PDC.AO.Domain.Repositories;
public interface IEspecialidadeRepository
{
    Task Add(Especialidade especialidade);
}
