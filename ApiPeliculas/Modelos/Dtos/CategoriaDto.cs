using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CategoriaDto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(60, ErrorMessage = "EL numero maximo de caracteres es de 60")]
        public string Nombre { get; set; }
    }
}
