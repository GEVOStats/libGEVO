#pragma warning disable IDE1006
using Bandai.GevoApi.Models.Response;

namespace Bandai.GevoApi.Models.Response.Social
{
    public record SearchFriend : Base
    {
        public bool found { get; set; } = false;
        public int playerId { get; set; } = 0;
    }
}
#pragma warning restore IDE1006

