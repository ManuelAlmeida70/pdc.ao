using PDC.AO.Aplication.Services.DTOs;

namespace PDC.AO.Hospital.ViewModels
{
    public class EspecialidadeViewModel
    {
        public List<EspecialidadeDTO> Especialidades { get; set; } = new();
        public EspecialidadeDTO NovaEspecialidade { get; set; } = new();
    }
}