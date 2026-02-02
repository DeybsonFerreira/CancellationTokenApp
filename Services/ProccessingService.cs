namespace CancellationTokenApp.Services
{
    public static class ProccessingService
    {
        public static async Task Start(CancellationToken cancellationToken)
        {
            for (int i = 1; i <= 100; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Task.Delay(3000, cancellationToken);
                Console.WriteLine($"Processando etapa {i}/100...");
            }
        }

        public static async Task StartNoCancellation()
        {
            for (int i = 1; i <= 100; i++)
            {
                await Task.Delay(3000);
                Console.WriteLine($"Processando etapa {i}/100...");
            }
        }

        //public static void Codes()
        //{
        //    CancellationTokenSource manual = new CancellationTokenSource();
        //    manual.Cancel();

        //    if (manual.Token.IsCancellationRequested)
        //        throw new OperationCanceledException(manual.Token);

        //}
    }
}