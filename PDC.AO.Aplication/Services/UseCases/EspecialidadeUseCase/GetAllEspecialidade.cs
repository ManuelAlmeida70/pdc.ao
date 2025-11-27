using PDC.AO.Aplication.Services.DTOs;
using PDC.AO.Domain.Repositories;

namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public class GetAllEspecialidade : IGetAllEspecialidade
{
    private readonly IEspecialidadeRepository _especialidadeRepository;

    public GetAllEspecialidade(IEspecialidadeRepository especialidadeRepository)
    {
        _especialidadeRepository = especialidadeRepository;
    }
    public async Task<List<EspecialidadeDTO>> Execute()
    {
        List<EspecialidadeDTO> especialidadeDTOs = new List<EspecialidadeDTO>();

        var especialidades = await _especialidadeRepository.GetAllEspecialidade();

        foreach (var especialidade in especialidades)
        {
            var especialidadeDTO = new EspecialidadeDTO()
            {
                Descricao = especialidade.Descricao,
                Id = especialidade.IdEspecialidade
            };
            especialidadeDTOs.Add(especialidadeDTO);
        }
        return especialidadeDTOs;
    }
}
