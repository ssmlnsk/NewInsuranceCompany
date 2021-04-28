using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class Riski
    {
        public Riski()
        {
            VidyPolisov = new HashSet<VidyPolisov>();
        }

        public long KodRiska { get; set; }
        public string Naimenovanie { get; set; }
        public string Opisanie { get; set; }
        public double SrednyayaVeroyatnost { get; set; }

        public virtual ICollection<VidyPolisov> VidyPolisov { get; set; }
    }
}
