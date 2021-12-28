using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ReguasCobrancaSection {
        private CosumingHelper _api;

        public ReguasCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ReguaCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ReguaCobranca>>($"api/ReguasCobranca");
            return result.result;
        }

        public async Task<PaginatedList<ReguaCobranca>> GetAsync(string token, int? page, string strsearch = null, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ReguaCobranca>>($"api/ReguasCobranca/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<ReguaCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ReguaCobranca>($"api/ReguasCobranca/{id}");
            return result.result;
        }

        public async Task<ReguaCobranca> CreateAsync(string token, ReguaCobranca cnalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ReguaCobranca, ReguaCobranca>($"api/ReguasCobranca", cnalCobranca);
            return result.result;
        }

        public async Task<ReguaCobranca> EditAsync(string token, ReguaCobranca ReguaCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ReguaCobranca, ReguaCobranca>($"api/ReguasCobranca", ReguaCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ReguasCobranca/{id}");
            return result.result;
        }
    }
}
