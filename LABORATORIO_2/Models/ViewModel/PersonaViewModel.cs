using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2.Models.ViewModel
{
    public class PersonaViewModel
    {
        public int IdPersona { get; set; }

        [Display(Name = "Nombre: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String NombrePersona { get; set; }

        [Display(Name = "Edad: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "No valido")]
        public int EdadPersona { get; set; }

        [Display(Name = "Descripcion: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String DescripcionPersona { get; set; }


    }
}
