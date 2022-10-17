using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Bandai.GevoApi.Models.Request;
using RestSharp;
using RestSharp.Authenticators;

namespace Bandai.GevoApi
{

    public abstract class BaseClient
    {
        protected abstract RestClient RestClient { get; }

        protected async Task KeepAlive()
        {
            while (true)
            {
                await REST.HandShake(RestClient);
                Debug.WriteLine("Handshake was successful");
            }
        }
        public async Task<Models.Response.SearchFriend> SearchFriend(string name)
        {
            var friend = await REST.SearchFriend(new(){ playerName = name }, RestClient);
            ArgumentNullException.ThrowIfNull(friend);
            if(friend.IsError)
                throw new ArgumentException("SearchFriend returned an error.");
            return friend;
        }
        public abstract Task LoginAsync(string authentication);
    }

    public sealed class SteamClient : BaseClient
    {

        protected override RestClient RestClient { get; } = new RestClient("https://api.gundamevogame.com/api").AddDefaultHeader("Platform", "Steam");

        public override async Task LoginAsync(string authentication)
        {
            var otp = await REST.PreLogin(PreLogin.Defaults.Steam with { authToken = authentication }, RestClient);
            ArgumentNullException.ThrowIfNull(otp);
            if(otp.IsError)
                throw new ArgumentException("PreLogin returned an error.");

            var jwt = await REST.Login(Login.Defaults.Steam with { authToken = otp.token }, RestClient);
            ArgumentNullException.ThrowIfNull(jwt);
            if (jwt.IsError)
                throw new ArgumentException("Login returned an error");

            RestClient.Authenticator = new JwtAuthenticator(jwt.token);

            _ = Task.Run(KeepAlive); //begin the heartbeat process to keep jwt valid.
        }

    }
}
