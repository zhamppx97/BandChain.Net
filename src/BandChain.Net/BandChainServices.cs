using BandChain.Net.Models;
using BandChain.Net.Services;
using System.Threading.Tasks;

namespace BandChain.Net
{
    public class BandChainServices
    {
        private readonly ApiServices _apiServices = new();

        public async Task<OracleDataSources> OracleDataSoursesAsync(int Id)
        {
            return await _apiServices.OracleDataSoursesAsync(Id);
        }
    }
}
