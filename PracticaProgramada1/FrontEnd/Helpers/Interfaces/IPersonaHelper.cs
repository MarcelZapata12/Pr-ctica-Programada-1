using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IPersonaHelper
    {
        List<PersonaViewModel> GetPersonas();
        PersonaViewModel GetPersona(int id);
        PersonaViewModel AddPersona(PersonaViewModel persona);
        PersonaViewModel UpdatePersona(int id, PersonaViewModel persona);
        bool DeletePersona(int id);


    }
}
