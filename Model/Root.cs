using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Root
    {
        public Root()
        {
            results = new List<Result>();
        }
        public int Id { get; set; }
        public List<Result> results { get; set; }
        public Info info { get; set; }
    }
}
