using _4CIWeb.Data.Models;
using _4CIWeb.Data.ApiModels;
using ManyHelpers.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CIWebApiClient.APISections {
    public class LogsSection {
        private CosumingHelper _api;

        public LogsSection(CosumingHelper api) {
            _api = api;
        }

        public async Task<Log> CreateAsync(Log log, string token) {
            var result = await _api
                                .AddBearerAuthentication(token)
                                .PostAsync<Log, Log>($"api/Logs", log);
            return result.result;
        }

        public async Task<PaginatedList<Log>> GetAsync(string token, int? page, string tipo, string search, string date, int? pageSize = 100) {
            var result = await _api
                                    .AddBearerAuthentication(token)
                                    .GetAssync<PaginatedList<Log>>($"api/Logs/Pagina/{page}?pageSize={pageSize}&tipo={tipo}&search={search}&date={date}");
            return result.result;
        }
    }
}
