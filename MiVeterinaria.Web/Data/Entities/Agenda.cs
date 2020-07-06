﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiVeterinaria.Web.Data.Entities
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public string Comentarios { get; set; }

        [Display(Name = "¿Está Disponible?")]
        public bool EstaDisponible { get; set; }

        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm tt}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public Propietario Propietario { get; set; }

        public Mascota Mascota { get; set; }

    }
}
