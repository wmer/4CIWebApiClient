using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class UploadedFileSection {
        private CosumingHelper _api;

        public UploadedFileSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<List<UploadedFile>> GetAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<UploadedFile>>($"api/UploadedFiles");
            return result.result;
        }

        public async Task<List<string>> GetBlobContainersAsync(string token) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<List<string>>($"api/UploadedFiles/Azure/BlobContainers");
            return result.result;
        }

        public async Task<PaginatedList<UploadedFile>> GetFromAzureAsync(string token, int? page, string fileTipo = null, bool onlyInAzure = true, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<UploadedFile>>($"api/UploadedFiles/Azure/Pagina/{page}?pageSize={pageSize}&fileTipo={fileTipo}&onlyInAzure={onlyInAzure}");
            return result.result;
        }

        public async Task<PaginatedList<UploadedFile>> GetAsync(string token, int? page, string fileNme, string uploaddateIni = null, string uploaddateFim = null, string fileTipo = null, string userId = null, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<UploadedFile>>($"api/UploadedFiles/Pagina/{page}?fileNme={fileNme}&pageSize={pageSize}&uploaddateIni={uploaddateIni}&uploaddateFim={uploaddateFim}&fileTipo={fileTipo}&userId={userId}");
            return result.result;
        }

        public async Task<UploadedFile> DetailsAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<UploadedFile>($"api/UploadedFiles/{id}");
            return result.result;
        }

        public async Task<UploadedFile> CreateAsync(string token, UploadedFile uploadedFile) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PostAsync<UploadedFile, UploadedFile>($"api/UploadedFiles", uploadedFile);
            return result.result;
        }

        public async Task<UploadedFile> EditAsync(string token, UploadedFile uploadedFile) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .PutAsync<UploadedFile, UploadedFile>($"api/UploadedFiles", uploadedFile);
            return result.result;
        }

        public async Task<bool> DeleteAsync(string token, int? id) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/UploadedFiles/{id}");
            return result.result;
        }

        public async Task<bool> DeleteFromAzureAsync(string token, string link, string container) {
            var escapedLink = Uri.EscapeDataString(link);
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .DeleteAsync($"api/UploadedFiles/Azure/{container}?link={escapedLink}");
            return result.result;
        }
    }
}
