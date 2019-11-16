using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartOffice.Models
{
    public class Room
    {
        public int capacity { get; set; }
        public List<Employee> employees { get; set; }
        public int id { get; set; }
        public Light light { get; set; }
        public string name { get; set; }
        public Phone phone { get; set; }
        public Speaker speaker { get; set; }
        public Television television { get; set; }
        public Thermostat thermostat { get; set; }
    }
}
