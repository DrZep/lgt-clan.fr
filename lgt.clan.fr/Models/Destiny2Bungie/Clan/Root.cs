using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class Root
    {
        [JsonProperty("Response")]
        public Response Response { get; set; }
    }
}
