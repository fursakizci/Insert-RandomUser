using BusinessLayer.Abstract;
using DataLayer.Abstract;
using DataLayer.Concrete;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NameManager : INameService
    {
        private INameDal _nameDal;
        public NameManager()
        {
            _nameDal = new NameDal();
        }
        public List<Name> GetAllModels()
        {
            return _nameDal.GetAllModel();
        }

        public Name GetModel(int id)
        {
            return _nameDal.GetModel(id);
        }

        public void Update(Name model)
        {
            _nameDal.Update(model);
        }
    }
}
