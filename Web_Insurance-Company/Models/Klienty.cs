using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class Klienty
    {
        public Klienty()
        {
            Polisy = new HashSet<Polisy>();
        }

        [Display(Name = "Код клиента")]
        public long KodKlienta { get; set; }
        [Display(Name = "ФИО")]
        public string Fio { get; set; }
        [Display(Name = "Дата рождения")]
        public byte[] DataRozhdeniya { get; set; }
        [Display(Name = "Пол")]
        public string Pol { get; set; }
        [Display(Name = "Адресс")]
        public string Adres { get; set; }
        [Display(Name = "Телефон")]
        public string Telefon { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PasportnyeDannye { get; set; }
        [Display(Name = "Код группы")]
        public long KodGruppy { get; set; }

        public virtual GruppyKlientov KodGruppyNavigation { get; set; }
        public virtual ICollection<Polisy> Polisy { get; set; }
    }
}
