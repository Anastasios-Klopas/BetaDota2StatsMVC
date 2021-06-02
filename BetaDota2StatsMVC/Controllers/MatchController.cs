using BetaDota2StatsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace BetaDota2StatsMVC.Controllers
{
    public class MatchController : Controller
    {
        //private /*readonly*/ int steamID = 19445234; //me
        //private /*readonly*/ int steamID = 154076558; //modeplex
        private /*readonly*/ int steamID = 62939497; //adreas
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
            return View(matches);
        }
    }
}