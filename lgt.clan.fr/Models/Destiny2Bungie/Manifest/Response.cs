using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Manifest
{
    public class Response
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("mobileAssetContentPath")]
        public string MobileAssetContentPath { get; set; }
        [JsonProperty("mobileGearAssetDataBases")]
        public List<MobileGearAssetDataBases> MobileGearAssetDataBases { get; set; }
        [JsonProperty("mobileWorldContentPaths")]
        public MobileWorldContentPaths MobileWorldContentPaths { get; set; }
        [JsonProperty("mobileGearCDN")]
        public MobileGearCDN MobileGearCDN { get; set; }
    }
}
