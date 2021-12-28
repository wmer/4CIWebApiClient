using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class HistoricoParalizacaoCobrancaSection {
        private CosumingHelper _api;

        public HistoricoParalizacaoCobrancaSection(CosumingHelper api) {
            _api = api;
        }


        public async Task<HistoricoParalizacaoCobranca> CreteAsync(string token, HistoricoParalizacaoCobranca historico) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<HistoricoParalizacaoCobranca, HistoricoParalizacaoCobranca>($"api/HistoricoParalizacaoCobrancas", historico);
            return result.result;
        }

    }
}
