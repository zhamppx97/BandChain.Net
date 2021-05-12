
namespace BandChain.Net.Models
{
    #region OracleDataSources
    public class OracleDataSources
    {
        public string height { get; set; }
        public OracleDataSourcesResult result { get; set; }
    }
    public class OracleDataSourcesResult
    {
        public string description { get; set; }
        public string filename { get; set; }
        public string name { get; set; }
        public string owner { get; set; }
    }
    #endregion
}
