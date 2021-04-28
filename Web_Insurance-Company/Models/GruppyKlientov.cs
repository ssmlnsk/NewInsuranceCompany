using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class GruppyKlientov
    {
        public GruppyKlientov()
        {
            Klienty = new HashSet<Klienty>();
        }

        [Display(Name = "Код группы")]
        public long KodGruppy { get; set; }
        [Display(Name = "Наименование")]
        public string Naimenovanie { get; set; }
        [Display(Name = "Описание")]
        public string Opisanie { get; set; }

        public virtual ICollection<Klienty> Klienty { get; set; }
    }
}
