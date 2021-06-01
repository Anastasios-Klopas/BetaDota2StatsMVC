using BetaDota2StatsMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace BetaDota2StatsMVC.Controllers
{
    public class PlayerController : Controller
    {
        private /*readonly*/ int steamID = 19445234;
        // GET: Player
        public ActionResult Index()
        {
            ProfileViewModel profile = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                var responseTask = client.GetAsync($"players/{steamID}");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    //var readInfo = result.Content.ReadAsAsync<IList<ProfileViewModel>>();
                    var readInfo = result.Content.ReadAsAsync<ProfileViewModel>();
                    var resultJSON = JsonConvert.DeserializeObject(readInfo);
                    readInfo.Wait();
                    profile = readInfo.Result;
                    ProfileViewModel test1 = JsonConvert.DeserializeObject<ProfileViewModel>(readInfo);

                    Response.Write(test1.MmrEstimate);
                }
                else
                {
                    //return error code
                    profile = (ProfileViewModel)Enumerable.Empty<ProfileViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                }
            }
            return View(profile);
        }
    }
}