using PDC.AO.Aplication.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDC.AO.Aplication.Services.UseCases.EspecialidadeUseCase;
public interface ICadastrarEspecialidadeUseCase
{
    Task<EspecialidadeDTO> Execute(EspecialidadeDTO especialidade);
}
