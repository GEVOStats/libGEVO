using System.Numerics;
using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Response.PlayerInformation
{
    public record Player(
        [property: JsonPropertyName("playerId")] int PlayerId,
        [property: JsonPropertyName("playerName")] string PlayerName,
        [property: JsonPropertyName("playerLevel")] int PlayerLevel,
        [property: JsonPropertyName("playerIconItemId")] string PlayerIconItemId,
        [property: JsonPropertyName("portraitItemId")] string PortraitItemId,
        [property: JsonPropertyName("trophyItemId")] string TrophyItemId,
        [property: JsonPropertyName("matchingArea")] int MatchingArea,
        [property: JsonPropertyName("accountId")] object AccountId /* Likely int, unused on Steam */
    );
    public record Advanced(
        [property: JsonPropertyName("players")] IReadOnlyList<Player> Players
    );
}