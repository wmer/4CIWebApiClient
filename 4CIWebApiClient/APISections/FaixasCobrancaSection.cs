using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class FaixasCobrancaSection {
        private CosumingHelper _api;

        public FaixasCobrancaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<FaixaCobranca>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<FaixaCobranca>>($"api/FaixasCobranca");
            return result.result;
        }

        public async Task<PaginatedList<FaixaCobranca>> GetAsync(string token, int? page, string reguaName = null, string canal = null, string tipo = null, string inicioFaixa = null, string fimFaixa = null, int? reguaCorancaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<FaixaCobranca>>($"api/FaixasCobranca/Pagina/{page}?pageSize={pageSize}&reguaName={reguaName}&canal={canal}&tipo={tipo}& inicioFaixa={inicioFaixa}&fimFaixa={fimFaixa}&reguaCorancaId={reguaCorancaId}");
            return result.result;
        }

        public async Task<FaixaCobranca> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<FaixaCobranca>($"api/FaixasCobranca/{id}");
            return result.result;
        }

        public async Task<FaixaCobranca> CreateAsync(string token, FaixaCobranca faixaCpbranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<FaixaCobranca, FaixaCobranca>($"api/FaixasCobranca", faixaCpbranca);
            return result.result;
        }

        public async Task<List<FaixaCobranca>> CreateAsync(string token, List<FaixaCobranca> faixas) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<List<FaixaCobranca>, List<FaixaCobranca>>($"api/FaixasCobranca/InMass", faixas);
            return result.result;
        }

        public async Task<FaixaCobranca> EditAsync(string token, FaixaCobranca FaixaCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<FaixaCobranca, FaixaCobranca>($"api/FaixasCobranca", FaixaCobranca);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/FaixasCobranca/{id}");
            return result.result;
        }
    }
}
