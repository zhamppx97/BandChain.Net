using BandChain.Net.Models;
using System.Threading.Tasks;

namespace BandChain.Net.Services
{
    public interface IApiServices
    {
        Task<OracleDataSources> OracleDataSoursesAsync(int Id);
    }
}
