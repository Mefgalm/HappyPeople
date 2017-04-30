using HappyPeople.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HappyPeople.Models
{
    public class IndexContacts
    {
        public const string Infrastructure = "Infrastructure";
        public const string Nature = "Nature";
        public const string Hunger = "Hunger";
        public const string Judge = "Judge";

        public static readonly List<IndexInfo> DefaultIndexInfo = new List<IndexInfo>()
        {
            new IndexInfo()
            {
                Name = Nature,
                Details = "nature details",
                Text = "nature text",
                WaysToImprove = "nature ways to improve",
            },
            new IndexInfo()
            {
                Name = Infrastructure,
                Details = "infrastructure datails",
                Text = "Infrastructure index is low in this country. It can be caused by high costs of logistic performance, unreliable supply chains, quality of service, customs efficiency and shipment reliability. Also, it depends on soft and hard infrastructure.",
                WaysToImprove = "Countries with low logistics performance need to reform their border management, focus on infrastructure and critical improvements in customs. It can be done by cutting red tape, excessive and opaque procedural requirements, and physical inspections. Also, road conditions should be improved.",
            },
            new IndexInfo()
            {
                Name = Judge,
                Details = "judge datails",
                Text = "judge text",
                WaysToImprove = "judge ways to improve",
            },
            new IndexInfo()
            {
                Name = Hunger,
                Details = "hunger details",
                Text = "hunger text",
                WaysToImprove = "hunger ways to improve",
            },
        };
    }
}