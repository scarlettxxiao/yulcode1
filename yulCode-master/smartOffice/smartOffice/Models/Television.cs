using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace smartOffice.Models
{
    public class Television
    {
        public int id { get; set; }
        public Boolean isOn { get; set; }
        public Boolean isPlaying { get; set; }
        //private string source { get; set; }
        public enum source { TV, HDMI, PC, CHROMECAST }
    }
}
