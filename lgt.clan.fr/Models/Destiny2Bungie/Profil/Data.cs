using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Profil
{
    public class Data
    {
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("versionsOwned")]
        public int VersionsOwned { get; set; }
        [JsonProperty("characterIds")]
        public string[] CharacterIds { get; set; }
        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }
    }
}
