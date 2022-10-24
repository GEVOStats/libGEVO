using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Bandai.GevoApi.Models.Request.Auth
{
    public record Login(
        [property: JsonPropertyName("authToken")] string AuthToken,
        [property: JsonPropertyName("accountType")] string AccountType,
        [property: JsonPropertyName("packageVersion")] IReadOnlyList<int> PackageVersion,
        [property: JsonPropertyName("platformInfo")] string PlatformInfo,
        [property: JsonPropertyName("osInfo")] string OsInfo,
        [property: JsonPropertyName("cpuInfo")] string CpuInfo,
        [property: JsonPropertyName("memInfo")] string MemInfo,
        [property: JsonPropertyName("gpuInfos")] IReadOnlyList<string> GpuInfos,
        [property: JsonPropertyName("macAddress")] IReadOnlyList<int> MacAddress,
        [property: JsonPropertyName("hddUuid")] Guid HddUuid,
        [property: JsonPropertyName("matchingArea")] int MatchingArea,
        [property: JsonPropertyName("CreateConsoleSession")] bool CreateConsoleSession
    )
    {
        public static class Defaults
        {
            public static Login None => new("", "", ImmutableArray.Create(0,0,0,0), "", "", "", "", ImmutableArray.Create<string>(), ImmutableArray.Create(0, 0, 0, 0, 0, 0), Guid.Empty, 0, false);
            public static Login Steam => None with
            {
                AccountType = "Console",
                PackageVersion = ImmutableArray.Create( 999, 999, 999, 999999),
                PlatformInfo = "Steam",
                CreateConsoleSession = true
            };
        }
    }
}
