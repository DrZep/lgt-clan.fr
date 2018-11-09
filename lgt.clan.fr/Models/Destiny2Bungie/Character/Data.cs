using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Character
{
    public class Data
    {
        [JsonProperty("membershipId")]
        public string MembershipId { get; set; }
        [JsonProperty("membershipType")]
        public int MembershipType { get; set; }
        [JsonProperty("characterId")]
        public string CharacterId { get; set; }
        [JsonProperty("dateLastPlayed")]
        public DateTime DateLastPlayed { get; set; }
        [JsonProperty("minutesPlayedThisSession")]
        public int MinutesPlayedThisSession { get; set; }
        [JsonProperty("minutesPlayedTotal")]
        public int MinutesPlayedTotal { get; set; }
        [JsonProperty("light")]
        public int Light { get; set; }
    }
}
