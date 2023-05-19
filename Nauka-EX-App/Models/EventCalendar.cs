using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka_EX_App.Models
{
    public class EventCalendar
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int EventTypeId { get; set; }
        public EventTypes EventType { get; set; }
    }
}
