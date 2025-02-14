using Abstracciones.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPersonaDAl
    {
        bool AddPersona(Persona persona);
        bool UpdatePersona(Persona persona);
        bool DeletePersona(int id);
        List<Persona> GetPersonas();

    }
}
