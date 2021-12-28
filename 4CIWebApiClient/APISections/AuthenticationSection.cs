using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class AuthenticationSection {
        private CosumingHelper _api;

        public AuthenticationSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<GeneratedToken> loginAsync(User user) {
            var result = await _api.PostAsync<User, GeneratedToken>("api/Login", user);
            return result.result;
        }

    }
}
