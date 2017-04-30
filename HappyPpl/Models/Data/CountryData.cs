using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HappyPeople.Models.Data
{
    public class CountryData
    {
        [Key]
        public string CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country Country { get; set; }

        public double LPI { get; set; }

        public double DFD { get; set; }

        public double FPI { get; set; }

        public double WATP { get; set; }

        public double ABDIS { get; set; }

        public double CO2 { get; set; }

        public double CrimeIndex { get; set; }

        public double LEAB { get; set; }

        public double Deaths { get; set; }

        public double IF { get; set; }

        public double PISF { get; set; }

        public double PIST { get; set; }

        public double RLI { get; set; }
    }
}