using System.Collections.Immutable;
using System.Text.Json.Serialization;
using static Bandai.GevoApi.Models.Response.Auth.PreLogin;

namespace Bandai.GevoApi.Models.Response.Auth
{
    public record PreLogin(
        [property: JsonPropertyName("token")] string Token,
        [property: JsonPropertyName("matchingArea")] int MatchingArea,
        [property: JsonPropertyName("countryCode")] string CountryCode,
        [property: JsonPropertyName("returnBattle")] bool ReturnBattle,
        [property: JsonPropertyName("agreedServiceTerm")] bool AgreedServiceTerm,
        [property: JsonPropertyName("serviceTerms")] ImmutableList<ServiceTerm> ServiceTerms,
        [property: JsonPropertyName("season")] int Season
    ) : Base
    {
        public record ServiceTerm(
                [property: JsonPropertyName("type")] int Type,
                [property: JsonPropertyName("languageCode")] int LanguageCode,
                [property: JsonPropertyName("platform")] int Platform,
                [property: JsonPropertyName("countryCode")] int CountryCode,
                [property: JsonPropertyName("title")] string Title,
                [property: JsonPropertyName("text")] string Text,
                [property: JsonPropertyName("majorVersion")] int MajorVersion,
                [property: JsonPropertyName("minorVersion")] int MinorVersion,
                [property: JsonPropertyName("termId")] int TermId
        );
    }
}