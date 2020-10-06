using DataLayer;
using DataLayer.Abstract;
using DataLayer.Concrete;
using Model;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        private INameDal _nameDal;
        private IResultDal _resultDal;
        public Program()
        {
            _nameDal = new NameDal();
            _resultDal = new ResultDal();
        }
       
        static void Main(string[] args)
        {
            //Root root = new Root();
            //RandomUser user = new RandomUser();
            //root = user.GetRandomUser();
            using (var context = new DbUserContext())
            {
                var result = from r in context.Results
                             join n in context.Names on r.name.Id equals n.Id
                             select new
                             {
                                 ProductName = r.name.title,
                                 CategoryName = n.title
                             };

                result.ToList().ForEach(x =>
                {
                    Console.WriteLine($"Product Name: {x.ProductName}, Category Name: {x.CategoryName}");
                });
                Console.ReadLine();
            }
        }




    }
}
