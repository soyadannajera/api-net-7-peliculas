using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CrearCategoriaDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(60, ErrorMessage = "EL numero maximo de caracteres es de 60")]
        public string Nombre { get; set; }
    }
}
