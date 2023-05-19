using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka_EX_App.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employees> Employees { get; set; }
    }
}
