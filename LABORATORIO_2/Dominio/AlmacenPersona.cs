
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

        public string NombrePersona { get; set; }
     
        public int EdadPersona { get; set; }

        public string DescripcionPersona { get; set; }

        
    }
}
