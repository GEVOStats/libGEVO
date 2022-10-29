using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Response
{
    public record Error(
        [property: JsonPropertyName("errCode")] int ErrCode,
        [property: JsonPropertyName("subCode")] int SubCode,
        [property: JsonPropertyName("param1")] string Param1
    );
}
