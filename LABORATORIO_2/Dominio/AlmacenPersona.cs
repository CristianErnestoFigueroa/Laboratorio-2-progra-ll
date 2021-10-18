
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2.Dominio
{
    public class AlmacenPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdPersona { get; set; }
        [Display(Name = "Nombre: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NombrePersona { get; set; }
        [Display(Name = "Edad: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(18, int.MaxValue, ErrorMessage = "No valido")]
        public int EdadPersona { get; set; }
        [Display(Name = "Descripcion: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string DescripcionPersona { get; set; }

    }
}
