using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class CanaisCobrancaSection {
        private CosumingHelper _api;

        public CanaisCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<CanalCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<CanalCobranca>>($"api/CanaisCobranca");
            return result.result;
        }

        public async Task<PaginatedList<CanalCobranca>> GetAsync(string token, int? page, string strsearch = null, int pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<CanalCobranca>>($"api/CanaisCobranca/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}");
            return result.result;
        }

        public async Task<CanalCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<CanalCobranca>($"api/CanaisCobranca/{id}");
            return result.result;
        }

        public async Task<CanalCobranca> CreateAsync(string token, CanalCobranca cnalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<CanalCobranca, CanalCobranca>($"api/CanaisCobranca", cnalCobranca);
            return result.result;
        }

        public async Task<CanalCobranca> EditAsync(string token, CanalCobranca canalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<CanalCobranca, CanalCobranca>($"api/CanaisCobranca", canalCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/CanaisCobranca/{id}");
            return result.result;
        }
    }
}
