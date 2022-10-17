using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandai.GevoApi
{
    public static class REST
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<Models.Response.PreLogin?> PreLogin(Models.Request.PreLogin data, RestClient client) => await client.PostJsonAsync<Models.Request.PreLogin, Models.Response.PreLogin>("Auth/PreLogin", data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<Models.Response.Login?> Login(Models.Request.Login data, RestClient client) => await client.PostJsonAsync<Models.Request.Login, Models.Response.Login>("Auth/Login", data);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<object?> HandShake(RestClient client) => await client.PostJsonAsync<object, object /* Unimplemented Response Type */ >("HandShake", new { });

        public static async Task<Models.Response.SearchFriend?> SearchFriend(Models.Request.SearchFriend data, RestClient client) => await client.PostJsonAsync<Models.Request.SearchFriend, Models.Response.SearchFriend /* Unimplemented Response Type */ >("Social/SearchFriend",  data);

    }
}
