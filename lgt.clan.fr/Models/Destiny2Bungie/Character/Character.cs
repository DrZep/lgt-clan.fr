using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Character
{
    public class Character
    {
        public string GamerTag { get; set; }

        [JsonProperty("data")]
        public Data data { get; set; }
    }
}
