#pragma warning disable IDE1006
namespace Bandai.GevoApi.Models.Response
{
    public record PreLogin : Base
    {
        public string token { get; set; } = "";
        public int matchingArea { get; set; } = 0;
        public string countryCode { get; set; } = "";
        public bool returnBattle { get; set; } = false;
        public bool agreedServiceTerm { get; set; } = false;
        public List<ServiceTerm> serviceTerms { get; set; } = new List<ServiceTerm>();
        public int season { get; set; } = 0;

        public class ServiceTerm
        {
            public int type { get; set; } = 0;
            public int languageCode { get; set; } = 0; 
            public int platform { get; set; } = 0; 
            public int countryCode { get; set; } = 0;
            public string title { get; set; } = "";
            public string text { get; set; } = "";
            public int majorVersion { get; set; } = 0;
            public int minorVersion { get; set; } = 0;
            public int termId { get; set; } = 0;
        }
    }
}
#pragma warning restore IDE1006

