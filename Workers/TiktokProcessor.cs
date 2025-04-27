namespace TiktokWorker.Workers;

public class TiktokProcessor : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        return Task.CompletedTask;
    }
}
