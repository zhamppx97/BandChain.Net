using BandChain.Net;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDataSoursesAsync().Wait();
            OracleScriptsAsync().Wait();
            OracleRequestsAsync().Wait();
            OracleReportersAsync().Wait();
        }

        static async Task OracleDataSoursesAsync()
        {
            BandChainServices bandChain = new();
            var result = await bandChain.OracleDataSoursesAsync(1);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        static async Task OracleScriptsAsync()
        {
            BandChainServices bandChain = new();
            var result = await bandChain.OracleScriptsAsync(1);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        static async Task OracleRequestsAsync()
        {
            BandChainServices bandChain = new();
            var result = await bandChain.OracleRequestsAsync(1);
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        static async Task OracleReportersAsync()
        {
            BandChainServices bandChain = new();
            var result = await bandChain.OracleReportersAsync("bandvaloper1p40yh3zkmhcv0ecqp3mcazy83sa57rgjde6wec");
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
