using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.MemberShip
{
    public class Root
    {
        [JsonProperty("Response")]
        public List<Response> Response { get; set; }
    }
}
