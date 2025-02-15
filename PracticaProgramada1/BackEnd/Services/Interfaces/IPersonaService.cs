using Abstracciones.Abstracciones;
using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IPersonaService
    {
        void AddPersona(PersonaDTO persona);
        void UpdatePersona(PersonaDTO persona);
        void DeletePersona(int id);
        List<PersonaDTO> GetPersonas(); 
        PersonaDTO GetPersonaById(int id);

    }
}
