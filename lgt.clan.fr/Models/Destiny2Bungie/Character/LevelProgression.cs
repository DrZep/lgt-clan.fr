using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Character
{
    public class LevelProgression
    {
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("levelCap")]
        public int LevelCap { get; set; }
    }
}
