using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class MensagemAlternativaFaixaCobrancaSection {
        private CosumingHelper _api;

        public MensagemAlternativaFaixaCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<MensagemAlternativaFaixaCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<MensagemAlternativaFaixaCobranca>>($"api/MensagensAlternativasFaixaCobranca");
            return result.result;
        }

        public async Task<PaginatedList<MensagemAlternativaFaixaCobranca>> GetAsync(string token, int? page, string strsearch = null, int? faixaCobId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<MensagemAlternativaFaixaCobranca>>($"api/MensagensAlternativasFaixaCobranca/Pagina/{page}?pageSize={pageSize}&searchStr={strsearch}&faixaId={faixaCobId}");
            return result.result;
        }

        public async Task<MensagemAlternativaFaixaCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<MensagemAlternativaFaixaCobranca>($"api/MensagensAlternativasFaixaCobranca/{id}");
            return result.result;
        }

        public async Task<MensagemAlternativaFaixaCobranca> CreateAsync(string token, MensagemAlternativaFaixaCobranca mensagemAlternativa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<MensagemAlternativaFaixaCobranca, MensagemAlternativaFaixaCobranca>($"api/MensagensAlternativasFaixaCobranca", mensagemAlternativa);
            return result.result;
        }

        public async Task<MensagemAlternativaFaixaCobranca> EditAsync(string token, MensagemAlternativaFaixaCobranca MensagemAlternativaFaixaCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<MensagemAlternativaFaixaCobranca, MensagemAlternativaFaixaCobranca>($"api/MensagensAlternativasFaixaCobranca", MensagemAlternativaFaixaCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/MensagensAlternativasFaixaCobranca/{id}");
            return result.result;
        }
    }
}
