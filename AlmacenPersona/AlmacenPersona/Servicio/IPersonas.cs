using AlmacenPersona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenPersona.Servicio
{
    interface IPersonas
    {

        void Create(Persona p);
     

        ICollection<Persona> ListDataPersona();

    }
}
