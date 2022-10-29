using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using RestSharp;
using RestSharp.Authenticators;

using Request = Bandai.GevoApi.Models.Request;
using Response = Bandai.GevoApi.Models.Response;

namespace Bandai.GevoApi
{

    public abstract class BaseClient
    {
        protected abstract RestClient RestClient { get; }
        public bool LoggedIn { get; private set; } = false;

        protected async Task KeepAlive()
        {
            LoggedIn = true;
            while (LoggedIn)
            {
                await REST.HandShake(RestClient);
                Debug.WriteLine("Handshake was successful");
            }
        }
        public async Task<Response.Social.SearchFriend> SearchFriend(string name)
        {
            var friend = await REST.SearchFriend(new(name), RestClient);
            ArgumentNullException.ThrowIfNull(friend);
            if(friend.IsError)
                throw new ArgumentException("SearchFriend returned an error.");
            return friend;
        }

        public void Auth_Logout()
        {

        }

        public void Auth()
        {
            void Logout()
            {

            }
        }

        public async Task Logout()
        {
            LoggedIn = false;
            await REST.Auth.Logout(RestClient);
        }
        public abstract Task LoginAsync(string authentication);
    }

    public sealed class SteamClient : BaseClient
    {

        protected override RestClient RestClient { get; } = new RestClient("https://api.gundamevogame.com/api").AddDefaultHeader("Platform", "Steam");

        public override async Task LoginAsync(string authentication)
        {
            var otp = await REST.Auth.PreLogin(Request.Auth.PreLogin.Defaults.Steam with { AuthToken = authentication }, RestClient);
            ArgumentNullException.ThrowIfNull(otp);
            if(otp.IsError)
                throw new ArgumentException("PreLogin returned an error.");

            var jwt = await REST.Auth.Login(Request.Auth.Login.Defaults.Steam with { AuthToken = otp.Token }, RestClient);
            ArgumentNullException.ThrowIfNull(jwt);
            if (jwt.IsError)
                throw new ArgumentException("Login returned an error");

            RestClient.Authenticator = new JwtAuthenticator(jwt.Token);

            _ = Task.Run(KeepAlive); //begin the heartbeat process to keep jwt valid.
        }

    }
}
