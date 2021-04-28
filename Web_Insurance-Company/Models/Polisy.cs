using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Insurance_Company.Models
{
    public partial class Polisy
    {
        [Display(Name = "Номер полиса")]
        public long NomerPolisa { get; set; }
        [Display(Name = "Дата начала")]
        public byte[] DataNachala { get; set; }
        [Display(Name = "Дата окончания")]
        public byte[] DataOkonchaniya { get; set; }
        [Display(Name = "Стоимость")]
        public double Stoimost { get; set; }
        [Display(Name = "Сумма выплаты")]
        public double SummaVyplaty { get; set; }
        [Display(Name = "Отметка об оплате")]
        public string OtmetkaOVyplate { get; set; }
        [Display(Name = "Отметка об окончании")]
        public string OtmetkaObOkonchanii { get; set; }
        [Display(Name = "Код вида полиса")]
        public long KodVidaPolisa { get; set; }
        [Display(Name = "Код клиента")]
        public long KodKlienta { get; set; }
        [Display(Name = "Код сотрудника")]
        public long KodSotrudnika { get; set; }

        public virtual Klienty KodKlientaNavigation { get; set; }
        public virtual Sotrudniki KodSotrudnikaNavigation { get; set; }
        public virtual VidyPolisov KodVidaPolisaNavigation { get; set; }
    }
}
