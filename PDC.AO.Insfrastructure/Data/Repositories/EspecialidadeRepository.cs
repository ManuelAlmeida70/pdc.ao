using Microsoft.EntityFrameworkCore;
using PDC.AO.Domain.Entities;
using PDC.AO.Domain.Repositories;

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

    public async Task<bool> DeleteEspecialidade(int id)
    {
        var result = await _context.Especialidades.FirstOrDefaultAsync(x => x.IdEspecialidade == id);

        if (result is null)
            return false;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<Especialidade>> GetAllEspecialidade()
    {
        return await _context.Especialidades.ToListAsync();
    }
}
