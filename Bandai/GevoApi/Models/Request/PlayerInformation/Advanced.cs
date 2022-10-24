using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Request.PlayerInformation
{
    public record Advanced(
        [property: JsonPropertyName("playerIds")] IReadOnlyList<int> PlayerIds
    );
}