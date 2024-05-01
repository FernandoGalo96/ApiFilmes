using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "O Título do filme é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênero do filme é obrigatório!")]
    [StringLength(50, ErrorMessage = "O tamanho do Gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 500, ErrorMessage = "O tempo mínimo é de 70min e o máximo 500min!")]
    public int Duracao { get; set; }

}
 