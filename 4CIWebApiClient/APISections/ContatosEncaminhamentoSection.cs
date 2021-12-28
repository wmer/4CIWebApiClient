using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ContatosEncaminhamentoSection {
        private CosumingHelper _api;

        public ContatosEncaminhamentoSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ContatoEncaminhamento>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ContatoEncaminhamento>>($"api/ContatosEncaminhamento");
            return result.result;
        }

        public async Task<PaginatedList<ContatoEncaminhamento>> GetAsync(string token, int? page, string strsearch = null, int? faixaCobId = null, int pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ContatoEncaminhamento>>($"api/ContatosEncaminhamento/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&faixaCobId={faixaCobId}");
            return result.result;
        }

        public async Task<ContatoEncaminhamento> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ContatoEncaminhamento>($"api/ContatosEncaminhamento/{id}");
            return result.result;
        }

        public async Task<ContatoEncaminhamento> CreateAsync(string token, ContatoEncaminhamento cnalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ContatoEncaminhamento, ContatoEncaminhamento>($"api/ContatosEncaminhamento", cnalCobranca);
            return result.result;
        }

        public async Task<ContatoEncaminhamento> EditAsync(string token, ContatoEncaminhamento ContatoEncaminhamento) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ContatoEncaminhamento, ContatoEncaminhamento>($"api/ContatosEncaminhamento", ContatoEncaminhamento);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ContatosEncaminhamento/{id}");
            return result.result;
        }
    }
}
