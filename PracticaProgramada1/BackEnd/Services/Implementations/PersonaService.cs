using Abstracciones.Abstracciones;
using BackEnd.Services.Interfaces;
using DAL.Implementations;
using DAL.Interfaces;

namespace BackEnd.Services.Implementations
{
    public class PersonaService : IPersonaService

    {
        private IPersonaDAl _personaDAL;
        public PersonaService(PersonaDAL personaDAL)
        {
            _personaDAL = personaDAL;
        }
        public void AddPersona(Persona persona)
        {
            _personaDAL.AddPersona(persona);
        }
        public void DeletePersona(int id)
        {
            _personaDAL.DeletePersona(id);
        }
        public List<Persona> GetPersonas()
        {
            return _personaDAL.GetPersonas();
        }
        public void UpdatePersona(Persona persona)
        {
            _personaDAL.UpdatePersona(persona);
        }


    }
}
