using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class Dolzhnosti
    {
        public Dolzhnosti()
        {
            Sotrudniki = new HashSet<Sotrudniki>();
        }

        [Display(Name = "Код должности")]
        public long KodDolzhnosti { get; set; }
        [Display(Name = "Наименование")]
        public string NaimenovanieDolzhnosti { get; set; }
        [Display(Name = "Оклад")]
        public double Oklad { get; set; }
        [Display(Name = "Обязанности")]
        public string Obyazannosti { get; set; }
        [Display(Name = "Требования")]
        public string Trebovaniya { get; set; }
}
