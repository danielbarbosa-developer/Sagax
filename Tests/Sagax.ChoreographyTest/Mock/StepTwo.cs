using System.Threading.Tasks;
using Sagax.Choreography.Abstractions;

namespace Sagax.ChoreographyTest.Mock
{
    public class StepTwo : IStep
    {
        public async Task RunAsync()
        {
            int value = 2 - 2;
            var operation =  2 / value;
            
        }

        public void Run()
        {
            int value = 2 - 2;
            var operation =  2 / value;
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