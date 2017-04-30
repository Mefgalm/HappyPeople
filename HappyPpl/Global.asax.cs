using HappyPeople.Models;
using HappyPeople.Services;
using HappyPeople.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace HappyPpl
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HappyDbContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<HappyDbContext>());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //SetUpCountryData();
            //AddIndexInfo();
        }

        private void AddIndexInfo()
        {
            using (var happyContext = new HappyDbContext())
            {
                happyContext.IndexInfos.RemoveRange(happyContext.IndexInfos);
                happyContext.SaveChanges();                

                //Qatar
                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "QAT",
                    Name = IndexContacts.Infrastructure,
                    Text = "In 2015 Qatar was the world’s third richest economy in terms of GDP per capita. The transformation of Qatar is now well underway as it continues to progress its ambitious programme of large scale infrastructure projects. Qatar has strong growth potential, secure business environment and stable political system. As Qatar prepares itself for the FIFA World Cup 2022 and in order to meet its National Vision 2030, the country is investing heavily in developing infrastructure and construction projects, with USD 220+ billion to be invested in: new roads, stadiums, facilities, and numerous major projects including hotels, leisure, and recreation in the planning or construction phase.",
                    WaysToImprove = "Encourage even more private investments in infrastructure.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "QAT",
                    Name = IndexContacts.Judge,
                    Text = "The Qatari Ministry of Interior reported that Qatar was the top Middle Eastern country for security over the previous five years, based on the Global Peace Index and 2015 statistical data. The government monitors crime trends carefully and expends great effort to keep pace with it via improved enforcement capabilities in an effort to identify, deter, and neutralize emerging crime trends. The country reports a low number of violent incidents and crime. Murder rates reported in recent years are well below global averages. 2015 data from the Ministry of Interior showed that registered homicides were 97.5% lower than the global average. Government authorities indicate that rates of crimes such as kidnapping, assault, and arson are low compared to the rest of the region.",
                    WaysToImprove = "Enjoy.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "QAT",
                    Name = IndexContacts.Hunger,
                    Text = "Qatar is located in one of the driest and water-stressed regions in the world. Low rainfall, high evaporation rates and a lack of arable land limit its ability to produce food, driving it to depend on imports to meet 90 per cent of its consumption needs. Abundant hydrocarbon reserves ensure that Qatar can maintain its comfortable level of food security through trade; supply risks remain, however, due to geopolitical tensions and global food price spikes. Though the Qatari government has shown a strong commitment towards ensuring food self-sufficiency through ambitious strategies to boost agricultural production and diversify its food supply sources, it is likely Qatar will continue to depend on imports significant portion of its food needs despite the successful implementation of these strategies.",
                    WaysToImprove = "To grow food near your house.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "QAT",
                    Name = IndexContacts.Nature,
                    Text = @"Qatar’s environmental record has been improving over the past several years, but it is still among the top consumers of productive land and water, states a new report from the World Wildlife Fund.
The Gulf country is now ranked as having the second-highest ecological footprint globally, down from holding the top spot in 2012, according to the WWF’s Living Planet Report 2014.
Despite Qatar’s marginal improvement, the report warns that the state’s consumption remains unsustainable, saying “if all people on the planet had the footprint of the average resident of Qatar, we would need 4.8 planets.”
Based on the latest available (2010) figures, Qatar’s footprint measured approximately 8.5 global hectares (gha) – the second highest figure in the world. This means it consumed and wasted more resources per person than almost every other country globally.",
                    WaysToImprove = "The country should encourage the use of renewable and clean energy sources such as solar and power sources. Consequently, energy efficiency measures should also be identified and undertaken to exploit energy sources in the best way possible. Furthermore, different processes must be implemented that reduce CO2 emission from fossil fuel power plants; this can be done in various ways but tends to be costly.",
                });

                //Zimbabwe
                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "ZWE",
                    Name = IndexContacts.Infrastructure,
                    Text = @"Despite general economic decline and power-supply deficiencies, infrastructure made a modest net contribution of just less than half a percentage point to Zimbabwe's improved per capita growth performance in recent years. Raising the country's infrastructure endowment to that of the region's middle-income countries could boost annual growth by about 2.4 percentage points. Zimbabwe made significant progress in infrastructure in its early period as an independent state, building a national electricity network with regional interconnections, an extensive and internationally connected road network, and a water and sewer system. But the country has been unable to maintain its existing infrastructure since it became immersed in economic and political turmoil in the late 1990s. Zimbabwe now faces a number of important infrastructure challenges, the most pressing of which lie in the power and water sectors, where deteriorating conditions pose risks to the economy and public health. Zimbabwe currently spends about $0.8 billion per year on infrastructure, though $0.7 billion of this is lost to inefficiencies of various kinds.",
                    WaysToImprove = "Concerning logistics infrastructure, upgrades to road and rail networks should be prioritised together with ports of entry/exit and container handling terminals. This will call for ongoing capital investment.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "ZWE",
                    Name = IndexContacts.Judge,
                    Text = @"The crime rate in Zimbabwe is medium compared to industrialized countries. Index offenses include murder, forcible rape, robbery, aggravated assault, burglary, larceny, and motor vehicle theft. Although the majority of crimes in Zimbabwe are non-violent, perpetrators are generally armed with weapons, which can include firearms. Travelers should always secure their luggage, particularly in public areas such as airports and bus stops. Purse-snatchers will often work in teams of two, with one person acting as a diversion. 
Life expectancy at birth, male (years) in Zimbabwe was at 57.72 years and female (years) was 59.16 in 2015, according to the World Bank collection of development indicators, compiled from officially recognized sources.",
                    WaysToImprove = "While personal behavior has a major impact on crime, local law enforcement identify, investigate, and respond to crime. The criminal justice mandate involves direct criminal apprehension and detention as well as the provision of criminal justice training, resources, and technical assistance.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "ZWE",
                    Name = IndexContacts.Hunger,
                    Text = @"Depth of hunger (kilocalories per person per day) in Zimbabwe was at 259 in 2016, according to the World Bank collection of development indicators, compiled from officially recognized sources. 
