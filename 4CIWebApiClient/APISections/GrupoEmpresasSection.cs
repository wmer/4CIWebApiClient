using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class GrupoEmpresasSection {
        private CosumingHelper _api;
         
        public GrupoEmpresasSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<GrupoEmpresas>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<GrupoEmpresas>>($"api/GrupoEmpresas");
            return result.result;
        }

        public async Task<PaginatedList<GrupoEmpresas>> GetAsync(string token, int? page, string strsearch = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<GrupoEmpresas>>($"api/GrupoEmpresas/Pagina/{page}?pageSize={pageSize}&name={strsearch}");
            return result.result;
        }

        public async Task<GrupoEmpresas> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<GrupoEmpresas>($"api/GrupoEmpresas/{id}");
            return result.result;
        }

        public async Task<GrupoEmpresas> CreateAsync(string token, GrupoEmpresas grupoEmpresas) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<GrupoEmpresas, GrupoEmpresas>($"api/GrupoEmpresas", grupoEmpresas);
            return result.result;
        }

        public async Task<GrupoEmpresas> EditAsync(string token, GrupoEmpresas grupoEmpresas) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<GrupoEmpresas, GrupoEmpresas>($"api/GrupoEmpresas", grupoEmpresas);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/GrupoEmpresas/{id}");
            return result.result;
        }

    }
}
