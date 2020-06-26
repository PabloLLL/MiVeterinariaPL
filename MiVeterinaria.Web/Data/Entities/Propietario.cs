using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MiVeterinaria.Web.Data.Entities
{
    public class Propietario
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string documento { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Teléfono Fijo")]
        public string telFijo { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Teléfono Celular")]
        public string telCelular { get; set; }

        [MaxLength(100)]
        public string direccion { get; set; }

        [Display(Name = "Propietario")]
        public string NombreApellido =>  $"{nombre} {apellido}";

        [Display(Name = "Propietario")]
        public string nombreApellidoConDocumento =>  $"{nombre} {apellido} - {documento}";

    }
}
