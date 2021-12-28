using _4CIWeb.Data.ApiModels;
using _4CIWeb.Data.Models;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class CampanhasSection {
        private CosumingHelper _api;

        public CampanhasSection(CosumingHelper api) {
            _api = api;
        }


        public async Task<BaseEnviados> GetBaseEnviadosAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<BaseEnviados>($"api/Campanhas/BaseEnviados/Check");
            return result.result;
        }

        public async Task<BaseEnviados> PostBaseEnviadosAsync(string token, BaseEnviados baseEnviados) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<BaseEnviados, BaseEnviados>($"api/Campanhas/BaseEnviados", baseEnviados);
            return result.result;
        }

        public async Task<RelatorioSendGrid> GetRelatorioSendGridAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<RelatorioSendGrid>($"api/Campanhas/RelatorioSendGrid/Check");
            return result.result;
        }

        public async Task<RelatorioSendGrid> PostRelatorioSendGridAsync(string token, RelatorioSendGrid baseEnviados) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<RelatorioSendGrid, RelatorioSendGrid>($"api/Campanhas/RelatorioSendGrid", baseEnviados);
            return result.result;
        }

        public async Task<List<Campanha>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Campanha>>($"api/Campanhas");
            return result.result;
        }

        public async Task<PaginatedList<Campanha>> GetAsync(string token, int? page, string nome = null, string dtIni = null, string dtFim = null, string status = null,  string canal = null, string tipo = null, string criadoPor = null, int? empresaId = null, int? reguaId = null, int? faixaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Campanha>>($"api/Campanhas/Pagina/{page}?pageSize={pageSize}&nome={nome}&dtIni={dtIni}&dtFim={dtFim}&status={status}&canal={canal}&tipo={tipo}&criadoPor={criadoPor}&empresaId={empresaId}&reguaId={reguaId}&faixaId={faixaId}");
            return result.result;
        }

        public async Task<Campanha> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Campanha>($"api/Campanhas/{id}");
            return result.result;
        }

        public async Task<Campanha> CreateAsync(string token, Campanha campanha) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<Campanha, Campanha>($"api/Campanhas", campanha);
            return result.result;
        }

        public async Task<Campanha> EditAsync(string token, Campanha Campanha) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<Campanha, Campanha>($"api/Campanhas", Campanha);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/Campanhas/{id}");
            return result.result;
        }
    }
}
