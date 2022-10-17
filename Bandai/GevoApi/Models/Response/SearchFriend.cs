#pragma warning disable IDE1006
namespace Bandai.GevoApi.Models.Response
{
    public record SearchFriend : Base
    {
        public bool found { get; set; } = false;
        public int playerId { get; set; } = 0;
    }
}
#pragma warning restore IDE1006

