using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Sagax.Choreography;
using Sagax.Choreography.Abstractions;
using Sagax.ChoreographyTest.Mock;

namespace Sagax.ChoreographyTest
{
    [TestFixture]
    public class BaseStepExecutorTests
    {
        BaseStepExecutor executor = new BaseStepExecutor();

        [Test]
        public void Execute_StepOne_MustBeSuccessTest()
        {
            StepOne one = new StepOne();
            executor.Execute(one);
            Assert.AreEqual(true, executor.Success);
        }
        [Test]
        public void Execute_StepTwo_MustBeFailedAndRollbackTest()
        {
            StepTwo two = new StepTwo();
            executor.Execute(two);
            Assert.AreEqual(false, executor.Success);
        }
    }

    
}