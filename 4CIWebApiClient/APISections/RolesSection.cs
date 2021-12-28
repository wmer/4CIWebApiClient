using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class RolesSection {
        private CosumingHelper _api;

        public RolesSection(CosumingHelper api) {
            _api = api;
        }


        public async Task<List<Funcao>> GetAsync(string token) {
            var result = await _api
                                    .GetAssync<List<Funcao>>("api/Roles");
            return result.result;
        }
    }
}
