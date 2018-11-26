using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class DestinyUserInfo
    {
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("membershipType")]
        public int MembershipType { get; set; }
        [JsonProperty("membershipId")]
        public string MembershipId { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}
