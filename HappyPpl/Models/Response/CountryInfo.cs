using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyPeople.Models.Web
{
    public class CountryInfo
    {
        public string Id { get; set; }

        public string ISO2 { get; set; }

        public string Name { get; set; }

        public double HappyIndex { get; set; }

        public double HungerIndex { get; set; }

        public double NatureIndex { get; set; }

        public double InfrastructureIndex { get; set; }

        public double JudgeIndex { get; set; }

        public int UserVotesAmount { get; set; }

        public double AvarageUsersRating { get; set; }

        public int InhabitantsVotesAmount { get; set; }

        public double AvarageInhabitantsRating { get; set; }
    }
}
