using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class MensagensSection {
        private CosumingHelper _api;

        public MensagensSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<Mensagem>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Mensagem>>($"api/Mensagens");
            return result.result;
        }

        public async Task<PaginatedList<Mensagem>> GetAsync(string token, int? page, string dtIni = null, string dtFim = null, string status = null, string canal = null, string tipo = null, int? campanhaId = null, int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Mensagem>>($"api/Mensagens/Pagina/{page}?pageSize={pageSize}&dtIni={dtIni}&dtFim={dtFim}&status={status}&canal={canal}&tipo={tipo}&campanhaId={campanhaId}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<Mensagem> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Mensagem>($"api/Mensagens/{id}");
            return result.result;
        }

        public async Task<Mensagem> CreateAsync(string token, Mensagem mensagem) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<Mensagem, Mensagem>($"api/Mensagens", mensagem);
            return result.result;
        }

        public async Task<Mensagem> EditAsync(string token, Mensagem Mensagem) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<Mensagem, Mensagem>($"api/Mensagens", Mensagem);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/Mensagens/{id}");
            return result.result;
        }
    }
}
