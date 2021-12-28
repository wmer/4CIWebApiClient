using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ContatoMonitoriaSection {
        private CosumingHelper _api;
         
        public ContatoMonitoriaSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ContatoMonitoria>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ContatoMonitoria>>($"api/ContatosMonitoria");
            return result.result;
        }

        public async Task<PaginatedList<ContatoMonitoria>> GetAsync(string token, int? page, string searchStr = null, string user = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ContatoMonitoria>>($"api/ContatosMonitoria/Pagina/{page}?pageSize={pageSize}&searchStr={searchStr}&user={user}");
            return result.result;
        }

        public async Task<ContatoMonitoria> DetailsAsync(string token, int?  id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ContatoMonitoria>($"api/ContatosMonitoria/{id}");
            return result.result;
        }

        public async Task<ContatoMonitoria> CreateAsync(string token, ContatoMonitoria grupoContatosOperacionais) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ContatoMonitoria, ContatoMonitoria>($"api/ContatosMonitoria", grupoContatosOperacionais);
            return result.result;
        }

        public async Task<ContatoMonitoria> EditAsync(string token, ContatoMonitoria grupoContatosOperacionais) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ContatoMonitoria, ContatoMonitoria>($"api/ContatosMonitoria", grupoContatosOperacionais);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ContatosMonitoria/{id}");
            return result.result;
        }
    }
}
