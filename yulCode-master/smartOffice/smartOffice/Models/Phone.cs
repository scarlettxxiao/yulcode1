using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartOffice.Models
{
    public class Phone
    {
        public int id { get; set; }
        public Boolean isCalling { get; set; }
        public Boolean isOn { get; set; }
        public string phoneNumber { get; set; }
    }
}
