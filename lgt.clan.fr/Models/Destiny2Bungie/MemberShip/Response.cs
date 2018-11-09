using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.MemberShip
{
    public class Response
    {
        [JsonProperty("membershipType")]
        public int membershipType { get; set; }
        [JsonProperty("membershipId")]
        public string membershipId { get; set; }
        [JsonProperty("displayName")]
        public string displayName { get; set; }
    }
}
