using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface INameService
    {
        void Update(Name model);
        List<Name> GetAllModels();
        Name GetModel(int id);
    }
}
