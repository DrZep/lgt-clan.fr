using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class Member
    {
        [JsonProperty("memberType")]
        public int MemberType { get; set; }
        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }
        [JsonProperty("groupId")]
        public string GroupId { get; set; }
        [JsonProperty("destinyUserInfo")]
        public DestinyUserInfo destinyUserInfo { get; set; }
        [JsonProperty("joinDate")]
        public DateTime JoinDate { get; set; }
    }
}
