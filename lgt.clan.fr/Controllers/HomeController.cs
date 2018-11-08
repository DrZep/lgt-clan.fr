﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lgt.clan.fr.Models;
using System.Net.Http;
using lgt.clan.fr.Settings;
using Microsoft.Extensions.Options;

namespace lgt.clan.fr.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<BungieApi> _BungieApi;

        public HomeController(IOptions<BungieApi> BungieApi)
        {
            _BungieApi = BungieApi;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Test()
        {
            string[] characterId;
            var apiSite = "https://www.bungie.net/Platform";
            var membershipType = 1;
            //var destinyMembershipId = "4611686018448104003";
            var destinyMembershipId = "";
            var displayName = "DrZepequenio";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", _BungieApi.Value.apiKey);
                //string link = apiSite + $"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/?components=100";
                string link = apiSite + $"/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                destinyMembershipId = (string)item.Response[0].membershipId;

            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", _BungieApi.Value.apiKey);
                string link = apiSite + $"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/?components=100";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                characterId = item.Response.profile.data.characterIds.ToObject<string[]>();
            }


            foreach (var id in characterId)
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("X-API-Key", _BungieApi.Value.apiKey);
                    string link = apiSite + $"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{id}/?components=100,200";
                    var response = await client.GetAsync(link);
                    var content = await response.Content.ReadAsStringAsync();
                    dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);


                    //await Context.Channel.SendMessageAsync("", embed: embed);
                }
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
