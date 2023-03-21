using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitAsync._05_WhyUseCancellationToken
{
    public class HundredManagerToZero
    {
        public async Task Run(Action<int> countAction, CancellationToken token)
        {
            int count = 100;
            countAction?.Invoke(count);
            await Task.Run(() =>
            {
                while (count >= 0)
                {
                    if (token.IsCancellationRequested) break;
                    countAction?.Invoke(count);
                    Thread.Sleep(20);
                    count--;
                }
            });
        }

    }
}