using System.Collections.Concurrent;

namespace BackgroundTasks
{
    // Pretend this is our cache for simplicity purposes
    public class SampleData
    {
        public ConcurrentBag<string> Data { get; set; } = new();
    }
}
