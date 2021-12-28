using _4CIWeb.Data.ApiModels;
using _4CIWeb.Data.Models;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ArquivosFaixaCobrancaSection {
        private CosumingHelper _api;

        public ArquivosFaixaCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ArquivoFaixaCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ArquivoFaixaCobranca>>($"api/ArquivosFaixaCobranca");
            return result.result;
        }

        public async Task<PaginatedList<ArquivoFaixaCobranca>> GetAsync(string token, int? page, int? faixaCobId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ArquivoFaixaCobranca>>($"api/ArquivosFaixaCobranca/Pagina/{page}?pageSize={pageSize}&faixaId={faixaCobId}");
            return result.result;
        }

        public async Task<ArquivoFaixaCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ArquivoFaixaCobranca>($"api/ArquivosFaixaCobranca/{id}");
            return result.result;
        }

        public async Task<ArquivoFaixaCobranca> CreateAsync(string token, ArquivoFaixaCobranca mensagemAlternativa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ArquivoFaixaCobranca, ArquivoFaixaCobranca>($"api/ArquivosFaixaCobranca", mensagemAlternativa);
            return result.result;
        }

        public async Task<ArquivoFaixaCobranca> EditAsync(string token, ArquivoFaixaCobranca ArquivoFaixaCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ArquivoFaixaCobranca, ArquivoFaixaCobranca>($"api/ArquivosFaixaCobranca", ArquivoFaixaCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ArquivosFaixaCobranca/{id}");
            return result.result;
        }
    }
}
