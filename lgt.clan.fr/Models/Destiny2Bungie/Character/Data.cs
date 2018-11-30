using lgt.clan.fr.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        //[JsonProperty("stats")]
        //public int[] Stats { get; set; }
        [JsonProperty("raceType")]
        public DestinyRaceEnum RaceType { get; set; }
        [JsonIgnore, NotMapped]
        public string Race
        {
            get
            {
                return RaceType.GetDescription();
            }
        }
        [JsonProperty("classType")]
        public DestinyClassEnum ClassType { get; set; }
        [JsonIgnore, NotMapped]
        public string Class
        {
            get
            {
                return ClassType.GetDescription();
            }
        }

        [JsonProperty("genderType")]
        public DestinyGenderEnum GenderType { get; set; }
        [JsonProperty("emblemPath")]
        public string EmblemPath { get; set; }
        [JsonProperty("emblemBackgroundPath")]
        public string EmblemBackgroundPath { get; set; }

        [JsonProperty("levelProgression")]
        public LevelProgression levelProgression { get; set; }
        #region enum
        public enum DestinyRaceEnum
        {
            [Description("Humain")]
            Human = 0,
            [Description("Eveillé")]
            Awoken = 1,
            [Description("Exo")]
            Exo = 2,
            [Description("Inconnu")]
            Unknown = 3,
        }
        public enum DestinyClassEnum
        {
            [Description("Titan")]
            Human = 0,
            [Description("Chasseur")]
            Hunter = 1,
            [Description("Arcaniste")]
            Warlock = 2,
            [Description("Inconnu")]
            Unknown = 3,
        }
        public enum DestinyGenderEnum
        {
            [Description("Male")]
            Male = 0,
            [Description("Femelle")]
            Female = 1,
            [Description("Inconnu")]
            Unknown = 2,
        }
        #endregion
    }
}
