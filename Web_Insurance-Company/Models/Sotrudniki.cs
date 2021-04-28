using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class Sotrudniki
    {
        public Sotrudniki()
        {
            Polisy = new HashSet<Polisy>();
        }

        public long KodSotrudnika { get; set; }
        public string Fio { get; set; }
        public byte[] DataRozdeniya { get; set; }
        public string Pol { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string PasportnyeDannye { get; set; }
        public long KodDolzhnosti { get; set; }

        public virtual Dolzhnosti KodDolzhnostiNavigation { get; set; }
        public virtual ICollection<Polisy> Polisy { get; set; }
    }
}
