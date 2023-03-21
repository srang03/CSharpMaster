using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitAsync._05_WhyUseCancellationToken
{
    public class ZeroToHundredManager
    {
        private int count;
        public async Task Run(Action<int> countAction, CancellationToken token)
        {
            count = 0;
            countAction.Invoke(count);

            await Task.Run(() =>
            {
                while(count <= 100)
                {
                    if (token.IsCancellationRequested) break;
                    countAction(count);
                    Thread.Sleep(20);
                    count++;
                }
            });
        }
    }
}