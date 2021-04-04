using System;
using System.Threading.Tasks;

namespace Sagax.Choreography.Abstractions
{
    public interface IStep
    {
        Task RunAsync();
        void Run();
        Task RollbackAsync();
        void Rollback();
    }
}