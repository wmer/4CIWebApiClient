using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class TriggerDefinitionSection {
        private CosumingHelper _api;

        public TriggerDefinitionSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<TriggerDefinition>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<TriggerDefinition>>($"api/TriggerDefinitions");
            return result.result;
        }

        public async Task<PaginatedList<TriggerDefinition>> GetAsync(string token, int? page, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<TriggerDefinition>>($"api/TriggerDefinitions/Pagina/{page}?pageSize={pageSize}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<TriggerDefinition> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<TriggerDefinition>($"api/TriggerDefinitions/{id}");
            return result.result;
        }

        public async Task<TriggerDefinition> CreateAsync(string token, TriggerDefinition triggerDefinition) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<TriggerDefinition, TriggerDefinition>($"api/TriggerDefinitions", triggerDefinition);
            return result.result;
        }

        public async Task<TriggerDefinition> EditAsync(string token, TriggerDefinition triggerDefinition) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<TriggerDefinition, TriggerDefinition>($"api/TriggerDefinitions", triggerDefinition);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/TriggerDefinitions/{id}");
            return result.result;
        }
    }
}
