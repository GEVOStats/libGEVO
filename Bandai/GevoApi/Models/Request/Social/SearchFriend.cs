using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Request.Social
{
    public record SearchFriend(
        [property: JsonPropertyName("playerName")] string PlayerName
    );
}
