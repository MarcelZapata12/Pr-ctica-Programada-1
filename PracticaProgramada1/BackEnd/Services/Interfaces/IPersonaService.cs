using Abstracciones.Abstracciones;

namespace BackEnd.Services.Interfaces
{
    public interface IPersonaService
    {
        void AddPersona(Persona persona);
        void UpdatePersona(Persona persona);
        void DeletePersona(int id);
        List<Persona> GetPersonas();
    }
}
