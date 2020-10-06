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
    public class ResultManager : IResultService
    {
        private IResultDal _resultDal;
        public ResultManager()
        {
            _resultDal = new ResultDal();
        }
        public List<Result> GetAllModels()
        {
            return _resultDal.GetAllModel();
        }

        public void Update(Result model)
        {
            _resultDal.Update(model);
        }
    }
}
