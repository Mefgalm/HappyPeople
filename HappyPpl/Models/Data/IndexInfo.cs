using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HappyPeople.Models.Data
{
    public class IndexInfo
    {
        [Key]
        [Column(Order = 1)]
        public string CountryId { get; set; }

        [Key]
        [Column(Order = 2 )]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }
        
        public string Details { get; set; }

        [Required]
        public string WaysToImprove { get; set; }
    }
}