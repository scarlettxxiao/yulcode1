using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartOffice.Models
{
    public class Speaker
    {
        public int id { get; set; }
        public Boolean isConnected { get; set; }
        public Boolean isOn { get; set; }
        public Boolean isPlaying { get; set; }
    }
}
