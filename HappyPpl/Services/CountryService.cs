using HappyPeople.Models;
using HappyPeople.Models.Web;
using HappyPpl.Models.Data;
using HappyPpl.Models.Request;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HappyPeople.Services
{
    public class CountryService
    {
        #region

        public void ClearAllVotes()
        {
            using(var dbContext = new HappyDbContext())
            {
                dbContext.CountryVotes.RemoveRange(dbContext.CountryVotes);
                dbContext.SaveChanges();
            }
        }

        public void ClearVotes(string countryId)
        {
            using (var dbContext = new HappyDbContext())
            {
                dbContext.CountryVotes.RemoveRange(dbContext.CountryVotes.Where(x => x.CountryId == countryId));
                dbContext.SaveChanges();
            }
        }

        #endregion

        public IEnumerable<IndexInfo> GetCountryTextInfo(string countryId)
        {
            using(var dbContext = new HappyDbContext())
            {
                List<Models.Data.IndexInfo> countryIndexInfoList = dbContext.IndexInfos.Where(x => x.CountryId == countryId).ToList();

                return (from c in IndexContacts.DefaultIndexInfo
                        join ci in countryIndexInfoList on c.Name equals ci.Name into _ci
                        from ci in _ci.DefaultIfEmpty()
                        select new IndexInfo
                        {
                            Name = c.Name,
                            Details = ci == null ? c.Details : ci.Details,
                            Text = ci == null ? c.Text : ci.Text,
                            WaysToImprove = ci == null ? c.WaysToImprove : ci.WaysToImprove,
                        });
            }
        }

        public void AddCountryVote(CountryVoteRequest countryVoteRequest)
        {
            using(var dbContext = new HappyDbContext())
            {
                dbContext.CountryVotes.Add(new CountryVote()
                {
                    Id =           Guid.NewGuid(),
                    Rate =         countryVoteRequest.Rate,
                    CountryId =    countryVoteRequest.CountryId,
                    IsInhabitant = countryVoteRequest.IsInhabitant,
                });
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<CountryInfo> GetCountryInfos()
        {
            using(var dbContext = new HappyDbContext())
            {
                 List<CountryInfo> countryInfoList = dbContext.Database.SqlQuery<CountryInfo>("GetCounties").ToList();
                 return countryInfoList;
            }
        }

        //public CountryDetails GetCountryInfos(string countryId)
        //{
        //    using(var dbContext = new HappyDbContext())
        //    {
        //        var infrastructureQry = dbContext.IndexInfos.Where(x => x.Name == IndexContacts.Infrastructure);
        //        var natureQry         = dbContext.IndexInfos.Where(x => x.Name == IndexContacts.Nature);
        //        var judgeQry          = dbContext.IndexInfos.Where(x => x.Name == IndexContacts.Judge);
        //        var hungerQry         = dbContext.IndexInfos.Where(x => x.Name == IndexContacts.Hunger);
                
        //        var countryDataQry =
        //            from c in dbContext.Countries
        //            join cd in dbContext.CountryDatas on c.Id equals cd.CountryId
        //            join cv in dbContext.CountryVotes on c.Id equals cv.CountryId into _cv
        //            select new
        //            {
        //                Name = c.Name,
        //                Id = c.Id,
        //                ISO2 = c.ISO2,
        //                InfrastructureIndex = cd.LPI,
        //                HungerIndex = (cd.DFD + cd.FPI + cd.WATP) / 3,
        //                NatureIndex = (cd.CO2 + cd.IF + cd.ABDIS + cd.PISF + cd.PIST + cd.RLI) / 6,
        //                JudgeIndex = (cd.CrimeIndex + cd.Deaths) / 2,

        //                UsersVotesAmount = _cv.Count(x => !x.IsInhabitant),
        //                AvarageUsersRating = _cv.Where(x => !x.IsInhabitant).Select(x => x.Rate).DefaultIfEmpty().Average(),
        //                InhabitantsVotesAmount = _cv.Count(x => x.IsInhabitant),
        //                AvarageInhabitantsRating = _cv.Where(x => x.IsInhabitant).Select(x => x.Rate).DefaultIfEmpty().Average(),
        //            };


        //        CountryDetails countryDetail =
        //           (from c in countryDataQry
        //            from i in infrastructureQry
        //            from n in natureQry
        //            from j in judgeQry
        //            from h in hungerQry
        //            where c.Id == countryId
        //            select new
        //            {
        //                Id = c.Id,
        //                Name = c.Name,
        //                ISO2 = c.ISO2,
        //                UsersVotesAmount = c.UsersVotesAmount,
        //                AvarageUsersRating = c.AvarageUsersRating,
        //                InhabitantsVotesAmount = c.InhabitantsVotesAmount,
        //                AvarageInhabitantsRating = c.AvarageInhabitantsRating,
        //                HappyIndex = (c.HungerIndex + c.InfrastructureIndex + c.JudgeIndex + c.NatureIndex) / 4,
        //                Infrastructure = new
        //                {
        //                    Name          = IndexContacts.Infrastructure,
        //                    Index         = c.InfrastructureIndex,
        //                    Text          = i.Text,
        //                    WaysToImprove = i.WaysToImprove,
        //                    Details       = i.Details,
        //                },
        //                Hunger = new
        //                {
        //                    Name          = IndexContacts.Hunger,
        //                    Index         = c.HungerIndex,
        //                    Text          = h.Text,
        //                    WaysToImprove = h.WaysToImprove,
        //                    Details       = h.Details,
        //                },
        //                Nature = new
        //                {
        //                    Name          = IndexContacts.Nature,
        //                    Index         = c.NatureIndex,
        //                    Text          = n.Text,
        //                    WaysToImprove = n.WaysToImprove,
        //                    Details       = n.Details,
        //                },
        //                Judge = new
        //                {
        //                    Name          = IndexContacts.Judge,
        //                    Index         = c.JudgeIndex,
        //                    Text          = j.Text,
        //                    WaysToImprove = j.WaysToImprove,
        //                    Details       = j.Details,
        //                },                        
        //            })
        //            .ToList()
        //            .Select(x =>
        //            {
        //                var indexInfoList = new List<IndexInfo>();

        //                indexInfoList.Add(GetIndexInfo(x.Judge.Index, x.Judge.Name, x.Judge.Text, x.Judge.WaysToImprove, x.Judge.Details));
        //                indexInfoList.Add(GetIndexInfo(x.Nature.Index, x.Nature.Name, x.Nature.Text, x.Nature.WaysToImprove, x.Nature.Details));
        //                indexInfoList.Add(GetIndexInfo(x.Infrastructure.Index, x.Infrastructure.Name, x.Infrastructure.Text, x.Infrastructure.WaysToImprove, x.Infrastructure.Details));
        //                indexInfoList.Add(GetIndexInfo(x.Hunger.Index, x.Hunger.Name, x.Hunger.Text, x.Hunger.WaysToImprove, x.Hunger.Details));

        //                return new CountryDetails()
        //                {
        //                    Id = x.Id,
        //                    ISO2 = x.ISO2,
        //                    Name = x.Name,
        //                    HappyIndex = x.HappyIndex,

        //                    AvarageInhabitantsRating = x.AvarageInhabitantsRating,
        //                    AvarageUsersRating = x.AvarageUsersRating,
        //                    UserVotesAmount = x.UsersVotesAmount,
        //                    InhabitantsVotesAmount = x.InhabitantsVotesAmount,

        //                    Infos = indexInfoList,
        //                };
        //            })
        //            .FirstOrDefault();

        //        return countryDetail;
        //    }            
        //}

        private IndexInfo GetIndexInfo(double index, string name, string text, string watsToImprove, string details)
        {
            return new IndexInfo()
            {
                Name          = name,
                Details       = details,
                Text          = text,
                WaysToImprove = watsToImprove,
            };
        }
    }
}