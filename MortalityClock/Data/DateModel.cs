using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MortalityClock.Data
{
    public class DateModel
    {

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public DateTime DeathDate{ get; set; }

    }
}
