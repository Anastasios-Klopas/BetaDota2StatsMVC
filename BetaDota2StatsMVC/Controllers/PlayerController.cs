using BetaDota2StatsMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BetaDota2StatsMVC.Controllers
{
    public class PlayerController : Controller
    {

        //private /*readonly*/ int steamID = 19445234; //me
        private const /*readonly*/ int steamID = 19445234; //me
        // GET: Player
        public async Task<ActionResult> Index()
        {
            //ProfileViewModel profile = null;
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri($"https://api.opendota.com/api/");
                    //var responseTask = client.GetAsync($"players/{steamID}");
                    var responseTask = await client.GetAsync($"players/{steamID}");
                    //responseTask.Wait();
                    //var result = responseTask.Result;
                    if (responseTask.IsSuccessStatusCode)
                    {
                        var readInfo = await responseTask.Content.ReadAsAsync<ProfileViewModel>();
                        return View(readInfo);
                        //var readInfo = result.Content.ReadAsAsync<IList<ProfileViewModel>>();
                        //JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                        //jsonSerializerSettings.
                        //var resultJSON = JsonConvert.DeserializeObject(readInfo.ToString());
                        //readInfo.Wait();
                        //profile = readInfo.Result;
                        //ProfileViewModel test1 = JsonConvert.DeserializeObject<ProfileViewModel>(readInfo.ToString());

                        //ProfileViewModel test1 = new ProfileViewModel();

                        //Response.Write(test1.Profile.avatar);
                        //}
                    }
                        //    //return error code
                        //    //profile = (ProfileViewModel)Enumerable.Empty<ProfileViewModel>();
                        //    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                        //}
                        //return View(await responseTask.Content.ReadAsAsync<ProfileViewModel>());

                }
                catch (Exception ex)
                {
                    throw;
                }
                return View("Error");
                //na balw ena view otan dn einai success to status code
            }
        }
    }
}