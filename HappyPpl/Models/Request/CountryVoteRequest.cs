using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HappyPpl.Models.Request
{
    public class CountryVoteRequest
    {
        public string CountryId { get; set; }

        public double Rate { get; set; }

        public bool IsInhabitant { get; set; }
    }
}