using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka_EX_App.Models
{
    public class EventTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EventCalendar> DaysOfEvent { get; set; }
    }
}
