using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{

    [Required(ErrorMessage = "Nome obrigatório")]

    public string Nome { get; set; }
}