Zimbabwe is a landlocked, low-income, food deficit country in Southern Africa. At the peak of the 2017 lean season, 4.1 million people were estimated to be food-insecure because of the El Niño-induced drought.
The factors which have exacerbated Zimbabwe’s food security situation to “serious” according to the 2016 Global Hunger Index are manifold. Widespread poverty, HIV/AIDS, limited employment opportunities, liquidity challenges, recurrent climate-induced shocks and economic instability all contribute to limiting adequate access to food.
Low-productivity agricultural practices and lack of access to markets are also affecting the food security of the vast majority of rural Zimbabweans, whose livelihoods depend on own production. Undernutrition rates are high, especially in rural districts where diets lack diversity – maize being the main staple – and are poor in essential nutrients.
A Zero Hunger Strategic Review of the food security situation carried out in 2015 highlighted the root causes of hunger, the gaps in support, and the areas where WFP could add value.",
                    WaysToImprove = "Innovative programmes are needed to end hunger at scale in Zimbabwe. The World Food Programme (WFP) will continue developing and implementing innovations in analysis and mapping, technology and systems, emergency preparedness, supply chain and delivery choices. Under its Country Strategic Plan 2017-2021, WFP will work towards eradicating hunger and ensure better nutrition through six strategic outcomes, the activities of which are closely inter-linked, amplifying results.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "ZWE",
                    Name = IndexContacts.Nature,
                    Text = @"Despite of only 35% of forest area, Zimbabwe has low level of CO2 emissions because of small amount of vehicles. There are active actions for saving fresh water and biodiversity. But they won’t finish to make their life better.",
                    WaysToImprove = "Plant a tree. Use of organic fertiliser (manure, poultry litter, dead organic matter) is given priority over chemical fertiliser. Forest fires can be avoided and tamed through education and training on fire prevention and firefighting.",
                });

                //Ukraine
                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "UKR",
                    Name = IndexContacts.Infrastructure,
                    Text = @"Ukraine’s advantageous geographical position makes it inevitable destination for transit of goods and passengers between Europe, Asia and Middle East. Through the territory of Ukraine goes a number of international transport corridors reaching a total length of over 5 thousand km. Ukraine’s highways network is also quite extensive, it covers all the territory of the country; however, the quality of the road surface and automotive infrastructure is in need of some improvement. There is a number of port terminal and airport development projects financed by commercial and government entities; however, current investment volumes are insufficient and will not allow for increase of freight and passenger traffic significantly.",
                    WaysToImprove = "Large-scale infrastructure projects, such as reconstruction of a number of roads, the reconstruction of major international airports, etc. are planned to be implemented.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "UKR",
                    Name = IndexContacts.Judge,
                    Text = @"The number of property crimes (theft, burglaries, armed assaults, fraud) constituted more than half of all criminal offenses reported. 
The most common types of non-violent property crime affecting the expatriate community include: pickpocketing, theft from parked vehicles, and residential burglaries. Residential burglaries are typically committed by forced entry when the occupant is not at home or as crimes of opportunity when doors are found unlocked.
Since the spring of 2014, conflict between Ukrainian forces and separatists in the east of the country has triggered a humanitarian crisis. The conflict has killed more than 9,000 people and caused renewed hardship and deprivation. The country has lost territory; cities and towns have been devastated; more than two million people have been forced from their homes and exposed to harsh winter conditions.
Due in part to the ongoing conflict in the east, illegal weapons-related crimes significantly increased from 2015. Also because of conflict in the East, armed conflict-related fatalities are increasing each day. This is the main criteria that makes Happy Index so low.",
                    WaysToImprove = "Stop the War and live Happy Life.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "UKR",
                    Name = IndexContacts.Hunger,
                    Text = @"Ukraine is the largest country to be located entirely in Europe. Arable land covers more than half of its area. Much of it is humus-rich, high-yielding “black earth”. Despite this natural advantage, the agricultural sector shrank drastically in the early post-Soviet era as the collective farming system collapsed. GDP growth in the new millennium partly offset this decline, but came to a sharp end as the world economy entered crisis in the late 2000s.
