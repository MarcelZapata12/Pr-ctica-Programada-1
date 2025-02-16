/*
using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEnd.Helpers.Implementations
{
    public class PersonaHelper : IPersonaHelper
    {
        private readonly IServiceRepository _serviceRepository;

        public PersonaHelper(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        private PersonaViewModel Convertir(PersonaAPI persona)
        {
            return new PersonaViewModel
            {
                Id = persona.Id,
                Identificación = persona.Identificación,
                Nombre = persona.Nombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido
            };
        }

        public List<PersonaViewModel> GetPersonas()
        {
            HttpResponseMessage responseMessage = _serviceRepository.GetResponse("api/Persona");
            List<PersonaAPI> personas = new List<PersonaAPI>();
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                personas = JsonConvert.DeserializeObject<List<PersonaAPI>>(content);
            }
            List<PersonaViewModel> lista = new List<PersonaViewModel>();
            foreach (var persona in personas)
            {
                lista.Add(Convertir(persona));
            }
            return lista;
        }

        public PersonaViewModel GetPersona(int id)
        {
            HttpResponseMessage responseMessage = _serviceRepository.GetResponse($"api/Persona/{id}");
            PersonaAPI persona = null;
            if (responseMessage.IsSuccessStatusCode)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                persona = JsonConvert.DeserializeObject<PersonaAPI>(content);
            }
            return Convertir(persona);
        }

        public PersonaViewModel AddPersona(PersonaViewModel persona)
        {
            HttpResponseMessage response = _serviceRepository.PostResponse("api/Persona", persona);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                persona = JsonConvert.DeserializeObject<PersonaViewModel>(content);
            }
            return persona;
        }

        public PersonaViewModel UpdatePersona(int id, PersonaViewModel persona)
        {
            HttpResponseMessage response = _serviceRepository.PutResponse($"api/Persona/{id}", persona);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                persona = JsonConvert.DeserializeObject<PersonaViewModel>(content);
            }
            return persona;
        }

        public bool DeletePersona(int id)
        {
            HttpResponseMessage response = _serviceRepository.DeleteResponse($"api/Persona/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
*/
using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace FrontEnd.Helpers.Implementations
{
    public class PersonaHelper : IPersonaHelper
    {
        IServiceRepository _ServiceRepository;

        PersonaViewModel Convertir(PersonaAPI persona)
        {
            PersonaViewModel personaViewModel = new PersonaViewModel
            {
                Id = persona.Id,
                Identificación = persona.Identificación,
                Nombre = persona.Nombre,
                PrimerApellido = persona.PrimerApellido,
                SegundoApellido = persona.SegundoApellido
            };
            
            return personaViewModel;
        }


        public PersonaHelper(IServiceRepository serviceRepository)
        {
            _ServiceRepository = serviceRepository;
        }

        public PersonaViewModel Add(PersonaViewModel persona)
        {
            HttpResponseMessage response = _ServiceRepository.PostResponse("api/Persona", persona);
            if (response.IsSuccessStatusCode)
            {

                var content = response.Content.ReadAsStringAsync().Result;
            }
            return persona;
        }

        public void Delete(int id)
        {
            HttpResponseMessage response = _ServiceRepository.DeleteResponse("api/Persona/" + id.ToString());
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error al eliminar la persona");
            }
        }


        public List<PersonaViewModel> GetPersonas()
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Persona");
            List<PersonaAPI> personas = new List<PersonaAPI>();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                personas = JsonConvert.DeserializeObject<List<PersonaAPI>>(content);
            }
            List<PersonaViewModel> lista = new List<PersonaViewModel>();
            foreach (var persona in personas)
            {
                lista.Add(Convertir(persona));
            }
            return lista;
        }

        public PersonaViewModel GetPersona(int id)
        {
            HttpResponseMessage responseMessage = _ServiceRepository.GetResponse("api/Persona/" + id.ToString());
            PersonaAPI persona = new PersonaAPI();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                persona = JsonConvert.DeserializeObject<PersonaAPI>(content);
            }

            PersonaViewModel resultado = Convertir(persona);


            return resultado;
        }

        public PersonaViewModel Update(PersonaViewModel persona)
        {
            HttpResponseMessage response = _ServiceRepository.PutResponse("api/Persona", persona);
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<PersonaViewModel>(content);
            }
            else
            {
                throw new Exception("Error al actualizar la persona");
            }
        }

    }
}

