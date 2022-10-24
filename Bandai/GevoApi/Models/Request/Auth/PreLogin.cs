using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Request.Auth
{
    public record PreLogin(
        [property: JsonPropertyName("authToken")] string AuthToken,
        [property: JsonPropertyName("accountType")] string AccountType,
        [property: JsonPropertyName("currentLanguage")] string CurrentLanguage
    )
    {
        public static class Defaults
        {
            public static PreLogin None => new("", "", "");
            public static PreLogin Steam => None with { AccountType = "Console" };
        }
    }
}
