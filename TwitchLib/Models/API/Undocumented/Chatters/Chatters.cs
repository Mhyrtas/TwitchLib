﻿namespace TwitchLib.Models.API.Undocumented.Chatters
{
    #region using directives
    using Newtonsoft.Json;
    #endregion
    public class Chatters
    {
        [JsonProperty(PropertyName = "moderators")]
        public string[] Moderators { get; protected set; }
        [JsonProperty(PropertyName = "staff")]
        public string[] Staff { get; protected set; }
        [JsonProperty(PropertyName = "admins")]
        public string[] Admins { get; protected set; }
        [JsonProperty(PropertyName = "global_mods")]
        public string[] GlobalMods { get; protected set; }
        [JsonProperty(PropertyName = "viewers")]
        public string[] Viewers { get; protected set; }
    }
}
