using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Id
    {
        [Key]
        public int UserId { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
