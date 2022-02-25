using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platform_stats_worker.API
{
    internal class RainbowSixAPI
    {
        public async Task<bool> GetPlayerStats()
        {
            Console.WriteLine($"Fetching stats for Rainbow Six Siege for {0} accounts...");
            Thread.Sleep(5000);
            throw new NotImplementedException("API Request not yet implemented.");
        }
    }
}
