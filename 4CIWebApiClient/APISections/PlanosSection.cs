using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class PlanosSection {
        private CosumingHelper _api;

        public PlanosSection(CosumingHelper api) {
            _api = api; 
        }

        public async Task<Empresa> SetStatuscobrancaAsync(string token, int empresaId) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Empresa>($"api/Planos/SetSuspensaoCobranca/{empresaId}");
            return result.result;
        }
    }
}
