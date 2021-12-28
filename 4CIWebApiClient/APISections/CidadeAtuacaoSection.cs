using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class CidadesAtuacaoSection {
        private CosumingHelper _api;

        public CidadesAtuacaoSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<CidadeAtuacao>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<CidadeAtuacao>>($"api/CidadesAtuacao");
            return result.result;
        }

        public async Task<PaginatedList<CidadeAtuacao>> GetAsync(string token, int? page, string strsearch = null, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<CidadeAtuacao>>($"api/CidadesAtuacao/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<CidadeAtuacao> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<CidadeAtuacao>($"api/CidadesAtuacao/{id}");
            return result.result;
        }

        public async Task<CidadeAtuacao> CreateAsync(string token, CidadeAtuacao grupoContatosEmpresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<CidadeAtuacao, CidadeAtuacao>($"api/CidadesAtuacao", grupoContatosEmpresa);
            return result.result;
        }

        public async Task<CidadeAtuacao> EditAsync(string token, CidadeAtuacao grupoContatosEmpresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<CidadeAtuacao, CidadeAtuacao>($"api/CidadesAtuacao", grupoContatosEmpresa);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/CidadesAtuacao/{id}");
            return result.result;
        }
    }
}
