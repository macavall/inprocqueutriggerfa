using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace inprocqueutriggerfa
{
    public class queue
    {
        [FunctionName("queue")]
        public void Run([QueueTrigger("myqueue", Connection = "storconnstring")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
