using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class BehaviorDefinitionSection {
        private CosumingHelper _api;

        public BehaviorDefinitionSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<BehaviorDefinition>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<BehaviorDefinition>>($"api/BehaviorDefinitions");
            return result.result;
        }

        public async Task<PaginatedList<BehaviorDefinition>> GetAsync(string token, int? page, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<BehaviorDefinition>>($"api/BehaviorDefinitions/Pagina/{page}?pageSize={pageSize}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<BehaviorDefinition> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<BehaviorDefinition>($"api/BehaviorDefinitions/{id}");
            return result.result;
        }

        public async Task<BehaviorDefinition> CreateAsync(string token, BehaviorDefinition BehaviorDefinition) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<BehaviorDefinition, BehaviorDefinition>($"api/BehaviorDefinitions", BehaviorDefinition);
            return result.result;
        }

        public async Task<BehaviorDefinition> EditAsync(string token, BehaviorDefinition BehaviorDefinition) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<BehaviorDefinition, BehaviorDefinition>($"api/BehaviorDefinitions", BehaviorDefinition);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/BehaviorDefinitions/{id}");
            return result.result;
        }
    }
}
