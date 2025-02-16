﻿using Abstracciones.Abstracciones;
using Back.DTO;

namespace Back.Services.Interfaces
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
