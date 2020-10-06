using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IResultService
    {
        void Update(Result model);
        List<Result> GetAllModels();
    }
}
