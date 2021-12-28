using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class EmpresasSection {
        private CosumingHelper _api;

        public EmpresasSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<Empresa>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Empresa>>($"api/Empresas");
            return result.result;
        }

        public async Task<PaginatedList<Empresa>> GetAsync(string token, int? page, string strsearch = null, int? grupoId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Empresa>>($"api/Empresas/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&grupoId={grupoId}");
            return result.result;
        }

        public async Task<Empresa> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Empresa>($"api/Empresas/{id}");
            return result.result;
        }

        public async Task<Empresa> CreateAsync(string token, Empresa empresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<Empresa, Empresa>($"api/Empresas", empresa);
            return result.result;
        }

        public async Task<Empresa> EditAsync(string token, Empresa mpresa) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<Empresa, Empresa>($"api/Empresas", mpresa);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/Empresas/{id}");
            return result.result;
        }
    }
}
