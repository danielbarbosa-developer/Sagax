using System.Threading.Tasks;

namespace Sagax.Orchestrator.Abstractions
{
    public interface IStepExecutor<TStep> where TStep : IStep
    {
        TStep Step { get; set; }
        Task ExecuteAsync(TStep step);
        void Execute(TStep step);
    }
}