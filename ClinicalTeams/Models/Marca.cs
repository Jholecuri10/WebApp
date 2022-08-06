using System;
using System.ComponentModel.DataAnnotations;

namespace ClinicalTeams.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="La Descripcion Es Obligatoria")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="El Estado Es Obligatorio")]
        public string Estado { get; set; }
        [Required(ErrorMessage ="La Fecha Registro Es Obligatoria")]
        public DateTime FechaRegistro { get; set; }
    }
}
