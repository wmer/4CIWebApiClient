using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class IBGESection {
        private CosumingHelper _api;

        public IBGESection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<Estado>> GetEstadosAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Estado>>($"api/Enderecos/IBGE/Estados");
            return result.result;
        }

        public async Task<Estado> GetEstadoAsync(string token, int estadoId) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Estado>($"api/Enderecos/IBGE/Estados/{estadoId}");
            return result.result;
        }

        public async Task<List<Municipio>> GetMunicipiosAsync(string token, string uf) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Municipio>>($"api/Enderecos/IBGE/Municipios/{uf}");
            return result.result;
        }

        public async Task<Municipio> GetmunicipioAsync(string token, int municipioId) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Municipio>($"api/Enderecos/IBGE/Municipios/{municipioId}");
            return result.result;
        }
    }
}
