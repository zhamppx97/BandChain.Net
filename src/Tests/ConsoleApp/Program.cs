using BandChain.Net;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OracleDataSoursesAsync().Wait();
        }

        static async Task OracleDataSoursesAsync()
        {
            BandChainServices bandChain = new();
            var result = await bandChain.OracleDataSoursesAsync(1);
            Console.WriteLine(result.height);
        }
    }
}
