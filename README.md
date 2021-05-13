# BandChain.Net
BandChain.Net is a dotnet library for interact with BandChain

## Usage
using BandChain.Net;
```c#
BandChainServices bandChain = new();
var result = await bandChain.OracleDataSoursesAsync(1);
Console.WriteLine(JsonConvert.SerializeObject(result));
```
## Result
```json
{
  "height":"5797307",
  "result":
    {
      "owner": "band1nl23kd2w7vehmk6d6scrs9jagqrdrxrat32vxv",
      "name": "CryptoCompare",
      "description": "Query latest cryptocurrency token prices from CryptoCompare. Accepts multiple space-separated symbols.",
      "filename": "7e6759fade717a06fb643392bfde837bfc3437da2ded54feed706e6cd35de461"
    }
}
```
