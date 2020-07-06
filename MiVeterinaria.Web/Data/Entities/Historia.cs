using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.Web.Data.Entities
{
    public class Historia
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Descripción*")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más que {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        [Display(Name = "Fecha*")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public string Comentarios { get; set; }

        [Display(Name = "Fecha*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public TipoServicio TipoServicio { get; set; }

        public Mascota Mascota { get; set; }

    }
}
