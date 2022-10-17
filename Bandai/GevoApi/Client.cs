using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Bandai.GevoApi.Models.Request;
using RestSharp;
namespace Bandai.GevoApi
{
    public interface IClient
    {
        public Task LoginAsync(string authentication);
    }
    public class SteamClient : IClient
    {
        private RestClient _client = new RestClient("https://api.gundamevogame.com/api").AddDefaultHeader("Platform", "Steam");

        public async Task LoginAsync(string token)
        {
            var otp = await REST.PreLogin(PreLogin.Defaults.Steam with { authToken = "" }, _client);
            ArgumentNullException.ThrowIfNull(otp);
            if(otp.IsError)
                throw new ArgumentException("PreLogin returned an error.");

            var jwt = await REST.Login(Login.Defaults.Steam with { authToken = otp.token }, _client);
            ArgumentNullException.ThrowIfNull(jwt);
            if (jwt.IsError)
                throw new ArgumentException("Login returned an error");

            
        }
    }
}
