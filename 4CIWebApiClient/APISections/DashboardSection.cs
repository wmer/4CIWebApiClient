using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class DashboardSection {
        private CosumingHelper _api;

        public DashboardSection(CosumingHelper api) {
            _api = api;
        }


        public async Task<List<EvidenciasDeServico>> GetEvidenciasServico(string token, EvidenciasSearch evidencias) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<EvidenciasSearch, List<EvidenciasDeServico>>($"api/Dashboard/EventosCobranca", evidencias);
            return result.result;
        }

        public async Task<List<ConsolidadoDia>> GetConsolidadoDia(string token, int empresaId, string initalDateStr, string finalDateStr) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ConsolidadoDia>>($"api/Dashboard/EnviosDiarioConsolidado/{empresaId}?initalDateStr={initalDateStr}&finalDateStr={finalDateStr}");
            return result.result;
        }

        public async Task<List<ConsolidadoAtraso>> GetConsolidadoAtraso(string token, int empresaId, string initalDateStr, string finalDateStr) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ConsolidadoAtraso>>($"api/Dashboard/AtrasosConsolidado/{empresaId}?initalDateStr={initalDateStr}&finalDateStr={finalDateStr}");
            return result.result;
        }

        public async Task<List<ConsolidadoStatus>> GetConsolidadoStatus(string token, int empresaId, string initalDateStr, string finalDateStr) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ConsolidadoStatus>>($"api/Dashboard/StatusConsolidado/{empresaId}?initalDateStr={initalDateStr}&finalDateStr={finalDateStr}");
            return result.result;
        }
    }
}
