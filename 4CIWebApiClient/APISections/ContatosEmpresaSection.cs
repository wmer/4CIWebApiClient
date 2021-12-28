using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ContatosEmpresaSection {
        private CosumingHelper _api;

        public ContatosEmpresaSection(CosumingHelper api) {
            _api = api;
        }  

        public async Task<List<ContatoEmpresa>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ContatoEmpresa>>($"api/ContatoEmpresas");
            return result.result;
        }

        public async Task<PaginatedList<ContatoEmpresa>> GetAsync(string token, int? page, string strsearch = null, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ContatoEmpresa>>($"api/ContatoEmpresas/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<ContatoEmpresa> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ContatoEmpresa>($"api/ContatoEmpresas/{id}");
            return result.result;
        }

        public async Task<ContatoEmpresa> CreateAsync(string token, ContatoEmpresa grupoContatosEmpresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ContatoEmpresa, ContatoEmpresa>($"api/ContatoEmpresas", grupoContatosEmpresa);
            return result.result;
        }

        public async Task<ContatoEmpresa> EditAsync(string token, ContatoEmpresa grupoContatosEmpresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ContatoEmpresa, ContatoEmpresa>($"api/ContatoEmpresas", grupoContatosEmpresa);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ContatoEmpresas/{id}");
            return result.result;
        }
    }
}
