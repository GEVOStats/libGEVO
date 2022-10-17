namespace Bandai.GevoApi.Models.Request
{
    public record PreLogin
    {
        public string authToken { get; set; } = string.Empty;
        public string accountType { get; set; } = string.Empty;
        public string currentLanguage { get; set; } = string.Empty;

        public static class Defaults
        {
            public static PreLogin Steam => new() { accountType = "Console" };
        }
    }
}
