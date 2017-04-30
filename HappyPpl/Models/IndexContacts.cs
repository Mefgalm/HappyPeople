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
                Text = @"In this area can be increased amount of people that were affected by geographical disasters like earthquake, volcanic eruptions, mass movement, tsunami, etc.  and climate related events such as floods and storms. One of the points that is affects the Nature Index is CO2 emissions.  There are both natural and human sources of carbon dioxide emissions. Natural sources include decomposition, ocean release and respiration. Human sources come from activities like cement production, deforestation as well as the burning of fossil fuels like coal, oil and natural gas.",
                WaysToImprove = @"There are couple simple rules that helps save environment and help Earth nature become happier.
1) Turn off all electric device when you don’t use it.
2) Unplug your electronic device when possible.
3) Try avoid using electric devices if you have such ability.e.g.: use clothesline instead of dryer for clothes; open window instead of conditioner.
4) Use real bicycle or jogging instead of electronic sport attributes
5) Try to wear warm cloth instead of using heater
6) Conserve water!
7) Recycle cans, plastic bottles and batteries
8) And don't forget to plant trees when you have such ability.Think about future, think about your home.",
            },
            new IndexInfo()
            {
                Name = Infrastructure,
                Details = "infrastructure datails",
                Text = "Infrastructure index is low in this country. It is mostly the outcome of the unequal diffusion of transport infrastructures and services, a process favored by the growing presence of global freight carriers, such as maritime shipping companies, global terminal operators, air freight and even third party logistics providers. These providers structure their networks and allocate their assets to maximize their revenue. Can be caused by high costs of logistic performance, unreliable supply chains, quality of service, customs efficiency and shipment reliability. Also, it depends on soft and hard infrastructure.",
                WaysToImprove = "Countries with low logistics performance need to reform their border management, focus on infrastructure and critical improvements in customs. It can be done by cutting red tape, excessive and opaque procedural requirements, and physical inspections. Also, road conditions should be improved.",
            },
            new IndexInfo()
            {
                Name = Judge,
                Details = "judge datails",
                Text = @"Judge index is calculated with the help of three indexes: crime index, Life expectancy at birth, armed conflict-related fatalities. 
Crime index can be committed due to poor earning power, unemployment, or economic frustration, alcohol and drugs. 
Also the real human cost of armed conflict goes beyond the numbers of soldiers and civilians that lose their lives in military operations but it also includes the victims of the consequences of war.  These also include those who die due to limited or inexistent access to basic health care, adequate food and shelter, and clean water. They are the so-called ‘indirect conflict deaths’.",
                WaysToImprove = @"While personal behavior has a major impact on crime, state and local law enforcement identify, investigate, and respond to crime. 
The criminal justice mandate involves direct criminal apprehension and detention as well as the provision of criminal justice training, resources, and technical assistance.
Government should improve crime prevention and criminal justice system through assessments, advice and programme support to policies and strategies; tools development and training, also to support policies and strategies; standards and norms development or update.",
            },
            new IndexInfo()
            {
                Name = Hunger,
                Details = "hunger details",
                Text = @"Hunger is a social problem all over the world. Can be solved by increasing total grain production, yield increase or improve land productivity. Also water shortage can be a huge problem in many parts of the world.  One of the common problem in depth of food deficit is lack of cache income. But also can be connected with food production/usage/utilization, food disappearance, food consumption level, trade and distribution of food. Food production index is low due to low quantity of produced products and harvest gathered of particular crop. It includes reference to Crops, Livestock, Poultry and Fisheries. 
In 2015 the global community adopted the 17 Global Goals for Sustainable Development to improve people’s lives by 2030. Goal 2 – Zero Hunger – pledges to end hunger, achieve food security, improve nutrition and promote sustainable agriculture, and is the priority of the World Food Programme.",
                WaysToImprove = "he world has made great progress in reducing hunger: There are 216 million fewer hungry people than in 1990-92, despite a 1.9 billion increase in the world’s population. But there is still a long way to go, and no one organization can achieve Zero Hunger if it works alone. If we want to see a world free of hunger by 2030, governments, citizens, civil society organizations and the private sector must collaborate to invest, innovate and create lasting solutions.To grow the index of depth of food deficit we need to aggregate data for the land of  country and develop plan to optimize land resources.",
            },
        };
    }
}