using System.ComponentModel.DataAnnotations;

namespace PDC.AO.Aplication.Services.DTOs;
public class EspecialidadeDTO
{
    [Required(ErrorMessage = "A descrição é obrigatória.")]
    public string Descricao { get; set; } = string.Empty;
    public int Id { get; set; }

}
