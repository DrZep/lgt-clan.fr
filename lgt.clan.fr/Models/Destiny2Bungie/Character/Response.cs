using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Character
{
    public class Response
    {
        [JsonProperty("character")]
        public Character character { get; set; }
    }
}
