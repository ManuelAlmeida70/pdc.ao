using PDC.AO.Aplication.Services.DTOs;
using PDC.AO.Domain.Entities;
using PDC.AO.Domain.Repositories;

namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public class CadastrarEspecialidadeUseCase : ICadastrarEspecialidadeUseCase
{
    private readonly IEspecialidadeRepository _especialidadeRepository;

    public CadastrarEspecialidadeUseCase(IEspecialidadeRepository especialidadeRepository)
    {
        _especialidadeRepository = especialidadeRepository;
    }
    public async Task<EspecialidadeDTO> Execute(EspecialidadeDTO especialidade)
    {
        var entity = new Especialidade()
        {
            Descricao = especialidade.Descricao,
            Ativo = 1
        };

        await _especialidadeRepository.Add(entity);
        return especialidade;
    }
}
