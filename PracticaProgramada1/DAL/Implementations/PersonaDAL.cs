using Abstracciones.Abstracciones;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class PersonaDAL : DALGenericoImpl<Persona>, IPersonaDAL
    {
        private PracticaProgramada1Context _context;

        public PersonaDAL(PracticaProgramada1Context context) : base(context)
        {
            _context = context;
        }

        public List<Persona> GetAllPersonas()
        {
            string query = "sp_GetAllPersonas";

            var result = _context.Personas.FromSqlRaw(query);

            return result.ToList();
        }

        public bool Add(Persona entity)
        {
            try
            {
                string sql = "exec [dbo].[sp_AddPersona] @Identificacion, @Nombre, @PrimerApellido, @SegundoApellido";

                var param = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@Identificacion",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = entity.Identificación
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@Nombre",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = entity.Nombre
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@PrimerApellido",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = entity.PrimerApellido
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@SegundoApellido",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Value = entity.SegundoApellido
                    }
                };

                _context
                    .Database
                    .ExecuteSqlRaw(sql, param);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(Persona entity)
        {
            try
            {
                _context.Personas.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _context.Personas.Find(id);
                if (entity != null)
                {
                    _context.Personas.Remove(entity);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

