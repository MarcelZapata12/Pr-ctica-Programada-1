/*
using FrontEnd.Helpers.Implementations;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaHelper _personaHelper;

        public PersonaController(IPersonaHelper personaHelper)
        {
            _personaHelper = personaHelper;
        }

        // GET: PersonaController
        public ActionResult Index()
        {
            var result = _personaHelper.GetPersonas();
            return View(result);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            var result = _personaHelper.GetPersona(id);
            return View(result);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonaViewModel persona)
        {
            try
            {
                _personaHelper.Add(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _personaHelper.GetPersona(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonaViewModel persona)
        {
            try
            {
                if (id != persona.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    _personaHelper.Update(id, persona);
                    return RedirectToAction(nameof(Index));
                }
                return View(persona);
            }
            catch
            {
                return View(persona);
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _personaHelper.GetPersona(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonaViewModel persona)
        {
            try
            {
                _personaHelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(persona);
            }
        }
    }
}
*/


using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaHelper _personaHelper;

        public PersonaController(IPersonaHelper personaHelper)
        {
            _personaHelper = personaHelper;
        }

        // GET: PersonaController
        public ActionResult Index()
        {
            var result = _personaHelper.GetPersonas();
            return View(result);
        }

        // GET: PersonaController/Details/5
        public ActionResult Details(int id)
        {
            var result = _personaHelper.GetPersona(id);
            return View(result);
        }

        // GET: PersonaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonaViewModel persona)
        {
            try
            {
                _personaHelper.Add(persona);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _personaHelper.GetPersona(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: PersonaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PersonaViewModel persona)
        {
            try
            {
                if (id != persona.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    _personaHelper.Update(persona);
                    return RedirectToAction(nameof(Index));
                }
                return View(persona);
            }
            catch
            {
                return View(persona);
            }
        }

        // GET: PersonaController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _personaHelper.GetPersona(id);
            if (result == null)
            {
                return NotFound();
            }
            return View(result);
        }

        // POST: PersonaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, PersonaViewModel persona)
        {
            try
            {
                _personaHelper.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(persona);
            }
        }
    }
}

