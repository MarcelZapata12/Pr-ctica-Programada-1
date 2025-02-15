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
                string sql = "exec [dbo].[sp_AddPersona] @Identificación, @Nombre, @PrimerApellido, @SegundoApellido";

                var param = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@Identificación",
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

                _context.Database.ExecuteSqlRaw(sql, param);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void DeletePersona(int id)
        {
            try
            {
                string sql = "exec [dbo].[sp_DeletePersona] @Id";

                var param = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@Id",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Value = id
                    }
                };

                _context.Database.ExecuteSqlRaw(sql, param);
            }
            catch (Exception e)
            {
            }
        }

        public List<Persona> GetPersonas()
        {
            try
            {
                string sql = "exec [dbo].[sp_GetAllPersonas]";

                var result = _context.Personas.FromSqlRaw(sql).ToList();
                return result;
            }
            catch (Exception e)
            {
                return new List<Persona>();
            }
        }

        public void UpdatePersona(Persona entity)
        {
            try
            {
                string sql = "exec [dbo].[sp_UpdatePersona] @Id, @Identificación, @Nombre, @PrimerApellido, @SegundoApellido";

                var param = new SqlParameter[]
                {
                    new SqlParameter()
                    {
                        ParameterName = "@Id",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Value = entity.Id
                    },
                    new SqlParameter()
                    {
                        ParameterName = "@Identificación",
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

                _context.Database.ExecuteSqlRaw(sql, param);
            }
            catch (Exception e)
            {

            }
        }
    }
}
