using AlmacenPersona.Models;
using AlmacenPersona.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlmacenPersona.Repository
{


    public class PersonaRepository : IPersonas
    {
        AlmacenPersonaEntities bd = new AlmacenPersonaEntities();

        public void Create(Persona p)
        {
            bd.Persona.Add(p);
            bd.SaveChanges();
        }       

        public ICollection<Persona> ListDataPersona()
        {

            var ListDataPersonas = bd.Persona.ToList();

            return ListDataPersonas;
            
        }

       
    }
}