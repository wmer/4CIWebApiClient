using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class ServiceCredentialSection {
        private CosumingHelper _api;

        public ServiceCredentialSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<ServiceCredential>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<ServiceCredential>>($"api/ServicesCredentials");
            return result.result;
        }

        public async Task<PaginatedList<ServiceCredential>> GetAsync(string token, int? page, string strsearch = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<ServiceCredential>>($"api/ServicesCredentials/Pagina/{page}?pageSize={pageSize}&searchTerm={strsearch}");
            return result.result;
        }

        public async Task<ServiceCredential> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<ServiceCredential>($"api/ServicesCredentials/{id}");
            return result.result;
        }

        public async Task<ServiceCredential> CreateAsync(string token, ServiceCredential cnalCobranca) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<ServiceCredential, ServiceCredential>($"api/ServicesCredentials", cnalCobranca);
            return result.result;
        }

        public async Task<ServiceCredential> EditAsync(string token, ServiceCredential ServiceCredential) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<ServiceCredential, ServiceCredential>($"api/ServicesCredentials", ServiceCredential);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/ServicesCredentials/{id}");
            return result.result;
        }
    }
}
