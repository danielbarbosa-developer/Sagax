using System;
using System.Threading.Tasks;
using Sagax.Choreography.Abstractions;

namespace Sagax.Choreography
{
    public class BaseStepExecutor : IStepExecutor
    {
        public Guid TransactionId { get; set; }
        public Exception Error { get; private set; }
        public bool Success { get; private set; }

        public BaseStepExecutor()
        {
            TransactionId = Guid.NewGuid();
        }

        public BaseStepExecutor(Guid transactionId)
        {
            TransactionId = transactionId;
        }
        public virtual async Task ExecuteAsync(IStep step)
        {
            try
            {
                await step.RunAsync();
                Success = true;
            }
            catch (Exception e)
            {
                await step.RollbackAsync();
                Error = e;
                Success = false;
            }
        }

        public virtual void Execute(IStep step)
        {
            try
            {
                step.Run();
                Success = true;
            }
            catch (Exception e)
            {
                step.Rollback();
                Error = e;
                Success = false;
            }
        }
    }
}