using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Response.Social
{
    public record SearchFriend(
        [property: JsonPropertyName("found")] bool Found,
        [property: JsonPropertyName("playerId")] int PlayerId
    ) : Base;
}