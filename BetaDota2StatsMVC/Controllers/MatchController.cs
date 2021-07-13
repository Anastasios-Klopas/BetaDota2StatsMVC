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

namespace BetaDota2StatsMVC.Controllers
{
    public class MatchController : Controller
    {
        private readonly int steamID = 19445234; //me
        // GET: Match
        public ActionResult Index()
        {
            IEnumerable<MatchesHistory> matches = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                var responseTask = client.GetAsync($"players/{steamID}/matches");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readInfo = result.Content.ReadAsAsync<IList<MatchesHistory>>();
                    readInfo.Wait();
                    matches = readInfo.Result;
                }
                else
                {
                    matches = Enumerable.Empty<MatchesHistory>();
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                }
            }
            var allHeroes = GetAllHeroes();
            var matchesWithHeroes = new MatchHeroViewModel()
            {
                Heroes = allHeroes,
                Matches = matches
            };
            //test me to party with so match id=3309906211
            var match = matches.First(x => x.Match_id == 3309906211);
            //var bac = HeroName(matches);
            foreach (var item in matches)
            {
                var heroName = HeroName(item);
            }
            return View(matchesWithHeroes);
        }
        public Dictionary<int,Hero> GetAllHeroes()
        {
            string SourcePath = "C:\\Users\\sapol\\source\\repos\\BetaDota2StatsMVC\\BetaDota2StatsMVC\\Data_JSON\\heroes.json";
            using (StreamReader r = new StreamReader(SourcePath))
            {
                string json = r.ReadToEnd();
                Dictionary<int,Hero> allHeroes999 = JsonConvert.DeserializeObject<Dictionary<int,Hero>>(json);
                return allHeroes999;
            }
        }
        //public string HeroName(IEnumerable<MatchViewModel> matches)
        public string HeroName(MatchesHistory match)
        {
            //var heroID=matches.Select(m => m.Hero_id).FirstOrDefault();
            var allHeroes = GetAllHeroes();
            // var heroName = allHeroes.Where(a => a.Value.id == heroID).Select(b => b.Value.localized_name).FirstOrDefault();
            var heroName = allHeroes.Where(a => a.Value.Id == match.Hero_id).Select(b => b.Value.Localized_name).FirstOrDefault();
            return heroName;
        }
        public ActionResult MatchDetail(int? id)
        {
            //opou id einai to matchID
            var ID = id;
            //IEnumerable<Match> match = null;
            Match match = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                var responseTask = client.GetAsync($"matches/{id}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    //var readInfo = result.Content.ReadAsAsync<IList<Match>>();
                    var readInfo = result.Content.ReadAsAsync<Match>();
                    readInfo.Wait();
                    match = readInfo.Result;
                }
                else
                {
                    //match = Enumerable.Empty<Match>();
                    match = null;
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                }
            }
            var a = match;
            return View();
        }
    }
}