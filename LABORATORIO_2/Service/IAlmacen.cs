using LABORATORIO_2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2.Service
{
    public interface IAlmacen
    {
        void Save(AlmacenPersona Persona);

        ICollection<AlmacenPersona> Lista();
    }
}
