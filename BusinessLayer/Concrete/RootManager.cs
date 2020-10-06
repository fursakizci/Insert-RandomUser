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
    public class RootManager : IRootService
    {
        private IRootDal _rootDal;
        public RootManager()
        {
            _rootDal = new RootDal();
        }
        public List<Root> GetAllModels()
        {
            return _rootDal.GetAllModel();
        }

        public void Update(Root entity)
        {
            _rootDal.Update(entity);
        }
    }
}
