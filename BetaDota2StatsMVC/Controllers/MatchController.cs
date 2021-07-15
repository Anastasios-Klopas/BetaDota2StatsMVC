using BetaDota2StatsMVC.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Threading.Tasks;

namespace BetaDota2StatsMVC.Controllers
{
    public class MatchController : Controller
    {
        //private readonly int steamID = 19445234; //me
        private const int steamID = 19445234; //me
        public async Task<ActionResult> Index(int? page)
        // GET: Match
        //public ActionResult Index(int? page)
        {
            try
            {
                IEnumerable<MatchesHistory> matches = null;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                    var responseTask = await client.GetAsync($"players/{steamID}/matches");
                    //responseTask.Wait();
                    //var result = responseTask.Result;
                    if (responseTask.IsSuccessStatusCode)//result.Is se responceTask.Is
                    {
                        var readInfo = await responseTask.Content.ReadAsAsync<IList<MatchesHistory>>();
                        //readInfo.Wait();
                        //matches = readInfo.Result;
                        matches = readInfo;
                    }
                    else
                    {
                        matches = Enumerable.Empty<MatchesHistory>();
                        ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                        return View("Error");
                    }


                }
                var allHeroes = GetAllHeroes();
                //added paged list
                int pageSize = 20;
                int pageNumber = page ?? 1;
                var matchesWithHeroes = new MatchesHeroesViewModel()
                {
                    Heroes = allHeroes,
                    Matches = matches.ToPagedList(pageNumber, pageSize)
                };
                //test me to party with sto match id=3309906211
                var match = matches.First(x => x.Match_id == 3309906211);
                //var bac = HeroName(matches);
                foreach (var item in matches)
                {
                    var heroName = HeroName(item);
                }
                return View(matchesWithHeroes);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public Dictionary<int, Hero> GetAllHeroes()
        {
            try
            {
                string heroesJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data_JSON\heroes.json");
                string allHeroes = System.IO.File.ReadAllText(heroesJsonPath);
                Dictionary<int, Hero> allHeroesInfo = JsonConvert.DeserializeObject<Dictionary<int, Hero>>(allHeroes);
                return allHeroesInfo;
            }
            catch (Exception ex)
            {
                throw;
            }
            //string _dannyBoyPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\Danny boy.json");
            //string SourcePath = "C:\\Users\\sapol\\source\\repos\\BetaDota2StatsMVC\\BetaDota2StatsMVC\\Data_JSON\\heroes.json";
            //string ooo = System.IO.File.ReadAllText(/*to path pou 8elw*/);
            //using (StreamReader r = new StreamReader(SourcePath))
            //{
            //    string json = r.ReadToEnd();
            //    Dictionary<int,Hero> allHeroes999 = JsonConvert.DeserializeObject<Dictionary<int,Hero>>(json);
            //    return allHeroes999;
            //}
        }
        //public string HeroName(IEnumerable<MatchViewModel> matches)
        public string HeroName(MatchesHistory match)
        {
            try
            {
                //var heroID=matches.Select(m => m.Hero_id).FirstOrDefault();
                var allHeroes = GetAllHeroes();
                // var heroName = allHeroes.Where(a => a.Value.id == heroID).Select(b => b.Value.localized_name).FirstOrDefault();
                var heroName = allHeroes.Where(a => a.Value.Id == match.Hero_id).Select(b => b.Value.Localized_name).FirstOrDefault();
                return heroName;
            }
            catch (Exception ex)
            {
                throw;
            }


        }
        public async Task<ActionResult> MatchDetail(long? id)//h8ele long
        {
            try
            {
                Match match = null;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                    var responseTask = await client.GetAsync($"matches/{id}");
                    //responseTask.Wait();
                    //var result = responseTask.Result;
                    if (responseTask.IsSuccessStatusCode)//allagh result.Is se responceTask.Is
                    {
                        //var readInfo = result.Content.ReadAsAsync<IList<Match>>();
                        var readInfo = await responseTask.Content.ReadAsAsync<Match>();
                        //readInfo.Wait();
                        //match = readInfo.Result;
                        match = readInfo;
                    }
                    else
                    {
                        //match = Enumerable.Empty<Match>();
                        match = null;
                        ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                        return View("Error");
                    }
                }
                var allHeroes = GetAllHeroes();
                var matchesWithHeroes = new MatchHeroViewModel()
                {
                    Heroes = allHeroes,
                    Match = match
                };
                //sto debug na dw ti fernw
                var a = match;
                return View("MatchDetail", matchesWithHeroes);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}