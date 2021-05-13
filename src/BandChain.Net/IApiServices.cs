using BandChain.Net.Models;
using System.Threading.Tasks;

namespace BandChain.Net.Services
{
    public interface IApiServices
    {
        Task<OracleDataSources> OracleDataSoursesAsync(int Id);
        Task<OracleScripts> OracleScriptsAsync(int Id);
        Task<OracleRequests> OracleRequestsAsync(int Id);
        Task<OracleReporters> OracleReportersAsync(string ValidatorAddress);
    }
}
