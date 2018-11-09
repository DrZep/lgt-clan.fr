using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Profil
{
    public class Response
    {
        [JsonProperty("profile")]
        public Profile profile { get; set; }
    }
}
