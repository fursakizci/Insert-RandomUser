using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAllModel();
        TEntity Update(TEntity model);
        TEntity GetModel(int id);
    }
}
