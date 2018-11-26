using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class Response
    {
        [JsonProperty("results")]
        public List<Results> Results { get; set; }
    }
}
