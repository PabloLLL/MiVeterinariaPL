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
        public string Documento { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Teléfono Fijo")]
        public string TelFijo { get; set; }

        [Required]
        [MaxLength(20)]
        [Display(Name = "Teléfono Celular")]
        public string TelCelular { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        [Display(Name = "Propietario")]
        public string NombreApellido =>  $"{Nombre} {Apellido}";

        [Display(Name = "Propietario")]
        public string nombreApellidoConDocumento =>  $"{Nombre} {Apellido} - {Documento}";

        public ICollection<Mascota> Mascotas { get; set; }

        public ICollection<Agenda> Agendas { get; set; }

    }
}
