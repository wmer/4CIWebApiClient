using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class UsuariosSection {
        private CosumingHelper _api;

        public UsuariosSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<Usuario>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<Usuario>>("api/Usuarios");
            return result.result;
        }

        public async Task<PaginatedList<Usuario>> GetAsync(string token, int page, string searchStr = "", string funcao = "", int? empresaId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Usuario>>($"api/Usuarios/Pagina/{page}?pageSize={pageSize}&search={searchStr}&funcao={funcao}&empresaId={empresaId}");
            return result.result;
        }

        public async Task<Usuario> DetailsAsync(string id, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Usuario>($"api/Usuarios/{id}");
            return result.result;
        }

        public async Task<Usuario> GetByNameAsync(string name, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Usuario>($"api/Usuarios/Name/{name}");
            return result.result;
        }

        public async Task<Usuario> GetLogado(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<Usuario>("api/Usuarios/Logado");
            return result.result;
        }



        public async Task<Usuario> CreateAsync(User usuario, string token) {
            var result = await _api
                                .AddBearerAuthentication(token)
                                .PostAsync<User, Usuario>($"api/Usuarios", usuario);
            return result.result;
        }

        public async Task<Usuario> AlterarSenhaAsync(string id, User usuario, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<User, Usuario>($"api/Usuarios/AlterarSenha/{id}", usuario);
            return result.result;
        }

        public async Task<Usuario> AlterarFuncoesAsync(string id, string[] funcoes, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<string[], Usuario>($"api/Usuarios/AlterarFuncao/{id}", funcoes);
            return result.result;
        }

        public async Task<Usuario> AlterarUserEmpresasAsync(string id, string[] empresasSel, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<string[], Usuario>($"api/Usuarios/AlterarEmpresas/{id}", empresasSel);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string id, string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/Usuarios/{id}");
            return result.result;
        }
    }
}
