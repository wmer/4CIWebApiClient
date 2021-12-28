using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ContatoOperacionalSection {
        private CosumingHelper _api;
         
        public ContatoOperacionalSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ContatoOperacional>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ContatoOperacional>>($"api/ContatosOperacionais");
            return result.result;
        }

        public async Task<PaginatedList<ContatoOperacional>> GetAsync(string token, int? page, string strsearch = null, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ContatoOperacional>>($"api/ContatosOperacionais/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<ContatoOperacional> DetailsAsync(string token, int?  id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ContatoOperacional>($"api/ContatosOperacionais/{id}");
            return result.result;
        }

        public async Task<ContatoOperacional> CreateAsync(string token, ContatoOperacional grupoContatosOperacionais) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ContatoOperacional, ContatoOperacional>($"api/ContatosOperacionais", grupoContatosOperacionais);
            return result.result;
        }

        public async Task<ContatoOperacional> EditAsync(string token, ContatoOperacional grupoContatosOperacionais) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ContatoOperacional, ContatoOperacional>($"api/ContatosOperacionais", grupoContatosOperacionais);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ContatosOperacionais/{id}");
            return result.result;
        }
    }
}
