using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka_EX_App.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartamentId { get; set; }
        public Departments Department { get; set; }
        public string PersonnelNumber { get; set; }
    }
}
