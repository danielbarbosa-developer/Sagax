using System;
using System.Threading.Tasks;
using Sagax.Orchestrator.Abstractions;

namespace Sagax.Orchestrator
{
    public class BaseStepExecutor<TStep> : IStepExecutor<TStep> where TStep : IStep
    {
        public TStep Step { get; set; }
        public Exception Error { get; private set; }
        public bool Success { get; private set; }
        public virtual async Task ExecuteAsync(TStep step)
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

        public virtual void Execute(TStep step)
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