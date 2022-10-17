#pragma warning disable IDE1006
namespace Bandai.GevoApi.Models.Response
{
    public record Login : Base
    {
        public string token { get; set; } = string.Empty;
        public int playerId { get; set; } = 0;
        public int matchingArea { get; set; } = 0;
        public int initialLevel { get; set; } = 0;
        public int privilegeLevel { get; set; } = 0;
        public bool returnBattle { get; set; } = false;
        public int secessionMatchPhase { get; set; } = 0;
        public string apiServerVersion { get; set; } = string.Empty;
        public int bonusProgress { get; set; } = 0; 
        public int tutorialProgress { get; set; } = 0;
        public List<string> opsNoticeCodes { get; set; } = new();
        public List<object> disabledMobileSuits { get; set; } = new(); //probably string, currently unused.
        public bool warning { get; set; } = false;
        public string warningTitle { get; set; } = string.Empty;
        public string warningText { get; set; } = string.Empty;
        public string penaltyRemainingTime { get; set; } = string.Empty;
        public bool isNewSeason { get; set; } = false;
    }
}
#pragma warning restore IDE1006

