using HappyPeople.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HappyPpl.Models.Data
{
    public class CountryVote
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }
        
        public string CountryId { get; set; }

        public double Rate { get; set; }

        public bool IsInhabitant { get; set; }
    }
}