using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class TipoCobrancaSection {
        private CosumingHelper _api;

        public TipoCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<TipoCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<TipoCobranca>>($"api/TiposCobranca");
            return result.result;
        }

        public async Task<PaginatedList<TipoCobranca>> GetAsync(string token, int? page, string strsearch = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<TipoCobranca>>($"api/TiposCobranca/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}");
            return result.result;
        }

        public async Task<TipoCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<TipoCobranca>($"api/TiposCobranca/{id}");
            return result.result;
        }

        public async Task<TipoCobranca> CreateAsync(string token, TipoCobranca cnalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<TipoCobranca, TipoCobranca>($"api/TiposCobranca", cnalCobranca);
            return result.result;
        }

        public async Task<TipoCobranca> EditAsync(string token, TipoCobranca TipoCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<TipoCobranca, TipoCobranca>($"api/TiposCobranca", TipoCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/TiposCobranca/{id}");
            return result.result;
        }
    }
}
