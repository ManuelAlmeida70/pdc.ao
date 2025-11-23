using System.ComponentModel.DataAnnotations;

namespace PDC.AO.Domain.Entities;
public class Especialidade
{
    [Key]
    public int IdEspecialidade { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public int Ativo { get; set; }

}
