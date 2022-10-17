#pragma warning disable IDE1006 // Naming Styles
namespace Bandai.GevoApi.Models.Request
{
    public record Login
    {
        public string authToken { get; set; } = string.Empty;
        public string accountType { get; set; } = string.Empty;
        public List<int> packageVersion { get; set; } = new(){ 0, 0, 0, 0 };
        public string platformInfo { get; set; } = string.Empty;
        public string osInfo { get; set; } = string.Empty;
        public string cpuInfo { get; set; } = string.Empty;
        public string memInfo { get; set; } = string.Empty;
        public List<object> gpuInfos { get; set; } = new();
        public List<int> macAddress { get; set; } = new() { 0, 0, 0, 0, 0, 0 };
        public Guid hddUuid { get; set; } = Guid.Empty;
        public int matchingArea { get; set; } = 0;
        public bool CreateConsoleSession { get; set; } = false;

        public static class Defaults
        {
            public static Login Steam => new()
                {
                    accountType = "Console",
                    packageVersion = new() { 999, 999, 999, 999999 },
                    platformInfo = "Steam",
                    CreateConsoleSession = true
                };
        }
    }
}
#pragma warning restore IDE1006 // Naming Styles
