
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
            public static string OracleScripts(int Id)
            {
                return $"{Url}/oracle/oracle_scripts/{Id}";
            }
            public static string OracleRequests(int Id)
            {
                return $"{Url}/oracle/requests/{Id}";
            }
            public static string OracleReporters(string ValidatorAddress)
            {
                return $"{Url}/oracle/reporters/{ValidatorAddress}";
            }
            public static string OracleReportInfo(string ValidatorAddress)
            {
                return $"{Url}/oracle/report_info/{ValidatorAddress}";
            }
            public static string OracleParams()
            {
                return $"{Url}/oracle/params";
            }
            public static string OracleCounts()
            {
                return $"{Url}/oracle/counts";
            }
        }
    }
}
