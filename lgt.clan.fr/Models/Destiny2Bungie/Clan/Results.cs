using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class Results
    {
        [JsonProperty("member")]
        public Member member { get; set; }
        [JsonProperty("group")]
        public Group group { get; set; }
    }
}
