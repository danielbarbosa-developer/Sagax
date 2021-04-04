using System;
using System.Threading.Tasks;

namespace Sagax.Orchestrator.Abstractions
{
    public interface IStep
    {
        Guid TransactionId { get; set; } 
        Task RunAsync();
        void Run();
        Task RollbackAsync();
        void Rollback();
    }
}