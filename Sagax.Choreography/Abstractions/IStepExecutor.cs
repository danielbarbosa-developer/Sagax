using System;
using System.Threading.Tasks;

namespace Sagax.Choreography.Abstractions
{
    public interface IStepExecutor
    {
        Guid TransactionId { get; set; }
        Task ExecuteAsync(IStep step);
        void Execute(IStep step);
    }
}