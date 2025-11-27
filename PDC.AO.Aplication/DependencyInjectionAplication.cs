using Microsoft.Extensions.DependencyInjection;
using PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;

namespace PDC.AO.Aplication;
public static class DependencyInjectionAplication
{
    public static void AddAplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    

    public static void AddUseCases(IServiceCollection service)
    {
        service.AddScoped<ICadastrarEspecialidadeUseCase, CadastrarEspecialidadeUseCase>();
        service.AddScoped<IGetAllEspecialidade, GetAllEspecialidade>();
        service.AddScoped<IEliminarEspecialidade, EliminarEspecialidade>();
    }
}
