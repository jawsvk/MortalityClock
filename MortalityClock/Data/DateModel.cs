using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MortalityClock.Data
{
    public class DateModel
    {

        public DateTime BirthDate { get; set; }

        public DateTime DeathDate{ get; set; }

        public DateModel()
        {
            BirthDate = DateTime.Today.AddYears(-21);
            DeathDate = DateTime.Today;
        }
    }
}
