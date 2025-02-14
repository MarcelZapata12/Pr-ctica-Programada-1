using Abstracciones.Abstracciones;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PersonaDAL : IPersonaDAl
    {
        private PracticaProgramada1Context _context;
        public PersonaDAL(PracticaProgramada1Context context)
        {
            _context = context;
        }
        public bool AddPersona(Persona persona)
        {
            try 
            {
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeletePersona(int id)
        {
            throw new NotImplementedException();
        }
        public List<Persona> GetPersonas()
        {
            throw new NotImplementedException();
        }
        public bool UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

    }
}
