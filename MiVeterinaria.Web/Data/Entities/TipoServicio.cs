﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.Web.Data.Entities
{
    public class TipoServicio
    {
        public int Id { get; set; }

        [Display(Name = "Tipo Servicio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más que {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string nombre { get; set; }

        public ICollection<Historia> Historias { get; set; }

    }
}