Ukraine is now a lower middle income country, ranked 81st out of 188 in the 2015 Human Development Index. Its population has been declining at a rapid rate to an estimated 45.2 million in 2015 – a loss of more than 6 million people since independence in 1991.
Hundreds of thousands of civilians in conflict or former conflict areas have limited access to basic sustenance and services. Government support to public services has stopped in some areas; this includes funding to schools and hospitals, as well as the payment of social benefits and pensions. 
Many of the displaced have lost their jobs, and their financial resources are thought to be exhausted. Food inflation is among the highest in the world. The significant devaluation of national currency (estimated at as much as 50 percent) has seen consumer prices growing at a faster pace than families' incomes, limiting their purchasing power and general access to food. 620,000 people in eastern Ukraine are estimated to be food insecure, and additional 500,000 have little or no livelihood.",
                    WaysToImprove = "Help to increase production of wheat and other agricultural commodities.",
                });

                happyContext.IndexInfos.Add(new HappyPeople.Models.Data.IndexInfo()
                {
                    CountryId = "UKR",
                    Name = IndexContacts.Nature,
                    Text = @"Relying on energy intensive production technologies, Ukraine’s heavy industry also causes high emission rates of GHG. For instance, steelmaking in Ukraine requires four times more energy in Ukraine than in China (OECD 2012). In a separate paper, we estimate the annual potential of reducing GHG emissions for the Ukrainian metal industry to reach a level of 52 Mt per year in terms of CO2 equivalent if switching to efficiency based technologies available today (see DIW econ 2012c). With an aggregate GHG emission of 383 million metric tons of CO2 equivalent (UNFCC 2012a)2, Ukraine is placed among the twenty countries with the highest emissions worldwide (European Commission 2011).",
                    WaysToImprove = "The fastest way how you can help our nation is very simple. You just need to go into your yard and water the plant. Next  step, to go into your yard and plant the tree. Other steps are more global but also can be done. Sustainable forest management and the multifunctional role of forests, delivering multiple goods and services in a balanced way and ensuring forest protection. Resource efficiency, optimising the contribution of forests and the wood-based sector to rural development, economic growth and job creation. Global forest responsibility, promoting sustainable production and consumption of forest products.",
                });

                happyContext.SaveChanges();
           }
        }

        private void SetUpCountryData()
        {
            string data = @"
Aruba	ABW	0,4878825444	1	0	0	1	0,7900950752	0,5186940818	0,896717354	1	0,0237411918	0,2199819549	0	0,9322033898
Afghanistan	AFG	0,2066336967	0,6831501832	0,5616008248	0,0006656289947	0,9996850071	0,9835497954	0,1461076313	0,7204387145	0,9739035477	0,02103970155	0,1667	0,0625	0,7457627119
Angola	AGO	0,2446529116	0,8351648352	1	0,096523011	1	0,9664526159	0,2527163492	0,6249088582	1	0,472185104	0,3333	0,2609	0,9152542373
Albania	ALB	0,3098500749	1	0,5991845916	0,006576705457	1	0,9595849616	0,5242234437	0,9256794622	1	0,2864910734	0,75	0,375	0,7627118644
Andorra	AND	0,4878825444	1	0	0	1	0,8405855124	0,5186940818	0	1	0,3463760677	0,2308	0	0,8813559322
UAE	ARE	0,8918423151	0,967032967	0,319555743	0,05860143199	1	0,8844830371	0,8260258213	0,920064477	1	0,03926303939	0,2199819549	0,1765	0,7966101695
Argentina	ARG	0,5192128313	0,9963369963	0,5548994798	0,007939379247	1	0,5380111405	0,2895308705	0,9057425985	1	0,1008002784	0,2195	0,1471	0,7796610169
Armenia	ARM	0,2310780185	0,9249084249	0,6055578987	0,0025539433	1	0,89033408	0,7439601176	0,8875041603	1	0,1186523887	0,1429	0,1053	0,7457627119
American Samoa	ASM	0,4878825444	1	0,511036131	0	1	0,9552600723	0,5186940818	0	1	0,8923297794	0,2199819549	0	0,7457627119
Antigua and Barbuda	ATG	0,4878825444	1	0,4166080885	0,07098270689	0,9999655327	0,8565724472	0,5186940818	0,9029660748	1	0,2266205273	0,2199819549	0	0,8305084746
Australia	AUS	0,8353727387	1	0,5601012231	0,04350887547	1	0,5964006328	0,5478716605	0,9783237747	1	0,1652261018	0,175	0,2328	0,7288135593
Austria	AUT	0,9512940294	1	0,4778105816	0,07876200554	1	0,818668295	0,8440495973	0,9711176279	1	0,4770342092	0,1	0,0909	0,8474576271
Azerbaijan	AZE	0,4878825444	0,978021978	0,6551384788	0,003293619533	1	0,9070829416	1	0,8406551884	1	0,1402461589	0,0526	0,0377	0,8644067797
Burundi	BDI	0,3468710575	1	0,6786166175	0,005638339122	1	1	0,5186940818	0,6776028871	1	0,1093552688	0,4286	0,4	0,8813559322
Belgium	BEL	0,9553101732	1	0,4770139182	0,05631065063	1	0,7936503709	0,5211555669	0,9645192313	1	0,2296385759	0	0,1622	1
Benin	BEN	0,3157972253	0,9120879121	0,7104362904	0,0445455098	1	0,9868026996	0,5186940818	0,7086152326	1	0,388999212	0,2199819549	0,6667	0,8644067797
Burkina Faso	BFA	0,4309897265	0,6941391941	0,5807207461	0,009262208459	1	0,9962660937	0,5186940818	0,6992483808	1	0,1989589147	0,5	0,6	1
Bangladesh	BGD	0,4055266217	0,7875457875	0,6343315057	0,002767314548	1	0,9898426411	0,2306020708	0,8543292115	1	0,1116984231	0	0,1053	0,6271186441
Bulgaria	BGR	0,4602459617	1	0,5644125779	0,00651211679	1	0,8660143744	0,576505177	0,8835734809	1	0,3583111056	0,92	0,8718	0,9152542373
Bahrain	BHR	0,6529417026	1	0,9692581658	0,05653451092	1	0,414988699	0,6382461971	0,9114959352	1	0,007918129506	0,2199819549	0	0,7627118644
Bahamas	BHS	0,4878825444	1	0,6272552603	0	1	0,7971543241	0,282116835	0,8946200108	1	0,5234786006	0,2199819549	0	0,5254237288
Bosnia-Herzegovina	BIH	0,379781896	1	0,5481981349	0,03657115132	1	0,8589961055	0,5664067493	0,9087608221	1	0,4342174385	0,2199819549	0,1954876289	0,7633080658
Belarus	BLR	0,3048014477	1	0,5899526688	0,02718960833	1	0,8340859858	0,8055733095	0,8735891493	1	0,4329215762	0	0	0,9661016949
Belize	BLZ	0,4878825444	0,9267399267	0,4787946952	0,01044256823	1	0,9635415994	0,5186940818	0,8328665649	1	0,6094619516	0	0	0,593220339
Bermuda	BMU	0,4878825444	1	0,5612727869	0	1	0,8625671057	0,5186940818	0,9612491034	1	0,2034959588	0,2199819549	0,5	0,3559322034
Bolivia	BOL	0,2485647795	0,8095238095	0,6350813065	0,00791538674	0,9972579342	0,9538391758	0,3295410968	0,8156288618	1	0,5143659498	0	0,2679	0,7966101695
Brazil	BRA	0,5669190473	0,9816849817	0,6403767749	0,02185317639	1	0,9397086585	0,1873961396	0,8860655888	1	0,6008094052	0	0,2387	0,8474576271
Barbados	BRB	0,4878825444	0,9615384615	0,4553634191	0,03751107282	1	0,8738887228	0,5186940818	0,8977241405	1	0,1490725926	0,2199819549	0	0,8644067797
Brunei	BRN	0,4841483534	0,978021978	0,7837293219	0,1006705477	1	0,5328051683	0,6290425668	0,9378578408	1	0,7336666258	0,5	0,1667	0,7288135593
Bhutan	BTN	0,2751947086	1	0,4551759689	0,00387847758	0,9962507229	0,9717304825	0,5186940818	0,8286006855	1	0,7353899313	0	0,087	0,6779661017
Botswana	BWA	0,5507349737	0,6758241758	0,6090257275	0,05590022547	1	0,9390666298	0,3459031062	0,7651744434	1	0,1946161074	0,4286	0,3636	0,9830508475
Central African Republic	CAF	0,4878825444	0,304029304	0,5692394208	0,01272417936	1	0,9991338054	0,5186940818	0,6101128348	1	0,3620907378	0	0,625	0,9152542373
Canada	CAN	0,8876332229	1	0,5408875767	0,03097120697	1	0,6660194444	0,5883931995	0,974602877	1	0,3883381553	0,0073	0,0232	0,9661016949
Switzerland	CHE	0,9091167186	1	0,4735929519	0,2090487474	1	0,8773377721	0,8031445737	0,9871794613	1	0,3228868344	0,3333	0,1613	0,9830508475
Chile	CHL	0,6279843738	0,9633699634	0,550072637	0,004902057494	0,9965810346	0,8836605924	0,4829349354	0,9704491264	1	0,2426930452	0	0,0763	0,6271186441
China	CHN	0,7850307024	0,8644688645	0,6066825999	0,00925839991	1	0,8139480486	0,656781286	0,9016148333	1	0,2257754086	0,2075	0,3105	0,593220339
Cameroon	CMR	0,2105219693	0,8846153846	0,7505974975	0,0201032765	1	0,9931068476	0,5186940818	0,6636887066	1	0,4050030499	0,5	0,25	0,7288135593
CDR	COD	0,4878825444	1	0,5487604855	0,02744933921	1	0,9997457359	0,5186940818	0,7003472434	0,9982649667	0,684788728	0,1053	0,1176	0,8305084746
Congo	COG	0,4878825444	0,6227106227	0,637330709	0,2090136331	1	0,9867213084	0,5186940818	0,7459553229	1	0,6654288347	1	0,4444	0,9830508475
Colombia	COL	0,3859079137	0,8864468864	0,5462767702	0,01999188995	0,7065118319	0,9538734041	0,4293749201	0,8802057001	1	0,5364969493	0,1579	0,0822	0,5762711864
Comoros	COM	0,3732688396	1	0,5291719387	0,03998967505	0,9998678753	0,9953847387	0,5186940818	0,7540993177	1	0,2022930942	0,2199819549	0	0,6440677966
Cape Verde	CPV	0,4878825444	0,8754578755	0,415295937	0,05511903403	1	0,9790601946	0,5186940818	0,8704001813	1	0,2269762383	0,2199819549	0,1954876289	0,7633080658
Costa Rica	CRI	0,3998439667	0,9358974359	0,5787993814	0,01230140342	0,9940132201	0,9606706232	0,3750479356	0,9443320058	1	0,549191943	0,2199819549	0,0435	0,7118644068
Cuba	CUB	0,2847176845	0,9871794872	0,4836684006	0,006863329144	1	0,9150672955	0,5186940818	0,9438567931	1	0,3130104633	0,2199819549	0,2857	0,4237288136
Cayman Islands	CYM	0,4878825444	1	0,5274848868	0	1	0,77229342	0,5186940818	0	1	0,538416425	0,2199819549	0,2	0,6610169492
Cyprus	CYP	0,5330777179	1	0,3814611744	0,06083168172	1	0,871845187	0,6751885466	0,9528827494	1	0,1901718574	0,2199819549	0,1765	0,9830508475
Czech Republic	CZE	0,7900561149	1	0,4324944937	0,08763173764	1	0,7686256456	0,7043333759	0,9429877649	1	0,3514594985	0,3846	0,45	0,9661016949
Germany	DEU	1	1	0,5031632223	0,07427811455	1	0,7684494092	0,6806851591	0,9621750859	1	0,3330066884	0,281	0,3321	0,9830508475
Djibouti	DJI	0,2756148566	0,7838827839	0,6298327007	0,04889732382	1	0,9832800989	0,5186940818	0,7390496102	1	0,002458109085	0	0	0,7118644068
Denmark	DNK	0,8439009075	1	0,48090351	0,3476024712	1	0,8330232256	0,8200178959	0,9622908931	1	0,1473903933	1	0,7456	0,9830508475
Dominican Republic	DOM	0,391589427	0,8424908425	0,6350813065	0,006081939848	1	0,9476008135	0,2896586987	0,8742095955	1	0,417649001	0,5	0,4	0,5762711864
Algeria	DZA	0,4457835819	0,9633699634	0,7382726463	0,01465882088	1	0,9137675831	0,4557075291	0,8904161878	1	0,00835603246	0,2308	0,2712	0,8474576271
Ecuador	ECU	0,4493601685	0,8717948718	0,5411218895	0,005889622987	0,9751500285	0,9319573738	0,4397290042	0,9029982303	1	0,5140608076	0	0,1048	0,4915254237
Egypt	EGY	0,4878825444	0,978021978	0,5563990815	0,002058162753	1	0,9405645648	0,4144190208	0,8462102528	0,9981075388	0,0007461586322	0,2857	0,3158	0,8813559322
Eritrea	ERI	0,2182638827	1	0,5185341394	0	1	0,8818663942	0,5186940818	0,7605883145	1	0,1521183166	0	0,1333	0,8644067797
Spain	ESP	0,8102654658	1	0,5099114298	0,02478733239	1	0,874983634	0,6902722741	0,9893500146	1	0,3746389091	0,0111	0,0771	0,7627118644
Estonia	EST	0,6717676855	1	0,6268334974	0,008956106475	1	0,6269907279	0,7961140228	0,9152052047	1	0,5357430986	0,4211	0,4516	1
Ethiopia	ETH	0,2962519671	0,5677655678	0,6910351938	0,002822342676	0,9728244427	0,9979118487	0,461459798	0,766249931	0,9987649667	0,1271747995	0,1053	0,0938	0,7457627119
Finland	FIN	0,8838419954	1	0,4509583392	0,02542725638	1	0,7901653372	0,7752780263	0,9656769467	1	0,7438996236	0,2667	0,2045	1
Fiji	FJI	0,2731967218	0,9450549451	0,4021275599	0,02923723005	1	0,9526951726	0,3793940943	0,8336247694	1	0,5664917449	0,2199819549	0	0,4576271186
France	FRA	0,8763097755	1	0,4622522143	0,06120358922	1	0,8757874064	0,5320209638	0,9809283675	1	0,31569254	0,2778	0,2945	0,813559322
Faeroe Islands	FRO	0,4878825444	1	0,4856834903	0	1	0,6964643658	0,5186940818	0,9686288423	1	0,0005830871456	0,2199819549	0,0667	0,8474576271
Gabon	GAB	0,2258021917	0,967032967	0,5666151179	0,08657959226	1	0,9294203465	0,5186940818	0,7699554036	1	0,9082173194	0,5	0,5	0,9491525424
United Kingdom	GBR	0,9405178401	1	0,4695627724	0,2157678649	1	0,8242658652	0,563594529	0,9682815395	1	0,1322264849	0,1176	0,2788	0,6610169492
Georgia	GEO	0,2872119331	0,8992673993	0,4071887155	0,005317509398	1	0,9515052927	0,8238527419	0,887744911	1	0,4132587792	0	0	0,7796610169
Ghana	GHA	0,4043959515	0,9652014652	0,6734617367	0,03077369589	1	0,9868736294	0,4894541736	0,7296292451	1	0,4175181531	0,2199819549	0,675	0,7627118644
Gibraltar	GIB	0,4043959515	1	0	0	1	0,6175754612	0,5186940818	0	1	0	0,2199819549	0,1954876289	0,7633080658
Guinea	GIN	0,2894751764	0,7893772894	0,578846244	0,006411931022	1	0,9959343212	0,5186940818	0,7023589179	1	0,2635211618	1	0,56	0,8474576271
Gambia	GMB	0,4878825444	0,9413919414	0,4562538076	0,007607880185	1	0,9941837048	0,5186940818	0,7174783944	1	0,490642391	0,2199819549	0	0,9830508475
Guinea-Bissau	GNB	0,2939358247	0,7380952381	0,6595435587	0,003624977463	1	0,9970803523	0,5186940818	0,6581466942	1	0,7135384335	0,2199819549	0,125	0,9491525424
Equatorial Guinea	GNQ	0,1068896293	1	0,553727916	0,6949028246	1	0,8327571398	0,5186940818	0,6877640145	1	0,5687730364	0,2199819549	1	0,6949152542
Greece	GRC	0,6245874157	1	0,411640658	0,01717043053	1	0,8447155919	0,5747155823	0,968078877	1	0,3200049246	0,5882	0,4066	0,7627118644
Grenada	GRD	0,4878825444	1	0,4512395145	0,04041234294	1	0,9296153294	0,5186940818	0,8723861077	1	0,5084406563	0,2199819549	0,25	0,5762711864
Greenland	GRL	0,4878825444	1	0,4618773138	0	1	0,7518220285	0,5186940818	0	1	0,000005453691697	0,2199819549	0,1667	0,8813559322
Guatemala	GTM	0,334141408	0,815018315	0,708796101	0,009730180521	0,9716697879	0,9792615829	0,3285184712	0,8537987056	1	0,3361214993	0,5	0,1538	0,5423728814
Guam	GUM	0,4878825444	1	0,4524579409	0	1	0,8818663942	0,5186940818	0,9418703921	1	0,4710554979	0,2199819549	0,5	0,06779661017
Guyana	GUY	0,4067124745	0,8644688645	0,6089320024	0,001274913751	1	0,9377728777	0,5186940818	0,7891439111	1	0,8541971805	0,2199819549	0,1954876289	0,8813559322
Hong Kong	HKG	0,4878825444	1	0,2797225737	0	1	0,8458731232	0,8257701649	1	1	0	0,2199819549	0,1954876289	0,7633080658
Honduras	HND	0,3289980191	0,8443223443	0,5557430058	0,007572765905	0,99779122	0,9721310332	0,08871277004	0,8701330892	1	0,4175768617	0,2199819549	0,1429	0,593220339
Croatia	HRV	0,5946415897	1	0,4600496743	0,06113916802	1	0,8977641771	0,7347564873	0,9169126481	1	0,3494632031	1	0,2712	0,8474576271
Haiti	HTI	0,0448211231	0	0,5670837434	0,003587806296	1	0,9949899009	0,5186940818	0,7484007995	1	0,03581115779	0	0	0,5423728814
Hungary	HUN	0,6966869573	1	0,4159988753	0,01852299209	1	0,8970965266	0,5993864246	0,9013139246	1	0,2325378846	0,2903	0,2222	0,8983050847
Indonesia	IDN	0,527550335	0,9065934066	0,6442663667	0,005616396073	0,5127146069	0,953511014	0,4550683881	0,8195690337	1	0,5111634322	0	0,0355	0,6271186441
Isle of Man	IMN	0,4878825444	1	0	0	1	0,8818663942	0,5186940818	0	1	0,06176280409	0,2199819549	0,1954876289	0,7633080658
India	IND	0,6932903798	0,8003663004	0,6502647734	0,0018881178	1	0,9613634503	0,5281861179	0,8109888636	0,02549889135	0,2418866924	0,0403	0,0554	0,4915254237
Ireland	IRL	0,8359439726	1	0,4646422044	0,2140473327	1	0,8126383447	0,5050492139	0,9670660391	1	0,1113660124	0,8571	0,6694	0,9322033898
Iran	IRN	0,4878825444	0,9432234432	0,5309058531	0,003357574792	1	0,8029194746	0,4394733478	0,8969279664	1	0,06679236951	0,1765	0,2778	0,7457627119
Iraq	IRQ	0,2099142007	0,6611721612	0,5907961948	0,00185183462	1	0,8790110532	0,3953726192	0,8257223559	0,9734323725	0,01932724236	0	0	0,7118644068
Iceland	ISL	0,6649615911	1	0,5352172079	0,003265675319	1	0,8502729488	0,7387191614	0,9831857761	1	0,00499351611	0	0	0,813559322
Israel	ISR	0,7847361421	1	0,5164253245	0,0935646329	1	0,7825954826	0,7192892752	0,9735775804	1	0,07758048392	0	0,0417	0,593220339
Italy	ITA	0,8209221565	1	0,4442569942	0,02566876835	1	0,8591350469	0,5192381439	0,9906522517	1	0,3215989084	0,1852	0,2107	0,8644067797
Jamaica	JAM	0,3051751664	0,8937728938	0,497117953	0,01122447546	1	0,9317896698	0,227534194	0,8993821048	1	0,3149207816	0,2199819549	0,0833	0,5254237288
Jordan	JOR	0,5169225675	0,9761904762	0,6404236375	0,02116719867	1	0,9156573387	0,5386680302	0,8804586722	1	0,0111741666	0	0	0,9491525424
Japan	JPN	0,9027635012	1	0,4589718356	0,04903116325	1	0,7592055315	0,8230857727	0,9948457517	1	0,6965728737	0,2368	0,2597	0,6610169492
Kazakhstan	KAZ	0,4390532207	0,967032967	0,5878907165	0,005879158932	1	0,6190178	0,4728365077	0,8543149729	1	0,01247116844	0,0357	0,05	0,7966101695
Kenya	KEN	0,6595156499	0,7527472527	0,5758939032	0,01036731563	1	0,993164917	0,2597469002	0,7372468869	1	0,07889338898	0	0,1111	0,6779661017
Kyrgyz Republic	KGZ	0,2122082701	0,9267399267	0,5257509724	0,0004938674936	1	0,9581355744	0,5186940818	0,838311043	1	0,03379221333	0	0	0,9830508475
Cambodia	KHM	0,4575458253	0,8223443223	0,8479778809	0,004594020173	0,9731767752	0,9915511646	0,392049086	0,8146385684	1	0,545111442	0	0,0667	0,7288135593
Kiribati	KIR	0,4878825444	0,9597069597	0,5661464923	0	1	0,9864894509	0,5186940818	0,7848763705	1	0,1526219691	0,2199819549	0,5	0,6440677966
Saint Kitts and Nevis	KNA	0,4878825444	1	0,1958854679	0,03496176257	0,9999942554	0,8737625923	0,5186940818	0	1	0,4304721971	0,2199819549	0	0,5593220339
Korea	KOR	0,4878825444	0,9926739927	0,4875111299	0,0285451546	1	0,7089077524	0,7670970216	0,9748190662	1	0,6454754454	0,0714	0,0645	0,6440677966
Kuwait	KWT	0,59113655	0,9615384615	0,7975537748	0,1014163885	1	0,3265393541	0,6621500703	0,8863268668	1	0,003568606882	0,2199819549	0,1429	0,813559322
Laos	LAO	0,1784609413	0,7655677656	0,7164815596	0,001875660334	1	0,9925200442	0,5186940818	0,7895279969	1	0,8270950799	0	0,0667	0,6949152542
Lebanon	LBN	0,4258311149	0,9468864469	0,4502554009	0,0209759744	0,9712475634	0,8950621168	0,4617154544	0,944832136	1	0,1365591174	0	0	0,8813559322
Liberia	LBR	0,2304694888	0,5311355311	0,563569052	0,008536457064	1	0,9951804568	0,5186940818	0,7257043797	1	0,4414501936	0	0	0,813559322
Libya	LBY	0,2535247341	1	0,5161910118	0	1	0,7992376775	0,3938386808	0,8522541753	0,9968237251	0,00125483748	0,2199819549	0	0,9661016949
Saint Lucia	LCA	0,4878825444	1	0,3325366699	0,0194075208	0,9999980851	0,9454746746	0,5186940818	0,8921007309	1	0,3386039465	0,2199819549	0	0,7627118644
Liechtenstein	LIE	0,4878825444	1	0,4670790571	0	1	0,9664150488	0,5186940818	0,9738380278	1	0,4387881612	0,2199819549	0,5	1
Sri Lanka	LKA	0,4878825444	0,6483516484	0,6631988378	0,003795165574	0,9585568921	0,9814405482	0,6482167966	0,8893561253	1	0,335860821	0,5714	0,129	0,2881355932
Lesotho	LSO	0,1627544817	0,8608058608	0,523595295	0,04438832612	1	0,9734390554	0,5186940818	0,5928141432	1	0,01642177793	0,2199819549	0	0,9661016949
Lithuania	LTU	0,7738358873	1	0,5488542106	0,04684579226	1	0,8949994473	0,5784226	0,8913294743	1	0,3540472548	0,8	0,6296	1
Luxembourg	LUX	0,9975042291	1	0,419794742	0,9226344624	1	0,5381956372	0,7189057906	0,9756902301	1	0,3406003436	0	0	1
Latvia	LVA	0,6579218273	1	0,5658184545	0,07515374315	1	0,9136819876	0,6241850952	0,8795218921	1	0,5491576539	0,4138	0,5077	1
Macao	MAC	0,4878825444	1	0,4122498711	0	1	0,9063399344	0,5186940818	0,9583286514	1	0	0,2199819549	0,1954876289	0,7633080658
Saint Pierre and Miquelon	MAF	0,4878825444	1	0	0	1	0,8818663942	0,5186940818	0,9429588131	1	0,1870366969	0,2199819549	0,1954876289	0,7633080658
Morocco	MAR	0,4063227719	0,9432234432	0,6258493838	0,007014185494	0,9999492565	0,9574012479	0,4651668158	0,8814788667	1	0,1283989294	0,6429	0,1456	0,8305084746
Monaco	MCO	0,3866378449	1	0	0	1	0,8818663942	0,5186940818	0	1	0	0,2199819549	0,1954876289	0,593220339
Moldova	MDA	0,4878825444	1	0,4115469328	0,004480494355	1	0,9661099862	0,5104179982	0,849882502	1	0,1266046038	0	0	0,9661016949
Madagascar	MDG	0,2117169557	0,5805860806	0,5654435541	0,0003945339221	0,7984811406	0,9973741125	0,5186940818	0,7769849919	1	0,2181338301	0,5926	0,3391	0,6779661017
Maldives	MDV	0,3481273155	0,9377289377	0,2977177937	0,3288284188	1	0,9346947013	0,4895820018	0,9133932264	1	0,03391598975	0,2199819549	0	0,7796610169
Mexico	MEX	0,5768317257	0,9468864469	0,5389193495	0,009914253629	0	0,9030382104	0,4468873834	0,9127012312	0,9864478936	0,3456589479	0	0,1647	0,4745762712
Marshall Islands	MHL	0,4878825444	1	0,4821219364	0	1	0,9525871456	0,5186940818	0	1	0,7144968995	0,2199819549	0	0,7457627119
Macedonia	MKD	0,4878825444	1	0,5526032148	0,01251189327	1	0,901712703	0,5959350633	0,8957888798	1	0,4026347639	0,6667	0,0938	0,9661016949
Mali	MLI	0,3443201041	0,9578754579	0,7063123858	0,00155891062	1	0,9991627906	0,5186940818	0,69362331	1	0,03931696581	0,4	0,2941	0,9830508475
Malta	MLT	0,5597917527	1	0,4291672524	0,1474956428	1	0,8710971593	0,6994759044	0,9723331283	1	0,01112868525	0,2199819549	0,3636	0,813559322
Myanmar	MMR	0,3273840264	0,8113553114	0,6095412156	0,00133596803	1	0,9948102516	0,5186940818	0,7836212395	1	0,4524503712	0,2188	0,1724	0,6949152542
Montserrat	MNE	0,2974884355	1	0,4456160082	0,01838429743	1	0,9112011006	0,5186940818	0,905784009	1	0,6256176993	0,2199819549	0	0,3220338983
Mongolia	MNG	0,3454553412	0,7142857143	0,6792258306	0,01398180405	1	0,6409358088	0,2257445993	0,8284632831	1	0,08221260139	0,1053	0,1618	0,9322033898
Northern Mariana Islands	MNP	0,4878825444	1	0	0	1	0,8818663942	0,5186940818	0	1	0,6525141671	0,2199819549	0,2727	0,3220338983
Mozambique	MOZ	0,4132152555	0,6684981685	0,7576268804	0,01025098607	1	0,9969377507	0,5186940818	0,6570066583	1	0,4908972696	0	0,2778	0,7288135593
Mauritania	MRT	0,1018703059	0,9340659341	0,5618820001	0,00265713404	1	0,8818663942	0,5186940818	0,7499322777	1	0,002216203264	0,2199819549	0,1	0,9830508475
Martinique	MTQ	0,4878825444	0,9340659341	0,5618820001	0,00265713404	1	0,9837854615	0,5186940818	0,7499322777	1	0,002216203264	0,2199819549	0,8333	0,5762711864
Mauritius	MUS	0,4878825444	0,9358974359	0,4395238765	0,01076223648	0,9989391729	0,9274869399	0,4365332992	0,8822364779	1	0,1934715444	0,2199819549	0	0
Malawi	MWI	0,4878825444	0,7454212454	0,9202867988	0,004112828259	1	0,9987494785	0,5186940818	0,7569806136	1	0,3396276329	0	0,6	0,6949152542
Malaysia	MYS	0,6956742635	0,9743589744	0,6004967431	0,01895194003	1	0,8021805481	0,2624312923	0,8884302615	1	0,6873524718	0	0,0377	0,5084745763
Namibia	NAM	0,4362929543	0,4047619048	0,4254182483	0,03285199534	1	0,969620518	0,2836507734	0,7702532273	1	0,08550987693	0,4	0,5556	0,9661016949
Niger	NER	0,3667272406	0,8974358974	0,6271615352	0,005061200814	0,9757618232	0,9980503943	0,5186940818	0,7352925228	1	0,009173139958	0,4545	0,4	0,9152542373
Nigeria	NGA	0,3918976879	0,9230769231	0,5385913117	0,02317431742	1	0,9870049287	0,1842004346	0,6294507289	0,9948070953	0,07812330939	0	0,6667	0,7966101695
Nicaragua	NIC	0,3549718474	0,7765567766	0,6618398238	0,004684346932	0,9892663059	0,9816877144	0,5186940818	0,8910756715	1	0,2632899904	0,6667	0,3871	0,7627118644
Netherlands	NLD	0,9853720727	1	0,5314682038	0,05364949466	1	0,7505404442	0,7080403937	0,9694970399	1	0,1135566464	0,3929	0,3981	0,9322033898
Norway	NOR	0,8120735487	1	0,4894324945	0,1021225232	1	0,7103379727	0,5060718394	0,9741563788	1	0,337409527	0,3077	0,3556	0,9322033898
Nepal	NPL	0,2962580562	0,9065934066	0,6109002296	0,001360860003	0,9385390457	0,9949165474	0,6152371213	0,8302676676	1	0,2580785606	0	0,037	0,7118644068
Nauru	NRU	0,4878825444	1	0,4968367777	0	1	0,9001218272	0,5186940818	0	1	0	0,2199819549	0,1954876289	0,6440677966
New Zealand	NZL	0,6810958101	1	0,5134261212	0,02123823081	1	0,8116199279	0,5944011249	0,9665248543	1	0,3922925906	0	0,28	0,406779661
Oman	OMN	0,6226054128	0,9395604396	0,5795960448	0,03468874905	1	0,6133881778	0,7773232775	0,917489192	1	0,0000657495443	0,2199819549	0,0333	0,8305084746
Pakistan	PAK	0,5042146104	0,684981685	0,4394770139	0,0007587297814	0,8897974854	0,9797595509	0,3949891346	0,7875951093	1	0,01942883772	0,1579	0,1875	0,7966101695
Panama	PAN	0,6620076152	0,8791208791	0,5468859834	0,02600475123	0,997874516	0,9333490131	0,4508500575	0,9227466701	1	0,6319214953	0,2199819549	0,1923	0,5762711864
Peru	PER	0,4928622398	0,9084249084	0,6877548151	0,008915157822	0,9216711283	0,9544482622	0,2812220376	0,887309685	1	0,5880159195	0,4	0,2324	0,5423728814
Philippines	PHL	0,478731716	0,8296703297	0,5696143212	0,002078240694	1	0,9757926247	0,5817461332	0,8116794349	1	0,2743581356	0,4286	0,1789	0,4237288136
Palau	PLW	0,4878825444	1	0	0	1	0,7362394777	0,5186940818	0	1	0,8914008204	0,2199819549	0,1667	0,6101694915
Papua New Guinea	PNG	0,34719378	1	0,5538216411	0,02292717366	0,9997472397	0,980145139	0,03707017768	0,744875801	1	0,753999128	0,2199819549	0	0,7457627119
Poland	POL	0,6955106188	1	0,5036787103	0,03150437679	1	0,8041343086	0,6870765691	0,927938888	1	0,3135282587	0,443	0,3669	0,9661016949
Puerto Rico	PRI	0,4878825444	1	0,5246262711	0	1	0,8818663942	0,205675572	0,9441642278	1	0,5689054105	0,2199819549	0,0741	0,4576271186
Korea Dem. People's Rep. of	PRK	0,4878825444	0,3717948718	0,4803411594	0	1	0,9509324626	0,5186940818	0,834593705	1	0,4251258495	0	0	0,8644067797
Portugal	PRT	0,6892274261	1	0,4881672056	0,01652834566	1	0,8912817153	0,6377348843	0,9672975348	1	0,3534327988	0,1538	0,2778	0,7457627119
Paraguay	PRY	0,3664935712	0,86996337	0,8259056188	0,006898335381	1	0,9816733701	0,5186940818	0,866484571	1	0,3924198773	0,1667	0,1379	0,9322033898
French Polynesia	PYF	0,4878825444	1	0,4900417077	0	1	0,9272932431	0,5186940818	0,9107046259	1	0,4308999456	0,2199819549	0	0,5423728814
Qatar	QAT	0,7614841426	1	0,6407985379	0,2452067319	1	0	0,889428608	0,9345563881	1	0	0,2199819549	0	0,7457627119
Romania	ROU	0,530816758	1	0,6407985379	0	1	0,9131510773	0,7328390643	0,9345563881	1	0	0,1613	0,2093	0,9322033898
Russia	RUS	0,4878825444	1	0,5737850883	0,01858341566	1	0,6923705673	0,5014700243	0,8413642698	1	0,5063088326	0,0667	0,0659	0,9491525424
Rwanda	RWA	0,5281942576	0,5750915751	0,8099254885	0,03371840643	1	0,998908576	0,5186940818	0,7656150089	1	0,1979693138	0,2	0,1538	0,7627118644
Saudi Arabia	SAU	0,5929469163	0,9835164835	0,5057875252	0,01853146003	1	0,9671547915	0,7878051898	0,8838996631	1	0,004624282868	0,1111	0,102	0,8644067797
Sudan	SDN	0,3547229553	1	0,5409344393	0,001738456687	1	0,9930487286	0,6420810431	0,7559587579	0,9956818182	0,08226315996	0	0,0909	0,9152542373
Senegal	SEN	0,2775827785	0,8846153846	0,6004967431	0,00450333822	0,9816796685	0,9860448287	0,5186940818	0,7926667739	1	0,4372103553	0,2199819549	0,0556	0,9152542373
Singapore	SGP	0,9686658586	1	0,5250948967	1	1	0,7691116188	0,8781797264	0,9800312181	1	0,2346374541	0,2199819549	0	0,7966101695
Solomon Islands	SLB	0,3116855587	0,8717948718	0,5524626271	0	0,995404359	0,9919587638	0,5186940818	0,8085882386	1	0,7942812548	0,2199819549	0,0303	0,6271186441
Sierra Leone	SLE	0,1625333711	0,706959707	0,8070668729	0,01268754571	0,9919126292	0,9959230436	0,5186940818	0,6087963592	1	0,42909514	0,5	0,7	0,8644067797
El Salvador	SLV	0,4214435359	0,8443223443	0,5272505741	0,007345995183	0,9999310654	0,9748695477	0,1752524607	0,8661935106	1	0,1301313923	0	0	0,7288135593
San Marino	SMR	0,4878825444	1	0	0	1	0,8818663942	0,5186940818	0	1	0	0,2199819549	0,1954876289	1
Somalia	SOM	0,05661952052	1	0,549229111	0	1	0,9991917512	0,3381055861	0,6607365738	0,9938192905	0,1032012458	0	0	0,8644067797
Serbia	SRB	0,4430792592	1	0,5081306528	0,006489429589	0,9981636584	0,8457985331	0,5964463761	0,895699414	1	0,3164355037	0	0	0,9491525424
Sao Tome and Principe	STP	0,4878825444	0,9267399267	0,5298280144	0,02283260145	1	0,9852786729	0,5186940818	0,7892174771	1	0,5680928511	0,2199819549	0	0,6610169492
Suriname	SUR	0,4878825444	0,8974358974	0,7239795679	0,005442593892	1	0,9032791937	0,5186940818	0,8459399571	1	1	0	0,1538	0,9830508475
Slovakia	SVK	0,6616468359	1	0,4075167534	0,1175847588	1	0,8468341877	0,7043333759	0,9161602576	1	0,4104959146	0,1111	0,05	0,9491525424
Slovenia	SVN	0,603653081	1	0,3895215333	0,02801706959	1	0,8273211897	0,7826920619	0,9620304456	1	0,6304939712	0,3333	0,3143	0,9152542373
Sweden	SWE	0,9918657201	1	0,4378368246	0,1304201086	1	0,8865035726	0,4938003324	0,9795103233	1	0,7012768863	0,3462	0,32	1
Swaziland	SWZ	0,4878825444	0,6483516484	0,5271099864	0,003321866945	1	0,9791562516	0,5186940818	0,5799131565	1	0,3466530257	0,2199819549	0	0,7118644068
Seychelles	SYC	0,4878825444	1	0,5342799569	0,0602495815	0,9962085961	0,8232428236	0,5186940818	0,8689008585	1	0,8995848174	0,2199819549	0,1429	0,4745762712
Syria	SYR	0	1	0,3862880172	0	1	0,954532819	0,2421066087	0,8316438266	0,9448536585	0,02720593435	0	0	0,9322033898
Turks and Caicos Islands	TCA	0,4878825444	1	0	0	1	0,8527527227	0,5186940818	0	1	0,3684348261	0,2199819549	0	0,7457627119
Chad	TCD	0,215451859	0,521978022	0,5629598388	0,01007464486	1	0,9995480326	0,5186940818	0,6155021385	1	0,03939179128	0,3333	0,5	0,8813559322
Togo	TGO	0,3879732612	0,8626373626	0,583860537	0,01534224606	1	0,9927350843	0,5186940818	0,7133620201	1	0,03516937223	0,2199819549	0,75	0,7627118644
Thailand	THA	0,6305182017	0,9029304029	0,6021369324	0,004497268177	1	0,8895532831	0,4537901061	0,8851794744	1	0,3265997199	0,3077	0,531	0,6779661017
Tajikistan	TJK	0,1767441949	0,5421245421	0,7297905244	0,0004387184908	1	0,9897592714	0,5186940818	0,8278364295	1	0,03020489499	0,125	0,0556	0,9830508475
Turkmenistan	TKM	0,2333169054	0,9597069597	0,5830170111	0,0008451190138	1	0,6849788286	0,5186940818	0,7799947911	1	0,08935669331	0	0	0,9661016949
Tonga	TON	0,4878825444	0,8626373626	0,6200852898	0	1	0,9515264628	0,5186940818	0,8655165847	1	0,1271849743	0,2199819549	0	0,5254237288
Trinidad and Tobago	TTO	0,3044916646	0,8992673993	0,4517550026	0,04024898726	0,9999894683	0,1469573009	0,1934040649	0,8372015015	1	0,4650655944	0,2199819549	0,1429	0,6779661017
Tunisia	TUN	0,3418901716	0,9945054945	0,5569145696	0,009727033741	0,9999827663	0,9385201882	0,5667902339	0,8896264211	1	0,06817690514	0	0,0139	0,9661016949
Turkey	TUR	0,6946794563	0,9981684982	0,6081822016	0,01401367701	0,9999061723	0,8957464363	0,5648728109	0,8949687374	0,9979456763	0,1548767043	0	0	0,813559322
Tuvalu	TUV	0,4878825444	1	0,5052251746	0	1	0,8818663942	0,5186940818	0	1	0,3391598975	0,2199819549	0,1954876289	0,7288135593
Taiwan	TWN	0,4878825444	1	0,5052251746	0	1	0,8818663942	0,8697430653	0	1	0,3391598975	0,2199819549	0,1954876289	0,7633080658
Tanzania	TZA	0,4878825444	0,5641025641	0,7229485918	0,005325478314	1	0,9953977474	0,5186940818	0,7770408784	1	0,5290710766	0,186	0,2672	0,5084745763
Uganda	UGA	0,5499076169	0,684981685	0,5272974366	0,02647730841	0,9990703401	0,9973828427	0,3631599131	0,7021884109	1	0,1053912693	0,1786	0,2667	0,6101694915
Ukraine	UKR	0,4332248078	1	0,6483902713	0,006108461258	1	0,8533027999	0,4347437045	0,8446981153	0	0,1696180533	0,011	0,0146	0,9152542373
Uruguay	URY	0,5237476904	0,956043956	0,6094943531	0,008742382058	1	0,945501533	0,4300140611	0,915282449	1	0,1072591587	0	0,0455	0,7288135593
USA	USA	0,9110248911	1	0,5306246778	0,0224963417	1	0,5953505351	0,4668285824	0,9343056703	1	0,3449228013	0,1176	0,1059	0,7457627119
Uzbekistan	UZB	0,3068157989	0,9468864469	0,7651717513	0,0006488619259	1	0,9162798295	0,5186940818	0,8122289256	1	0,07701417502	0,0357	0,0784	0,9661016949
Saint Vincent	VCT	0,4878825444	0,9175824176	0,4932752238	0,05627858184	0,9952032997	0,9534098871	0,5186940818	0,8668018541	1	0,7044090961	0,2199819549	0	0,6101694915
Venezuela	VEN	0,4878825444	0,9835164835	0,614836684	0,01259378383	0,9871178437	0,8491386156	0	0,882906166	1	0,5385069807	0	0,2237	0,7288135593
British Virgin Islands	VGB	0,4878825444	1	0,4870893669	0	1	0,8508848298	0,5186940818	0	1	0,2455517564	0,2199819549	0	0,6101694915
United States Virgin Islands	VIR	0,4878825444	1	0,5753784151	0	1	0,8818663942	0,5186940818	0,9477339592	1	0,5116469386	0,2199819549	0,0769	0,6610169492
Viet Nam	VNM	0,3015848792	0,9835164835	0,6263648718	0,001192285798	1	0,9586406403	0,4131407388	0,8991395743	1	0,4847688871	0,0714	0,0278	0,593220339
Vanuatu	VUT	0,4878825444	0,9249084249	0,6465157692	0	1	0,9903046743	0,5186940818	0,8561822444	1	0,3672609597	0,2199819549	0	0,4406779661
Wallis and Futuna	WLF	0,524540796	0,847985348	0,6263648718	0,001192285798	1	0,8818663942	0,5186940818	0,8991395743	1	0,313639164	0,2199819549	0,1954876289	0,7633080658
Yemen	YEM	0,4878825444	0,6666666667	0,6484371339	0,005474230508	0,9978141982	0,9761427975	0,5186940818	0,7597635446	0,9984756098	0,01058008049	0,0769	0,2857	0,813559322
South Africa	ZAF	0,8284981419	0,9761904762	0,5728946998	0,01795341821	1	0,7820851489	0,1222037581	0,6815641795	1	0,07750893474	0,1481	0,2121	0,6440677966
Zambia	ZMB	0,3164396256	0,2582417582	0,8640048737	0,01087606077	1	0,9944890147	0,5186940818	0,7212516189	1	0,6656684512	0,2308	0,2326	0,813559322
Zimbabwe	ZWE	0,1842280826	0,5256410256	0,4590655607	0,002392664762	1	0,97781687	0,4067493289	0,7019748321	1	0,3698540069	0,6	0,6111	0,6610169492
";
            var dataList = data
                .Replace(",", ".")
                .Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x =>
                {
                    var objData = x.Split(new string[] { "\t" }, StringSplitOptions.None);

                    var country = new HappyPeople.Models.Data.Country()
                    {
                        Id = objData.ElementAt(1),
                        Name = objData.ElementAt(0),
                    };

                    ISO3166Country countryISO = ISO3166.FromAlpha3(country.Id);
                    if (countryISO != null)
                    {
                        country.ISO2 = countryISO.Alpha2;
                    }

                    var countryData = new HappyPeople.Models.Data.CountryData()
                    {
                        CountryId = objData.ElementAt(1),
                        LPI = double.Parse(objData.ElementAt(2)),
                        DFD = double.Parse(objData.ElementAt(3)),
                        FPI = double.Parse(objData.ElementAt(4)),
                        WATP = double.Parse(objData.ElementAt(5)),
                        ABDIS = double.Parse(objData.ElementAt(6)),
                        CO2 = double.Parse(objData.ElementAt(7)),
                        CrimeIndex = double.Parse(objData.ElementAt(8)),
                        LEAB = double.Parse(objData.ElementAt(9)),
                        Deaths = double.Parse(objData.ElementAt(10)),
                        IF = double.Parse(objData.ElementAt(11)),
                        PISF = double.Parse(objData.ElementAt(12)),
                        PIST = double.Parse(objData.ElementAt(13)),
                        RLI = double.Parse(objData.ElementAt(14)),
                    };

                    return new
                    {
                        Country = country,
                        CountryData = countryData,
                    };
                })
                .ToList();

            using (var happyDbContext = new HappyDbContext())
            {
                happyDbContext.CountryVotes.RemoveRange(happyDbContext.CountryVotes);
                happyDbContext.IndexInfos.RemoveRange(happyDbContext.IndexInfos);
                happyDbContext.CountryDatas.RemoveRange(happyDbContext.CountryDatas);
                happyDbContext.Countries.RemoveRange(happyDbContext.Countries);
                happyDbContext.SaveChanges();

                happyDbContext.Countries.AddRange(dataList.Select(x => x.Country));
                happyDbContext.CountryDatas.AddRange(dataList.Select(x => x.CountryData));
                happyDbContext.SaveChanges();
            }
        }
    }
}
