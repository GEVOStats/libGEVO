#pragma warning disable IDE1006 // Naming Styles
namespace Bandai.GevoApi.Models.Request.Social
{
    public record SearchFriend
    {
        public string playerName { get; set; } = string.Empty;
    }
}
#pragma warning restore IDE1006 // Naming Styles