using Abstracciones.Abstracciones;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DALGenericoImpl<TEntity> : IDALGenerico<TEntity> where TEntity : class
    {

        private PracticaProgramada1Context _practicaProgramada1Context;

        public DALGenericoImpl(PracticaProgramada1Context practicaProgramada1Context)
        {

            _practicaProgramada1Context = practicaProgramada1Context;
        }

        public bool Add(TEntity entity)
        {
            try
            {
                _practicaProgramada1Context.Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public TEntity Get(int id)
        {

            return _practicaProgramada1Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _practicaProgramada1Context.Set<TEntity>().ToList();
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _practicaProgramada1Context.Set<TEntity>().Attach(entity);
                _practicaProgramada1Context.Set<TEntity>().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _practicaProgramada1Context.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
