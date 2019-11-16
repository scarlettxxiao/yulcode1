using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartOffice.Models
{
    public class Thermostat
    {
        public enum airQuality { LOW, MEDIUM, HIGH}
        public int id { get; set; }
        public Boolean isOn { get; set; }
        public int temperature { get; set; }
    }
}
