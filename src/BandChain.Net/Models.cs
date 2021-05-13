using System.Collections.Generic;

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
    #region OracleScripts
    public class OracleScripts
    {
        public string height { get; set; }
        public OracleScriptsResult result { get; set; }
    }
    public class OracleScriptsResult
    {
        public string owner { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string filename { get; set; }
        public string schema { get; set; }
        public string source_code_url { get; set; }
    }
    #endregion
    #region OracleRequests
    public class OracleRequests
    {
        public string height { get; set; }
        public OracleRequestResult result { get; set; }
    }

    public class OracleRequestResult
    {
        public OracleRequestRequest request { get; set; }
        public List<OracleRequestReport> reports { get; set; }
        public OracleRequestResult1 result { get; set; }
    }

    public class OracleRequestRequest
    {
        public string oracle_script_id { get; set; }
        public string calldata { get; set; }
        public string[] requested_validators { get; set; }
        public string min_count { get; set; }
        public string request_height { get; set; }
        public string request_time { get; set; }
        public string client_id { get; set; }
        public List<OracleRequestRaw_Requests> raw_requests { get; set; }
    }

    public class OracleRequestRaw_Requests
    {
        public string external_id { get; set; }
        public string data_source_id { get; set; }
        public string calldata { get; set; }
    }

    public class OracleRequestResult1
    {
        public OracleRequestRequest_Packet_Data request_packet_data { get; set; }
        public OracleRequestResponse_Packet_Data response_packet_data { get; set; }
    }

    public class OracleRequestRequest_Packet_Data
    {
        public string client_id { get; set; }
        public string oracle_script_id { get; set; }
        public string calldata { get; set; }
        public string ask_count { get; set; }
        public string min_count { get; set; }
    }

    public class OracleRequestResponse_Packet_Data
    {
        public string client_id { get; set; }
        public string request_id { get; set; }
        public string ans_count { get; set; }
        public string request_time { get; set; }
        public string resolve_time { get; set; }
        public int resolve_status { get; set; }
        public string result { get; set; }
    }

    public class OracleRequestReport
    {
        public string validator { get; set; }
        public bool in_before_resolve { get; set; }
        public List<OracleRequestRaw_Reports> raw_reports { get; set; }
    }

    public class OracleRequestRaw_Reports
    {
        public string external_id { get; set; }
        public string data { get; set; }
    }
    #endregion
    #region OracleReporters
    public class OracleReporters
    {
        public string height { get; set; }
        public List<string> result { get; set; }
    }
    #endregion
}
