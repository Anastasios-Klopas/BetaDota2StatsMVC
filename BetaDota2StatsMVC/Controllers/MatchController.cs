using BetaDota2StatsMVC.Models;
using Newtonsoft.Json;
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
        //private /*readonly*/ int steamID = 154076558; //modeplex
        //private /*readonly*/ int steamID = 62939497; //adreas
        //private readonly int steamID = 254846236; //marios
        // GET: Match
        public ActionResult Index()
        {
            IEnumerable<MatchViewModel> matches = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                var responseTask = client.GetAsync($"players/{steamID}/matches");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readInfo = result.Content.ReadAsAsync<IList<MatchViewModel>>();
                    readInfo.Wait();
                    matches = readInfo.Result;
                }
                else
                {
                    matches = Enumerable.Empty<MatchViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                }
            }
            var a = GetAllHeroes();
            var ba = HeroName(matches);
            var bac = Heroes(matches);
            return View(matches);
        }
        public List<Hero> GetAllHeroes()
        {
            string SourcePath = $"C:\\Users\\sapol\\source\\repos\\BetaDota2StatsMVC\\BetaDota2StatsMVC\\Data_JSON\\heroes.json";
            using (StreamReader r = new StreamReader(SourcePath))
            {
                string json = r.ReadToEnd();
                List<int> allHeroesID = JsonConvert.DeserializeObject<List<int>>(json);
                //List<Hero> allHeroes1 = JsonConvert.DeserializeObject<List<Hero>>(allHeroesID);

                List<Hero> allHeroes = JsonConvert.DeserializeObject<List<Hero>>(json);

               // Dictionary < allHeroesID,List<Hero>>=
                //test thn lista
                var a = allHeroes;
                return allHeroes;
            }
        }
        public string Heroes(IEnumerable<MatchViewModel> matches)
        {
            var heroID=matches.Select(m => m.Hero_id).FirstOrDefault();
            var allHeroes = GetAllHeroes();
            var heroName = allHeroes.Where(a => a.Id == heroID).Select(b => b.Localized_Name).FirstOrDefault();
            return heroName;
        }
        public ActionResult HeroName(IEnumerable<MatchViewModel> matches)
        {
            var heroID=matches.Select(m => m.Hero_id).FirstOrDefault();
            var allHeroes = GetAllHeroes();
            var heroName = allHeroes.Where(a => a.Id == heroID).Select(b => b.Localized_Name).FirstOrDefault();
            return View(heroName);
        }
    }
}