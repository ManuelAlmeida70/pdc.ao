namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public interface IEliminarEspecialidade
{
    Task<bool> Execute(int id);
}
