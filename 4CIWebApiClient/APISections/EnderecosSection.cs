using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class EnderecosSection {
        private CosumingHelper _api;

        public EnderecosSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<Endereco>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Endereco>>($"api/Enderecos");
            return result.result;
        }

        public async Task<PaginatedList<Endereco>> GetAsync(string token, int? page, string strsearch = null, int? municipioId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Endereco>>($"api/Enderecos/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}&municipioId={municipioId}");
            return result.result;
        }

        public async Task<Endereco> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Endereco>($"api/Enderecos/{id}");
            return result.result;
        }

        public async Task<Endereco> CreateAsync(string token, Endereco grupoEnderecos) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<Endereco, Endereco>($"api/Enderecos", grupoEnderecos);
            return result.result;
        }

        public async Task<Endereco> EditAsync(string token, Endereco grupoEnderecos) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<Endereco, Endereco>($"api/Enderecos", grupoEnderecos);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/Enderecos/{id}");
            return result.result;
        }
    }
}
