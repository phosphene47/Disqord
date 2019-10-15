﻿using Disqord.Serialization.Json;

namespace Disqord.Models.Dispatches
{
    internal sealed class GuildRoleDeleteModel
    {
        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("role")]
        public RoleModel Role { get; set; }
    }
}