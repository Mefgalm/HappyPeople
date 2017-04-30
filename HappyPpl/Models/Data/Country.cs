using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HappyPeople.Models.Data
{
    public class Country
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string ISO2 { get; set; }

        [Required]
        public string Name { get; set; }
    }
}