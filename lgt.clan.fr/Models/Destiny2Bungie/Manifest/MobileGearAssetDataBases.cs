using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Manifest
{
    public class MobileGearAssetDataBases
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
