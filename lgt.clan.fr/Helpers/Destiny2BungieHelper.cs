using lgt.clan.fr.Models.Destiny2Bungie;
using lgt.clan.fr.Models.Destiny2Bungie.Character;
using lgt.clan.fr.Models.Destiny2Bungie.Clan;
using lgt.clan.fr.Models.Destiny2Bungie.Manifest;
using lgt.clan.fr.Models.Destiny2Bungie.Profil;
using lgt.clan.fr.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace lgt.clan.fr.Helpers
{
    public static class Destiny2BungieHelper
    {
        const string apiSite = "https://www.bungie.net/Platform";
        const int membershipType = 1;
        public static async Task<string> GetDestiny2MembershipIdByGamerTag(string gamerTag, string apiKey)
        {
            string destinyMembershipId = "";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
                string link = apiSite + $"/Destiny2/SearchDestinyPlayer/{membershipType}/{gamerTag}/";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                Models.Destiny2Bungie.MemberShip.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.MemberShip.Root>(content);

               destinyMembershipId = root.Response.Select(x=>x.membershipId).SingleOrDefault();

            }

            return destinyMembershipId;
        }
        public static async Task<Profile> GetDestiny2ProfilById(Profile profile, string destinyMembershipId, string apiKey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
                string link = apiSite + $"/Destiny2/{membershipType}/Profile/{destinyMembershipId}/?components=100";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                Models.Destiny2Bungie.Profil.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.Profil.Root>(content);

                profile  = root.Response.profile;
            }

            return profile;
        }
        public static async Task<List<Character>> GetDestiny2CaracteresById(Profile profile, List<Character> characters, string apiKey)
        {
            foreach (var id in profile.Data.CharacterIds)
            {
                using (var client = new HttpClient())
                {
                    Character character = new Character();
                    client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
                    string link = apiSite + $"/Destiny2/{membershipType}/Profile/{profile.Data.UserInfo.membershipId}/Character/{id}/?components=100,200";
                    //string link = apiSite + $"/Destiny2/Milestones/";

                    var response = await client.GetAsync(link);
                    var content = await response.Content.ReadAsStringAsync();
                    Models.Destiny2Bungie.Character.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.Character.Root>(content);

                    character = root.Response.character;
                    characters.Add(character);
                }
            }

            return characters;
        }
        public static async Task<Group> GetDestiny2ClanByUser(Profile profile, Group group, string apiKey)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
                string link = apiSite + $"/GroupV2/User/{membershipType}/{profile.Data.UserInfo.membershipId}/0/1/";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                Models.Destiny2Bungie.Clan.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.Clan.Root>(content);

                group = root.Response.Results.SingleOrDefault().group;
            }

            return group;
        }

        //https://www.bungie.net/Platform/GroupV2/User/{membershipType}/{membershipId}/0/1/
        //public static async Task<Character> GetDestiny2ActivitiesDoneByCharacterId(Character characters, string apiKey)
        //{
        //        using (var client = new HttpClient())
        //        {
        //            client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        //            //string link = apiSite + $"/Destiny2/{membershipType}/Profile/{profile.Data.UserInfo.membershipId}/Character/{id}/?components=100,200";
        //            string link = apiSite + $"/Destiny2/{membershipType}/Account/{characters.data.MembershipId}/Character/{characters.data.CharacterId}/Stats/Activities/?mode=63";

        //            var response = await client.GetAsync(link);
        //            var content = await response.Content.ReadAsStringAsync();
        //            Models.Destiny2Bungie.Character.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.Character.Root>(content);

        //            characters = root.Response.character;
        //            //await Context.Channel.SendMessageAsync("", embed: embed);
        //        }

        //    return characters;
        //}

        #region GetSqlLite
        //http://www.bungie.net/platform/Destiny/Manifest/
        public static async Task<MobileWorldContentPaths> GetDestiny2Manifests(string apiKey)
        {
            MobileWorldContentPaths mobileWorldContentPaths = new MobileWorldContentPaths();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-Key", apiKey);
                string link = "http://www.bungie.net/platform/Destiny/Manifest/";

                var response = await client.GetAsync(link);
                var content = await response.Content.ReadAsStringAsync();
                Models.Destiny2Bungie.Manifest.Root root = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Destiny2Bungie.Manifest.Root>(content);

                mobileWorldContentPaths = root.Response.MobileWorldContentPaths;
            }

            return mobileWorldContentPaths;
        }
        #endregion

    }
}
