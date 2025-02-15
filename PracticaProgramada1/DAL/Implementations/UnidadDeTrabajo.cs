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

        private PracticaProgramada1Context _practicaProgramada1Context;

        public UnidadDeTrabajo(PracticaProgramada1Context practicaProgramada1Context, IPersonaDAL personaDAL)
        {
            this._practicaProgramada1Context = practicaProgramada1Context;
            this.PersonaDAL = personaDAL;
        }

        public bool Complete()
        {
            try
            {
                _practicaProgramada1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            this._practicaProgramada1Context.Dispose();
        }
    }
}
