using Microsoft.EntityFrameworkCore;
using PDC.AO.Domain.Entities;

namespace PDC.AO.Insfrastructure.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Especialidade>  Especialidades { get; set; }
}
