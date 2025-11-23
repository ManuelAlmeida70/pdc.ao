using PDC.AO.Domain.Entities;
using PDC.AO.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDC.AO.Insfrastructure.Data.Repositories;
public class EspecialidadeRepository : IEspecialidadeRepository
{
    private readonly ApplicationDbContext _context;
    public EspecialidadeRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Add(Especialidade especialidade)
    {
        await _context.Especialidades.AddAsync(especialidade);
        await _context.SaveChangesAsync();
    }
}
