using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lgt.clan.fr.Models.Destiny2Bungie.Clan
{
    public class Group
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("groupType")]
        public int GroupType { get; set; }
        [JsonProperty("membershipIdCreated")]
        public string MembershipIdCreated { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("modificationDate")]
        public DateTime ModificationDate { get; set; }
        [JsonProperty("about")]
        public string About { get; set; }
        [JsonProperty("memberCount")]
        public string MemberCount { get; set; }
        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }
        [JsonProperty("motto")]
        public string Motto { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("bannerPath")]
        public string BannerPath { get; set; }
        [JsonProperty("avatarPath")]
        public string AvatarPath { get; set; }
    }
}
