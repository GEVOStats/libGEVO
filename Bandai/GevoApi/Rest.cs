using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Request = Bandai.GevoApi.Models.Request;
using Response = Bandai.GevoApi.Models.Response;

namespace Bandai.GevoApi
{
    public static class REST
    {
        public static class Auth
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="data"></param>
            /// <param name="client"></param>
            /// <returns></returns>
            public static async Task<Response.Auth.PreLogin?> PreLogin(Request.Auth.PreLogin data, RestClient client) => await client.PostJsonAsync<Request.Auth.PreLogin, Response.Auth.PreLogin>("Auth/PreLogin", data);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="data"></param>
            /// <param name="client"></param>
            /// <returns></returns>
            public static async Task<Response.Auth.Login?> Login(Request.Auth.Login data, RestClient client) => await client.PostJsonAsync<Request.Auth.Login, Response.Auth.Login>("Auth/Login", data);
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<object?> HandShake(RestClient client) => await client.PostJsonAsync<object, object /* Unimplemented Response Type */ >("HandShake", new { });

        public static async Task<Response.SearchFriend?> SearchFriend(Request.SearchFriend data, RestClient client) => await client.PostJsonAsync<Request.SearchFriend, Response.SearchFriend /* Unimplemented Response Type */ >("Social/SearchFriend",  data);

    }
}
