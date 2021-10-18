using LABORATORIO_2.Data;
using LABORATORIO_2.Dominio;
using LABORATORIO_2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2.Repository
{
    public class PersonaRepositorio : IAlmacen
    {
        AplicationDbContext app;

        public PersonaRepositorio (AplicationDbContext app)
        {
            this.app = app;
        }
        public ICollection<AlmacenPersona> Lista()
        {
            return app.AlmacenPersona.ToList();

        }

        public void Save(AlmacenPersona Persona)
        {
            app.Add(Persona);
            app.SaveChanges();
        }
    }
}
