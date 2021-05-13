using BandChain.Net.Models;
using BandChain.Net.Services;
using System.Threading.Tasks;

namespace BandChain.Net
{
    public class BandChainServices
    {
        private readonly ApiServices _apiServices = new();
        /// <summary>
        /// Get Data Source by ID
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        public async Task<OracleDataSources> OracleDataSoursesAsync(int Id)
        {
            return await _apiServices.OracleDataSoursesAsync(Id);
        }
        /// <summary>
        /// Get Oracle Script by ID
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        public async Task<OracleScripts> OracleScriptsAsync(int Id)
        {
            return await _apiServices.OracleScriptsAsync(Id);
        }
        /// <summary>
        /// Get Data Oracle Request by ID
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        public async Task<OracleRequests> OracleRequestsAsync(int Id)
        {
            return await _apiServices.OracleRequestsAsync(Id);
        }
        /// <summary>
        /// Get Reporters by Validator Address
        /// </summary>
        /// <param name="ValidatorAddress">Validator Address</param>
        /// <returns></returns>
        public async Task<OracleReporters> OracleReportersAsync(string ValidatorAddress)
        {
            return await _apiServices.OracleReportersAsync(ValidatorAddress);
        }
    }
}
