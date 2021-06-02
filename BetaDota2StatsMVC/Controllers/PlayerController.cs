﻿using BetaDota2StatsMVC.Models;
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
                    //JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
                    //jsonSerializerSettings.
                    //var resultJSON = JsonConvert.DeserializeObject(readInfo.ToString());
                    readInfo.Wait();
                    profile = readInfo.Result;
                    //ProfileViewModel test1 = JsonConvert.DeserializeObject<ProfileViewModel>(readInfo.ToString());


                    //ProfileViewModel test1 = new ProfileViewModel();

                    //Response.Write(test1.Profile.avatar);
                }
                else
                {
                    //return error code
                    //profile = (ProfileViewModel)Enumerable.Empty<ProfileViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
                }
            }
            return View(profile);
        }
        //public ActionResult Index()
        //{
        //    WinLose winLose = null;
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri($"https://api.opendota.com/api/");
        //        var responseTask = client.GetAsync($"/players/{steamID}/wl ");
        //        responseTask.Wait();
        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            //var readInfo = result.Content.ReadAsAsync<IList<ProfileViewModel>>();
        //            var readInfo = result.Content.ReadAsAsync<WinLose>();
        //            //JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
        //            //jsonSerializerSettings.
        //            var resultJSON = JsonConvert.DeserializeObject(readInfo.ToString());
        //            readInfo.Wait();
        //            winLose = readInfo.Result;
        //            WinLose test1 = JsonConvert.DeserializeObject<WinLose>(readInfo.ToString());

        //            Response.Write(test1.Win);
        //        }
        //        else
        //        {
        //            //return error code
        //            winLose = (WinLose)Enumerable.Empty<WinLose>();
        //            ModelState.AddModelError(string.Empty, "Server error occured. Please contact Admin for help!");
        //        }
        //    }
        //    return View(winLose);
        //}
    }
}