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
        public static async Task<Models.Response.PreLogin?> PreLogin(Models.Request.PreLogin data, RestClient client) => await client.PostJsonAsync<Models.Request.PreLogin, Models.Response.PreLogin>("Auth/PreLogin", data);
        public static async Task<Models.Response.Login?> Login(Models.Request.Login data, RestClient client) => await client.PostJsonAsync<Models.Request.Login, Models.Response.Login>("Auth/Login", data);
    }
}
