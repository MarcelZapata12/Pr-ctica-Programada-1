using Abstracciones.Abstracciones;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IPersonaDAL PersonaDAL { get; set; }

        private PracticaProgramada1Context _context;

        public UnidadDeTrabajo(PracticaProgramada1Context context,IPersonaDAL personaDAL)
        {
            this._context = context;
            this.PersonaDAL = personaDAL;
        }

        public bool Complete()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
