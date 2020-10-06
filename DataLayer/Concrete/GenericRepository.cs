using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class GenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbUserContext, new()
    {
        public List<TEntity> GetAllModel()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity Update(TEntity model)
        {
            using (var context = new TContext())
            {
                var updateModel = context.Entry(model);
                updateModel.State = EntityState.Modified;
                context.SaveChanges();
                return model;
            }
        }

        public TEntity GetModel(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }




    }
}
