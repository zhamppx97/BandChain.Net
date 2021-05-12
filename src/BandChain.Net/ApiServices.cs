using BandChain.Net.Infrastructure;
using BandChain.Net.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace BandChain.Net.Services
{
    public class ApiServices : IApiServices
    {
        public async Task<OracleDataSources> OracleDataSoursesAsync(int Id)
        {
            var url = BandChainBaseApi.Endpoint.OracleDataSourses(Id);
            var client = new RestClient(url)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            var response = await client.ExecuteAsync(request);
            var results = JsonConvert.DeserializeObject<OracleDataSources>(response.Content);
            return results;
        }
    }
}
