using System.ComponentModel.DataAnnotations;

namespace ClinicalTeams.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Los Nombres son obligatorios")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="Los Apellidos son obligatorios")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage ="El Correo es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage ="La Clave Es Obligatorio")]
        public string Clave { get; set; }
        [Required(ErrorMessage ="El Estado es obligatorio")]
        public string Estado { get; set; }
        [Required(ErrorMessage ="La Fecha de Registro es obligatoria")]
        public DateTime FechaRegistro { get; set; }
    }
}
