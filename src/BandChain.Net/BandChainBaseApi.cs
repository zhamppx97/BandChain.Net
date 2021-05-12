
namespace BandChain.Net.Infrastructure
{
    public static class BandChainBaseApi
    {
        static readonly string Url = "https://api-gm-lb.bandchain.org";

        public static class Endpoint
        {
            public static string OracleDataSourses(int Id)
            {
                return $"{Url}/oracle/data_sources/{Id}";
            }
        }
    }
}
