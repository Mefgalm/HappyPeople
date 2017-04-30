using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyPeople.Models.Web
{
    public class IndexInfo
    {
        public string  Name { get; set; }

        public string Text { get; set; }

        public string WaysToImprove { get; set; }

        public string Details { get; set; }
    }

    public class CountryDetails
    {
        public string Id { get; set; }

        public string ISO2 { get; set; }

        public string Name { get; set; }

        public double HappyIndex { get; set; }

        public int UserVotesAmount { get; set; }

        public double AvarageUsersRating { get; set; }

        public int InhabitantsVotesAmount { get; set; }

        public double AvarageInhabitantsRating { get; set; }

        public IEnumerable<IndexInfo> Infos { get; set; }
    }
}