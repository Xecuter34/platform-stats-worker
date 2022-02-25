using platform_stats_worker.API;

Console.WriteLine("Stats worker started...");
while (await StartStatsWorkerAsync()) {
    Console.WriteLine($"Fetching stats for services: {"Test"}");
    Thread.Sleep(2000);
}

Console.WriteLine("Stats worker stopped...");
throw new Exception("Stats worker has encountered an error, please review logs.");

static async Task<bool> StartStatsWorkerAsync()
{
    try
    {
        RainbowSixAPI RS6Api = new();
        await RS6Api.GetPlayerStats();
        return true;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return false;
    }
} 
