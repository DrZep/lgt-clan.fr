using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Profil
{
    public class Profile
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
        public lgt.clan.fr.Models.Destiny2Bungie.Character.Character Characteres { get; set; }
    }
}
