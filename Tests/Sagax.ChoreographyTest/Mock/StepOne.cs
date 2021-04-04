using System.Threading.Tasks;
using Sagax.Choreography.Abstractions;

namespace Sagax.ChoreographyTest.Mock
{
    public class StepOne : IStep
    {
        public async Task RunAsync()
        {
            var operation = 2 + 2;
            
        }

        public void Run()
        {
            var operation = 2 + 2;
        }

        public async Task RollbackAsync()
        {
            var operation = 2 - 2;
        }

        public void Rollback()
        {
            var operation = 2 - 2;
        }
    }
}