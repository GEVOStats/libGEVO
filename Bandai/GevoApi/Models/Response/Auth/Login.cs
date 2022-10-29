using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Response.Auth
{
    public record Login(
        [property: JsonPropertyName("token")] string Token,
        [property: JsonPropertyName("playerId")] int PlayerId,
        [property: JsonPropertyName("matchingArea")] int MatchingArea,
        [property: JsonPropertyName("initialLevel")] int InitialLevel,
        [property: JsonPropertyName("privilegeLevel")] int PrivilegeLevel,
        [property: JsonPropertyName("returnBattle")] bool ReturnBattle,
        [property: JsonPropertyName("secessionMatchPhase")] int SecessionMatchPhase,
        [property: JsonPropertyName("apiServerVersion")] string ApiServerVersion,
        [property: JsonPropertyName("bonusProgress")] int BonusProgress,
        [property: JsonPropertyName("tutorialProgress")] int TutorialProgress,
        [property: JsonPropertyName("opsNoticeCodes")] IReadOnlyList<string> OpsNoticeCodes,
        [property: JsonPropertyName("disabledMobileSuits")] IReadOnlyList<object> DisabledMobileSuits,
        [property: JsonPropertyName("warning")] bool Warning,
        [property: JsonPropertyName("warningTitle")] string WarningTitle,
        [property: JsonPropertyName("warningText")] string WarningText,
        [property: JsonPropertyName("penaltyRemainingTime")] string PenaltyRemainingTime,
        [property: JsonPropertyName("isNewSeason")] bool IsNewSeason
    ) : Base;
}