using HappyPeople.Models.Web;
using HappyPeople.Services;
using HappyPeople.Utils;
using HappyPpl.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HappyPeople.Controllers
{
    public class InfoController : ApiController
    {
        [HttpGet]
        public IEnumerable<CountryInfo> Countries()
        {
            var countryService = new CountryService();

            return countryService.GetCountryInfos();
        }

        //[HttpGet]
        //public CountryDetails CountryInfo(string Id)
        //{
        //    var countryService = new CountryService();

        //    CountryDetails countryInfo = countryService.GetCountryInfos(Id);
        //    return countryInfo;
        //}

        [HttpGet]
        public IEnumerable<IndexInfo> GetCountryTextInfo(string countryId)
        {
            var countryService = new CountryService();

            return countryService.GetCountryTextInfo(countryId); 
        }

        [HttpPost]
        public void UserRate(CountryVoteRequest request)
        {
            var countryService = new CountryService();

            countryService.AddCountryVote(request);
        }

        [HttpGet]
        public string ClearAllVotes()
        {
            var countryService = new CountryService();
            countryService.ClearAllVotes();

            return "Ok";
        }

        [HttpGet]
        public string ClearVotes(string countryId)
        {
            var countryService = new CountryService();
            countryService.ClearVotes(countryId);

            return "Ok";
        }
    }
}
