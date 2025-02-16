﻿using Abstracciones.Abstracciones;
using Back.DTO;
using Back.Services.Interfaces;
using DAL.Interfaces;
using System.Collections.Generic;

namespace Back.Services.Implementations
{
    public class PersonaService : IPersonaService
    {
        private readonly IUnidadDeTrabajo _unidadDeTrabajo;

        public PersonaService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            _unidadDeTrabajo = unidadDeTrabajo;
        }

        private Persona Convertir(PersonaDTO persona)
        {
            return new Persona
            {
                Id = persona.Id,
                Identificación = persona.Identificación,
                Nombre = persona.Nombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido
            };
        }

        private PersonaDTO Convertir(Persona persona)
        {
            return new PersonaDTO
            {
                Id = persona.Id,
                Identificación = persona.Identificación,
                Nombre = persona.Nombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido
            };
        }

        public void AddPersona(PersonaDTO persona)
        {
            var personaEntity = Convertir(persona);
            _unidadDeTrabajo.PersonaDAL.Add(personaEntity);
            _unidadDeTrabajo.Complete();
        }

        public void DeletePersona(int id)
        {
            var persona = new Persona { Id = id };
            _unidadDeTrabajo.PersonaDAL.Remove(persona);
            _unidadDeTrabajo.Complete();
        }

        public List<PersonaDTO> GetPersonas()
        {
            var result = _unidadDeTrabajo.PersonaDAL.GetAllPersonas();

            List<PersonaDTO> personas = new List<PersonaDTO>();
            foreach (var item in result)
            {
                personas.Add(Convertir(item));
            }
            return personas;
        }

        public void UpdatePersona(PersonaDTO persona)
        {
            var personaEntity = Convertir(persona);
            _unidadDeTrabajo.PersonaDAL.Update(personaEntity);
            _unidadDeTrabajo.Complete();
        }

        public PersonaDTO GetPersonaById(int id)
        {
            var result = _unidadDeTrabajo.PersonaDAL.Get(id);
            return Convertir(result);
        }
        




    }
}
